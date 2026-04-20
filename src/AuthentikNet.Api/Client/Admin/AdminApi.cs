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

    /// <summary>
    /// Read-only view list all installed apps
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<App>> AdminAppsList(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<List<App>>(HttpMethod.Get, "/admin/apps/", cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Login Metrics per 1h
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<LoginMetrics> AdminMetricsRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<LoginMetrics>(HttpMethod.Get, "/admin/metrics/",
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Read-only view list all installed models
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<App>> AdminModelsList(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<List<App>>(HttpMethod.Get, "/admin/models/",
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Get settings
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Settings> AdminSettingsRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Settings>(HttpMethod.Get, "/admin/settings/",
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Update settings
    /// </summary>
    /// <param name="data">Settings model</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Settings> AdminSettingsUpdate(Settings data, CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Settings>(HttpMethod.Put, "/admin/settings/", data, cancellationToken);
    }

    /// <summary>
    /// Partial update settings
    /// </summary>
    /// <param name="data">PartialSettings moder</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Settings> AdminSettingsPartialUpdate(PatchedSettingsRequest data,
        CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Settings>(HttpMethod.Patch, "/admin/settings/", data, cancellationToken);
    }

    /// <summary>
    /// Get system information
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<SystemInfo> AdminSystemRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<SystemInfo>(HttpMethod.Get, "/admin/system/",
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Get system information
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<SystemInfo> AdminSystemCreate(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<SystemInfo>(HttpMethod.Post, "/admin/system/",
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Get running and latest version
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Version> AdminVersionRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Version>(HttpMethod.Get, "/admin/version/",
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// VersionHistory Viewset
    /// </summary>
    /// <param name="build"></param>
    /// <param name="ordering">Which field to use when ordering the results.</param>
    /// <param name="search">A search term.</param>
    /// <param name="version"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<VersionHistory>> AdminVersionHistoryList(
        string? build = null,
        string? ordering = null,
        string? search = null,
        string? version = null,
        CancellationToken cancellationToken = default)
    {
        var url = "/admin/version/history/";
        var queryParameters = new Dictionary<string, string?>
            {
                { "build", build },
                { "ordering", ordering },
                { "search", search },
                { "version", version }
            }
            .Where(kv => kv.Value != null)
            .ToDictionary(kv => kv.Key, kv => kv.Value!);

        if (queryParameters.Count > 0)
        {
            var query = string.Join("&", queryParameters
                .Select(x => $"{x.Key}={Uri.EscapeDataString(x.Value)}"));
            url += "?" + query;
        }

        return await _client.SendAsync<List<VersionHistory>>(HttpMethod.Get, url, cancellationToken: cancellationToken);
    }

    /// <summary>
    /// VersionHistory Viewset
    /// </summary>
    /// <param name="id">A unique integer value identifying this Version history.</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<VersionHistory> AdminVersionHistoryRetrieve(int id, CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<VersionHistory>(HttpMethod.Get, $"/admin/version/history/{id}/",
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Get currently connected worker count.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Workers> AdminWorkersRetrieve(CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<Workers>(HttpMethod.Get, "/admin/workers/",
            cancellationToken: cancellationToken);
    }
}