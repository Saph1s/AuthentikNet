﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class User
{
    [JsonPropertyName("pk")] public required int Pk { get; init; }
    [JsonPropertyName("username")] public required string Username { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("is_active")] public bool IsActive { get; set; }
    [JsonPropertyName("last_login")] public DateTime? LastLogin { get; set; }
    [JsonPropertyName("is_superuser")] public required bool IsSuperUser { get; init; }
    [JsonPropertyName("groups")] public List<Guid> Groups { get; set; } = [];
    [JsonPropertyName("groups_obj")] public required List<UserGroup> GroupsObj { get; init; }
    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;
    [JsonPropertyName("avatar")] public required string Avatar { get; init; }
    [JsonPropertyName("attributes")] public Dictionary<string, string> Attributes { get; set; } = new();
    [JsonPropertyName("uid")] public required string Uid { get; init; }
    [JsonPropertyName("path")] public string Path { get; set; } = string.Empty;
    [JsonPropertyName("type")] public UserTypeEnum Type { get; set; }
    [JsonPropertyName("uuid")] public required Guid Uuid { get; init; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserTypeEnum
{
    [EnumMember(Value = "internal")] Internal,
    [EnumMember(Value = "external")] External,

    [EnumMember(Value = "service_account")]
    ServiceAccount,

    [EnumMember(Value = "internal_service_account")]
    InternalServiceAccount
}