// using System;
//
// namespace Mediator;
//
// public class ErrorData
// {
//     public string Message { get; }
//     public Exception? Exception { get; }
//
//     public ErrorData(string message, Exception? exception = null)
//     {
//         Message = message;
//         Exception = exception;
//     }
// }
//
// public class RequestResponse
// {
//     public bool Succeed { get; }
//     public ErrorData? Error { get; }
//
//     protected RequestResponse(bool succeed, ErrorData? error = null)
//     {
//         Succeed = succeed;
//         Error = error;
//     }
//
//     public static RequestResponse Success() => new(true);
//     public static RequestResponse Failure(string message, Exception? ex = null) => new(false, new ErrorData(message, ex));
// }
//
// public class RequestResponse<T> : RequestResponse
// {
//     public T? Data { get; }
//
//     private RequestResponse(T data) : base(true)
//     {
//         Data = data;
//     }
//
//     private RequestResponse(ErrorData error) : base(false, error)
//     {
//         Data = default;
//     }
//
//     public static RequestResponse<T> Success(T data) => new(data);
//     public new static RequestResponse<T> Failure(string message, Exception? ex = null) => new(new ErrorData(message, ex));
// }
