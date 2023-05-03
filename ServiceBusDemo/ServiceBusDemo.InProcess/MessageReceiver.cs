using System;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusDemo.InProcess
{
    // After updating to latest Microsoft.Azure.WebJobs.Extensions.ServiceBus version
    // you can bind to ServiceBusReceivedMessage
    public class MessageReceiver
    {
        [FunctionName("MessageReceiver")]
        public void Run([ServiceBusTrigger("demo", Connection = "ServiceBusConnection")] ServiceBusReceivedMessage myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
