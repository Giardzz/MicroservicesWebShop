using RabbitMQ.Client;
using System;

namespace EventBusRabbitMQ
{
    public interface IRabbitMQConnection :IDisposable
    {
        bool isConnected { get; }
        bool TryConnect();
        IModel CreateModel();
    }
}
