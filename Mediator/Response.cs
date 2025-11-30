using System;

namespace Mediator;

public class Error
{
    public string Message { get; }
    public Exception? Exception { get; }

    public Error(string message, Exception? exception = null)
    {
        Message = message;
        Exception = exception;
    }
}

public class Response
{
    public bool Succeed { get; }
    public Error? Error { get; }

    protected Response(bool succeed, Error? error = null)
    {
        Succeed = succeed;
        Error = error;
    }

    public static Response Success() => new(true);
    public static Response Failure(string message, Exception? ex = null) => new(false, new Error(message, ex));
}

public class Response<T> : Response
{
    public T? Data { get; }

    private Response(T data) : base(true)
    {
        Data = data;
    }

    private Response(Error error) : base(false, error)
    {
        Data = default;
    }

    public static Response<T> Success(T data) => new(data);
    public new static Response<T> Failure(string message, Exception? ex = null) => new(new Error(message, ex));
}
