using GetConselho_Api.Model;

namespace GetConselho_Api.Services.Interface
{
    public interface IConselhoService
    {
        Task<ConselhoResponse> GetConselho();
    }
}
