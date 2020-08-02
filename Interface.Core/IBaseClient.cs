using System.Threading.Tasks;

namespace Interface.Core
{
    public interface IBaseClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new();

        TResponse Execute<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new();
    }
}
