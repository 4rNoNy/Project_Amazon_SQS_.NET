using Amazon.SQS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Amazon_SQS
{
    public class SqsPublisher
    {
        private readonly IAmazonSQS _sqs;

        public SqsPublisher (IAmazonSQS sqs)
        {
            _sqs = sqs;
        }

        public async Task PublishAsync<T>(string queueName, T message)
        {

        }
    }
}
