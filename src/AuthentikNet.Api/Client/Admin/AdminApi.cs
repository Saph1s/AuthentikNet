using AuthentikNet.Api.Models;
using Version = AuthentikNet.Api.Models.Version;

namespace AuthentikNet.Api.Client.Admin;

public class AdminApi
{
    private readonly AuthentikClient _client;

    public AdminApi(AuthentikClient client)
    {
        _client = client;
    }

    public async Task<List<App>> AdminAppsList(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<List<App>>(HttpMethod.Get, "/admin/apps/", cancellationToken: cancellationToken);
    }

    public async Task<LoginMetrics> AdminMetricsRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<LoginMetrics>(HttpMethod.Get, "/admin/metrics/",
            cancellationToken: cancellationToken);
    }

    public async Task<List<App>> AdminModelsList(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<List<App>>(HttpMethod.Get, "/admin/models/",
            cancellationToken: cancellationToken);
    }

    public async Task<Settings> AdminSettingsRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Settings>(HttpMethod.Get, "/admin/settings/",
            cancellationToken: cancellationToken);
    }

    public async Task<Settings> AdminSettingsUpdate(Settings data, CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Settings>(HttpMethod.Put, "/admin/settings/", data, cancellationToken);
    }

    public async Task<Settings> AdminSettingsPartialUpdate(Settings data, CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Settings>(HttpMethod.Patch, "/admin/settings/", data, cancellationToken);
    }

    public async Task<SystemInfo> AdminSystemRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<SystemInfo>(HttpMethod.Get, "/admin/system/",
            cancellationToken: cancellationToken);
    }

    public async Task<SystemInfo> AdminSystemCreate(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<SystemInfo>(HttpMethod.Post, "/admin/system/",
            cancellationToken: cancellationToken);
    }

    public async Task<Version> AdminVersionRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Version>(HttpMethod.Get, "/admin/version/",
            cancellationToken: cancellationToken);
    }

    public async Task<List<VersionHistory>> AdminVersionHistoryList(
        string? build,
        string? ordering,
        string? search,
        string? version,
        CancellationToken cancellationToken = default)
    {
        var url = "/admin/version/history/";
        var queryParameters = new Dictionary<string, string>();
        if (build != null) queryParameters.Add("build", build);
        if (ordering != null) queryParameters.Add("ordering", ordering);
        if (search != null) queryParameters.Add("search", search);
        if (version != null) queryParameters.Add("version", version);

        if (queryParameters.Count > 0)
        {
            url += "?" + string.Join("&", queryParameters.Select(x => $"{x.Key}={x.Value}"));
        }

        return await _client.SendAsync<List<VersionHistory>>(HttpMethod.Get, url, cancellationToken: cancellationToken);
    }

    public async Task<VersionHistory> AdminVersionHistoryRetrieve(int id, CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<VersionHistory>(HttpMethod.Get, $"/admin/version/history/{id}/",
            cancellationToken: cancellationToken);
    }

    public async Task<Workers> AdminWorkersRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Workers>(HttpMethod.Get, "/admin/workers/",
            cancellationToken: cancellationToken);
    }
}