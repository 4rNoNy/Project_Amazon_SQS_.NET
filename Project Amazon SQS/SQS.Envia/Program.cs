using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Envia
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enviando mensagem para a fila...");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new SendMessageRequest
            {
                QueueUrl = "[Pegar a Queue URL com Itallo]",
                MessageBody = "Itallo BoBaião :P"
            };

            await client.SendMessageAsync(request);
        }
    }
}
