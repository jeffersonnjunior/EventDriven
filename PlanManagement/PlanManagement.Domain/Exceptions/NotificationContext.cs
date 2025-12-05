namespace Domain.Exceptions;

public class NotificationContext
{
    private readonly List<NotificationModel> _notifications;

    public NotificationContext()
    {
        _notifications = new List<NotificationModel>();
    }
    public IReadOnlyCollection<NotificationModel> GetNotifications() => _notifications.AsReadOnly();
    public void AddNotification(string key, string message) => _notifications.Add(new NotificationModel(key, message));
    public bool HasNotifications() => _notifications.Count > 0;
}