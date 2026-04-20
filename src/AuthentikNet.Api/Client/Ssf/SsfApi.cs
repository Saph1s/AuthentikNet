using AuthentikNet.Api.Models;

namespace AuthentikNet.Api.Client.Ssf;

public class SsfApi
{
    private readonly AuthentikClient _client;

    public SsfApi(AuthentikClient client)
    {
        _client = client;
    }

    /// <summary>
    /// SSFStream Viewset
    /// </summary>
    /// <param name="deliveryMethod"></param>
    /// <param name="endpointUrl"></param>
    /// <param name="ordering">Which field to use when ordering the results</param>
    /// <param name="page">A page number within the paginated result set</param>
    /// <param name="pageSize">Number of results to return per page</param>
    /// <param name="provider"></param>
    /// <param name="search">A search term</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<PaginatedSSFStreamList> SsfStreamsList(string? deliveryMethod, string? endpointUrl,
        string? ordering, int? page,
        int? pageSize, int? provider, string? search, CancellationToken cancellationToken = default)
    {
        var url = "/ssf/streams/";
        var queryParameters = new Dictionary<string, object?>
            {
                { "delivery_method", deliveryMethod },
                { "endpoint_url", endpointUrl },
                { "ordering", ordering },
                { "page", page },
                { "page_size", pageSize },
                { "provider", provider },
                { "search", search }
            }
            .Where(kv => kv.Value != null)
            .ToDictionary(kv => kv.Key, kv => kv.Value!);

        if (queryParameters.Count > 0)
        {
            var query = string.Join("&", queryParameters
                .Select(x => $"{x.Key}={Uri.EscapeDataString(x.Value.ToString()!)}"));
            url += "?" + query;
        }

        return await _client.SendAsync<PaginatedSSFStreamList>(HttpMethod.Get, url,
            cancellationToken: cancellationToken);
    }
}