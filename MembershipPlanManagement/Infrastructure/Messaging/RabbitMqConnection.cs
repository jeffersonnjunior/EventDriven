using RabbitMQ.Client;

namespace Infrastructure.Messaging;

public class RabbitMqConnection
{
    public IConnection GetConnection(string hostName, string userName, string password)
    {
        var factory = new ConnectionFactory()
        {
            HostName = hostName,
            UserName = userName,
            Password = password
        };
        return factory.CreateConnection();
    }
}
