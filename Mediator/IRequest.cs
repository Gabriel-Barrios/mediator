namespace Mediator;

/// <summary>
/// Represents a request that returns a value.
/// </summary>
/// <typeparam name="TResponse">The type of the response.</typeparam>
public interface IRequest<out TResponse> where TResponse : Response
{
}
