using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlutterwaveController : ControllerBase
    {
        private readonly FlutterwaveService _flutterwaveService;

        public FlutterwaveController(FlutterwaveService flutterwaveService)
        {
            _flutterwaveService = flutterwaveService;
        }


        [HttpGet("banks")]
        public async Task<IActionResult> GetBanks()
        {
            var banks = await _flutterwaveService.GetBankListAsync();
            return Ok(banks);
        }
    }
}
