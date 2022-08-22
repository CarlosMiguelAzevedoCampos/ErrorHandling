using CMA.ErrorHandling.GlobalHandling.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CMA.ErrorHandling.GlobalHandling.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GlobalHandlingController : ControllerBase
    {
        private readonly IErrorHandlingService _errorHandlingService;
        public GlobalHandlingController(IErrorHandlingService errorHandlingService)
        {
            _errorHandlingService = errorHandlingService;
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            _errorHandlingService.Error();
            return BadRequest(); 
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            _errorHandlingService.Success();
            return Ok();
        }
    }
}
