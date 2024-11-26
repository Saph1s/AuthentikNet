using AuthentikNet.Api.Models;

namespace AuthentikNet.Api.Client.Core;

public class CoreApi
{
    private readonly AuthentikClient _client;

    public CoreApi(AuthentikClient client)
    {
        _client = client;
    }

    public async Task<PaginatedUserList> CoreUsersList(
        string? attributes,
        string? email,
        string[]? groupsByName,
        string[]? groupsByPk,
        bool? isActive,
        bool? isSuperuser,
        string? name,
        string? ordering,
        int? page,
        int? pageSize,
        string? path,
        string? pathStartswith,
        string? search,
        string[]? type_,
        string? username,
        Guid? uuid,
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
}