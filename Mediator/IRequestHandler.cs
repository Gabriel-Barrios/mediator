using System.Threading;
using System.Threading.Tasks;

namespace Mediator;

public interface IRequestHandler<in TRequest, TResponse> 
    where TRequest : IRequest<TResponse>
    where TResponse : Response
{
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}
