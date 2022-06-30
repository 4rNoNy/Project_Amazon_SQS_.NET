using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Recebe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Oia as mensagem ai meu nobre ...");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new ReceiveMessageRequest
            {
                QueueUrl = "[Pegar a Queue URL com Itallo]"
            };

            while (true)
            {
                var response = await client.ReceiveMessageAsync(request);

                foreach (var mensagem in response.Messages)
                {
                    Console.WriteLine(mensagem.Body);
                    await client.DeleteMessageAsync("[Pegar a Queue URL com Itallo]", mensagem.ReceiptHandle);
                }
            }
        }
    }
}
