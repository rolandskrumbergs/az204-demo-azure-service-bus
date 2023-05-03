// See https://aka.ms/new-console-template for more information

using Azure.Messaging.ServiceBus;

string connectionString = "Endpoint=sb://az204rolandsdemo.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=ERW5jpGPdCPpdYakRMCEqrXCuwaCaTTiU+ASbMVW7DI=";
string queueName = "demo";

// since ServiceBusClient implements IAsyncDisposable we create it with "await using"
await using var client = new ServiceBusClient(connectionString);

// create the sender
ServiceBusSender sender = client.CreateSender(queueName);

// create a message that we can send. UTF-8 encoding is used when providing a string.
ServiceBusMessage message = new ServiceBusMessage("Hello world!");

// send the message
await sender.SendMessageAsync(message);