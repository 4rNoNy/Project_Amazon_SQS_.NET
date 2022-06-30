using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.Runtime.CredentialManagement;

namespace SQS.Recebe
{
    class Program
    {
        static async Task Main()
        {
            try
            {
                var options = new CredentialProfileOptions
                {
                    AccessKey = "sua AccessKey aqui",
                    SecretKey = "sua SecretKey aqui"
                };
                Console.WriteLine("Oia as mensagem ai meu nobre ...");

                var client = new AmazonSQSClient(options.AccessKey, options.SecretKey, RegionEndpoint.SAEast1);
                var request = new ReceiveMessageRequest
                {
                    QueueUrl = "[SUA QUEUEURL AQuI]"
                };

                while (true)
                {
                    var response = await client.ReceiveMessageAsync(request);

                    foreach (var mensagem in response.Messages)
                    {
                        Console.WriteLine(mensagem.Body);
                        await client.DeleteMessageAsync("[SUA QUEUEURL AQuI]", mensagem.ReceiptHandle);
                    }
                }
            }
            catch (Exception ex)
            {
            
            }
        }
    }
}
