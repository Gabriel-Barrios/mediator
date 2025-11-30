using System.Threading;
using System.Threading.Tasks;

namespace Mediator;

public interface ISender
{
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default) where TResponse : Response;
}
