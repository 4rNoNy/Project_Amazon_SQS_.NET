using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.Runtime.CredentialManagement;



namespace SQS.Envia
{
  
    class Program
    {

        static void Main()
        {
            try
            {
                var options = new CredentialProfileOptions
                {
                    AccessKey = "[sua AccessKey aqui]",
                    SecretKey = "[sua SecretKey aqui]"
                };

                var client = new AmazonSQSClient(options.AccessKey, options.SecretKey, RegionEndpoint.SAEast1);
                var request = new SendMessageRequest
                {
                    QueueUrl = "[SUA QUEUEURL AQuI]",
                    MessageBody = "Sua mensagem aqui",
                    MessageGroupId = new Random(1000).ToString(),
                    MessageDeduplicationId = new Random(1000).ToString()
                };

                 client.SendMessageAsync(request).Wait();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
