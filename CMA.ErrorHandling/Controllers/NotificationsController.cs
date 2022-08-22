using CMA.ErrorHandling.Notifications.Domain.Interfaces;
using CMA.ErrorHandling.Notifications.Handling.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CMA.ErrorHandling.Notifications.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class NotificationsController : BaseController
    {
        private readonly IErrorHandlingService _errorHandlingService;
        public NotificationsController(INotificationService notificationService, IErrorHandlingService errorHandlingService) : base(notificationService)
        {
            _errorHandlingService = errorHandlingService;
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            _errorHandlingService.Error();
            return CustomResponse(); 
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            _errorHandlingService.Success();
            return CustomResponse();
        }
    }
}
