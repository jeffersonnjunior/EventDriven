namespace Domain.Exceptions;

public class NotificationModel
{
    public string Key { get; set; }
    public string Message { get; }

    public NotificationModel(string key, string message)
    {
        Key = key;
        Message = message;
    }
}