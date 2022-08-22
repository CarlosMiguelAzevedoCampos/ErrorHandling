namespace CMA.ErrorHandling.Notifications.Handling.Interface
{
    public interface INotificationService
    {
        bool IsOperationValid();
        string[] ObtainErrors();
        void AddError(string error);
    }
}
