using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using AuthentikNet.Api.Client.Admin;
using AuthentikNet.Api.Client.Core;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Client;

public class AuthentikClient
{
    private readonly HttpClient _client;
    private readonly AuthentikClientOptions _options;

    public AdminApi Admin { get; }
    public CoreApi Core { get; }

    public AuthentikClient(AuthentikClientOptions options)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));

        _client = new HttpClient
        {
            BaseAddress = new Uri(options.BaseUrl),
            Timeout = options.Timeout
        };

        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.Token);
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("AuthentikNet.Api.Client",
            $"{GetType().Assembly.GetName().Version}")); // TODO: Need to set correct version

        Admin = new AdminApi(this);
        Core = new CoreApi(this);
    }

    public async Task<T> SendAsync<T>(HttpMethod method, string path, object? data = null,
        CancellationToken cancellationToken = default)
    {
        var request = new HttpRequestMessage(method, _options.BaseUrl + path);
        try
        {
            if (data != null)
            {
                request.Content = new StringContent(
                    JsonSerializer.Serialize(data),
                    Encoding.UTF8,
                    "application/json"
                );
            }

            var response = await _client.SendAsync(request, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                await HandleError(response);
            }

            return await DeserializeResponseAsync<T>(response);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private async Task<T> DeserializeResponseAsync<T>(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(content, SourceGenerationContext.Default.Options) ??
               throw new AuthentikException("Failed to deserialize response", 500);
    }

    private async Task HandleError(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        string errorMessage;

        if (response.Content.Headers.ContentType?.MediaType == "application/json")
        {
            try
            {
                var json = JsonDocument.Parse(content);
                errorMessage = json.RootElement.ToString();
            }
            catch (JsonException)
            {
                errorMessage = content;
            }
        }
        else
        {
            errorMessage = content;
        }

        throw response.StatusCode switch
        {
            HttpStatusCode.BadRequest => new AuthentikBadRequestException(errorMessage),
            HttpStatusCode.Unauthorized => new AuthentikUnauthorizedException(errorMessage),
            HttpStatusCode.Forbidden => new AuthentikForbiddenException(errorMessage),
            _ => new AuthentikException(errorMessage, (int)response.StatusCode)
        };
    }
}