namespace AuthentikNet.Api.Client;

/// <summary>
/// Generic Authentik exception
/// </summary>
public class AuthentikException : Exception
{
    public int StatusCode { get; }

    public AuthentikException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
}

/// <summary>
/// "Bad request" exception
/// </summary>
public class AuthentikBadRequestException : AuthentikException
{
    public AuthentikBadRequestException(string message) : base(message, 400)
    {
    }
}

/// <summary>
/// "Unauthorized" exception
/// </summary>
public class AuthentikUnauthorizedException : AuthentikException
{
    public AuthentikUnauthorizedException(string message) : base(message, 401)
    {
    }
}

/// <summary>
/// "Forbidden" exception
/// </summary>
public class AuthentikForbiddenException : AuthentikException
{
    public AuthentikForbiddenException(string message) : base(message, 403)
    {
    }
}

/// <summary>
/// "Not found" exception
/// </summary>
public class AuthentikNotFoundException : AuthentikException
{
    public AuthentikNotFoundException(string message) : base(message, 404)
    {
    }
}