using System.Collections;

namespace AuthentikNet.Api.Utils;

public static class QueryStringBuilder
{
    public static string BuildQueryString(string baseUrl, Dictionary<string, object?> parameters)
    {
        var queryParams = new List<string>();

        foreach (var (key, value) in parameters)
        {
            switch (value)
            {
                case null:
                    continue;
                case string str:
                    queryParams.Add($"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(str)}");
                    break;
                case IEnumerable enumerable:
                {
                    foreach (var item in enumerable)
                    {
                        queryParams.Add($"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(item?.ToString() ?? "")}");
                    }

                    break;
                }
                default:
                    queryParams.Add($"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(value.ToString() ?? "")}");
                    break;
            }
        }

        if (queryParams.Count == 0)
            return baseUrl;

        return baseUrl + (baseUrl.Contains('?') ? "&" : "?") + string.Join("&", queryParams);
    }
}