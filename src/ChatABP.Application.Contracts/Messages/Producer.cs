using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatABP.Messages
{
    public  class Producer
    {
        public  void Main()
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqps://jqltktwa:SW-Yy67p5RIUMlBD_U6GlnPEyC1OUzw_@gerbil.rmq.cloudamqp.com/jqltktwa")
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("user-messages",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var message = new { Pattern = "message_printed", Data = "Lan dep trai" };
            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            })
            );

            channel.BasicPublish("", "user-messages", null, body);
        }
    }
}
