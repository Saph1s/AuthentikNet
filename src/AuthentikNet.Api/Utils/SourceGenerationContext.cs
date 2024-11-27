using System.Text.Json.Serialization;
using AuthentikNet.Api.Models;
using Version = AuthentikNet.Api.Models.Version;

namespace AuthentikNet.Api.Utils;

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata)]
[JsonSerializable(typeof(App))]
[JsonSerializable(typeof(Coordinate))]
[JsonSerializable(typeof(Group))]
[JsonSerializable(typeof(GroupMember))]
[JsonSerializable(typeof(LoginMetrics))]
[JsonSerializable(typeof(PaginatedUserList))]
[JsonSerializable(typeof(Pagination))]
[JsonSerializable(typeof(Role))]
[JsonSerializable(typeof(Settings))]
[JsonSerializable(typeof(SystemInfo))]
[JsonSerializable(typeof(SystemInfoRuntime))]
[JsonSerializable(typeof(User))]
[JsonSerializable(typeof(UserGroup))]
[JsonSerializable(typeof(UserRequest))]
[JsonSerializable(typeof(UserTypeEnum))]
[JsonSerializable(typeof(Version))]
[JsonSerializable(typeof(VersionHistory))]
[JsonSerializable(typeof(Workers))]
[JsonSerializable(typeof(Dictionary<string, object>))]
[JsonSerializable(typeof(List<object>))]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(object))]
public partial class SourceGenerationContext : JsonSerializerContext
{
}