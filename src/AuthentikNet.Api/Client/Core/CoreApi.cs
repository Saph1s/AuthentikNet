using AuthentikNet.Api.Models;

namespace AuthentikNet.Api.Client.Core;

public class CoreApi
{
    private readonly AuthentikClient _client;

    public CoreApi(AuthentikClient client)
    {
        _client = client;
    }

    /// <summary>
    /// User Viewset
    /// </summary>
    /// <param name="attributes">Attributes</param>
    /// <param name="email"></param>
    /// <param name="groupsByName"></param>
    /// <param name="groupsByPk"></param>
    /// <param name="isActive"></param>
    /// <param name="isSuperuser"></param>
    /// <param name="name"></param>
    /// <param name="ordering">Which field to use when ordering the results.</param>
    /// <param name="page">A page number within the paginated result set.</param>
    /// <param name="pageSize">Number of results to return per page.</param>
    /// <param name="path"></param>
    /// <param name="pathStartswith"></param>
    /// <param name="search">A search term.</param>
    /// <param name="type_"></param>
    /// <param name="username"></param>
    /// <param name="uuid"></param>
    /// <param name="includeGroups"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<PaginatedUserList> CoreUsersList(
        string? attributes = null,
        string? email = null,
        string[]? groupsByName = null,
        string[]? groupsByPk = null,
        bool? isActive = null,
        bool? isSuperuser = null,
        string? name = null,
        string? ordering = null,
        int? page = null,
        int? pageSize = null,
        string? path = null,
        string? pathStartswith = null,
        string? search = null,
        string[]? type_ = null,
        string? username = null,
        Guid? uuid = null,
        bool includeGroups = true, CancellationToken cancellationToken = default)

    {
        var url = "/core/users/";
        var queryDict = new Dictionary<string, object?>
            {
                { "attributes", attributes },
                { "email", email },
                { "groups_by_name", groupsByName },
                { "groups_by_pk", groupsByPk },
                { "is_active", isActive },
                { "is_superuser", isSuperuser },
                { "name", name },
                { "ordering", ordering },
                { "page", page },
                { "page_size", pageSize },
                { "path", path },
                { "path_startswith", pathStartswith },
                { "search", search },
                { "type", type_ },
                { "username", username },
                { "uuid", uuid },
                { "include_groups", includeGroups }
            }.Where(kv => kv.Value != null)
            .ToDictionary(kv => kv.Key, kv => kv.Value);

        url += "?" + string.Join("&", queryDict.Select(x => $"{x.Key}={x.Value}"));


        return await _client.SendAsync<PaginatedUserList>(HttpMethod.Get, url,
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// User Viewset
    /// </summary>
    /// <param name="id">A unique integer value identifying this User.</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<User> CoreUsersRetrieve(int id, CancellationToken cancellationToken = default)
    {
        return await _client.SendAsync<User>(HttpMethod.Get, $"/core/users/{id}/",
            cancellationToken: cancellationToken);
    }
}