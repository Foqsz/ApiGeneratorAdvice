using GetConselho_Api.Model;
using Refit;

namespace GetConselho_Api.Services.Refit
{
    public interface IConselhoServiceRefit
    {
        [Get("/advice")]
        Task<ApiResponse<ConselhoResponse>> GetConselhoRefit();
    }
}
