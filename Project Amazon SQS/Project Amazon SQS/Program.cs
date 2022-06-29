using Amazon.SQS;
using Project_Amazon_SQS;
using Project_Amazon_SQS.Mensagens;

var sqsClient = new AmazonSQSClient(Amazon.RegionEndpoint.SAEast1);

var publisher = new SqsPublisher(sqsClient);

await publisher.PublishAsync("customers", new CostumerCreated 
    { 
    Id = 1,
    FullName = "Arnon Nascimento"

    });
//9:45