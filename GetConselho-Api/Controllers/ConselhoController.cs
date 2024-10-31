using GetConselho_Api.Model;
using GetConselho_Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ConselhoController : ControllerBase
{
    private readonly IConselhoService _conselhoService;

    public ConselhoController(IConselhoService conselhoService)
    {
        _conselhoService = conselhoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetConselho()
    {
        using (var httpClient = new HttpClient())
        {
            var response = await _conselhoService.GetConselho();

            if (response == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter o conselho.");
            } 
             
            return StatusCode(StatusCodes.Status200OK, (new { Advice = response }));
        }
    }
}
