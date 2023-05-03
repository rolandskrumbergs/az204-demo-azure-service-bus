using System;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ServiceBusDemo.Isolated
{
    public class MessageReceiver
    {
        private readonly ILogger _logger;

        public MessageReceiver(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<MessageReceiver>();
        }

        [Function("Function1")]
        public void Run([ServiceBusTrigger("demo", Connection = "ServiceBusConnection")] string myQueueItem, FunctionContext functionContext)
        {
            _logger.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
