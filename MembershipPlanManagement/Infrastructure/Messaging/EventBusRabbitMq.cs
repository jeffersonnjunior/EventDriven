using RabbitMQ.Client;

namespace Infrastructure.Messaging;

public class EventBusRabbitMq
{
    private readonly IConnection _connection;
    public EventBusRabbitMq(IConnection connection)
    {
        _connection = connection;
    }
}
