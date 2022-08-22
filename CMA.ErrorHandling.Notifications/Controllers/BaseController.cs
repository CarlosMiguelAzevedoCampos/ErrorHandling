using CMA.ErrorHandling.Notifications.Handling.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CMA.ErrorHandling.Notifications.Controllers
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        protected BaseController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (_notificationService.IsOperationValid())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Messages", _notificationService.ObtainErrors()}
            }));
        }
    }
}
