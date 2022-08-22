using CMA.ErrorHandling.Notifications.Domain.Interfaces;
using CMA.ErrorHandling.Notifications.Handling.Interface;

namespace CMA.ErrorHandling.Notifications.Domain.Service
{
    public class ErrorHandlingService : IErrorHandlingService
    {
        private readonly INotificationService _notificationService;

        public ErrorHandlingService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Error()
        {
            try
            {
                throw new Exception("Error");
            }
            catch (Exception ex)
            {
                _notificationService.AddError(ex.ToString());
            }
        }

        public void Success()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _notificationService.AddError(ex.ToString());
            }
        }
    }
}