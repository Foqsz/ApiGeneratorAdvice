using GetConselho_Api.Model;
using GetConselho_Api.Services.Interface;
using GetConselho_Api.Services.Refit;
using Newtonsoft.Json;

namespace GetConselho_Api.Services;

public class ConselhoService : IConselhoService
{
    private readonly IConselhoServiceRefit _conselhoServiceRefit;

    public ConselhoService(IConselhoServiceRefit conselhoServiceRefit)
    {
        _conselhoServiceRefit = conselhoServiceRefit;
    }

    public async Task<ConselhoResponse> GetConselho()
    {
        var conselhoResponse = await _conselhoServiceRefit.GetConselhoRefit();

        try
        {
            return conselhoResponse.Content; 
        }

        catch (Exception ex)
        {
            return null;
        }

    }
}
