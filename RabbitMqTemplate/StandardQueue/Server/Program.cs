using Common.Messages;
using Common.Messages.ValueObjects;
using Common.Utils;
using RabbitMQ.Client;

namespace Server
{
    class Program
    {
        private static ConnectionFactory _factory;
        private static IConnection _connection;
        private static IModel _model;

        static void Main(string[] args)
        {
            var samplePayments = SampleData.SamplePayments();


        }
    }
}
