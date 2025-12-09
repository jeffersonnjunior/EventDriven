namespace EventDriven.Domain.Events;

public static class DomainEvents
{
    private static List<object> _events = new List<object>();

    public static void Raise<T>(T eventInstance) where T : class
    {
        if (eventInstance == null) return;
        _events.Add(eventInstance);
    }

    public static IReadOnlyList<object> GetEvents()
    {
        return _events.AsReadOnly();
    }

    public static void ClearEvents()
    {
        _events.Clear();
    }
}

