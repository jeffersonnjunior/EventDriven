using RabbitMQ.Client;

namespace Infrastructure.Interfaces.Messaging
{
    public interface IEventBusRabbitMq
    {
        void Publish(string exchange, string routingKey, byte[] body);
        void Subscribe(string queue, string consumerTag, EventHandler<BasicDeliverEventArgs> receivedHandler);
        IModel CreateChannel();
    }
}
