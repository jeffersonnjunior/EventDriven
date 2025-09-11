namespace Infrastructure.Interfaces.Messaging
{
    public interface IRabbitMqConnection
    {
        RabbitMQ.Client.IConnection GetConnection(string hostName, string userName, string password);
    }
}
