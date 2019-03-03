using System;
using System.Threading.Tasks;
using MassTransit;

namespace Client
{
    class Program
    {
        public static Task Handle(ConsumeContext<Message.InfoMessage> ctx)
        {
            return Console.Out.WriteLineAsync($"received: {ctx.Message.Name}");
        }

        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc => {
                var host = sbc.Host(new Uri("rabbitmq://localhost"), h => { h.Username("guest"); h.Password("guest"); });

                sbc.ReceiveEndpoint(host, "recvqueue", ep => {
                    ep.Handler<Message.InfoMessage>(Handle);
                });
            });

            bus.Start();
            Console.WriteLine("odbiorca wystartował");
            Console.ReadKey();
            bus.Stop();
        }
    }
}
