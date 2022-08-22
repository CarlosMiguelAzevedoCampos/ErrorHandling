using CMA.ErrorHandling.Notifications.Handling.Interface;

namespace CMA.ErrorHandling.Notifications.Handling.Service
{
    public class NotificationService : INotificationService
    {
        private ICollection<string> _notifications;

        public NotificationService()
        {
            _notifications = new List<string>();
        }

        public void AddError(string error)
        {
            _notifications.Add(error);
        }

        public bool IsOperationValid()
        {
            return !_notifications.Any();
        }

        public string[] ObtainErrors()
        {
            return _notifications.ToArray();
        }
    }
}
