namespace AuthentikNet.Api.Client;

public class AuthentikException : Exception
{
    public int StatusCode { get; }

    public AuthentikException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
}

public class AuthentikBadRequestException : AuthentikException
{
    public AuthentikBadRequestException(string message) : base(message, 400)
    {
    }
}

public class AuthentikUnauthorizedException : AuthentikException
{
    public AuthentikUnauthorizedException(string message) : base(message, 401)
    {
    }
}

public class AuthentikForbiddenException : AuthentikException
{
    public AuthentikForbiddenException(string message) : base(message, 403)
    {
    }
}