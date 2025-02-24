using Azure;
using Azure.AI.Inference;
using Microsoft.Extensions.AI;
using System.ClientModel;
using Azure.AI.OpenAI;

var deploymentName = "gpt-35-turbo-16k";
var endpoint = new Uri("https://oai-query-dev.openai.azure.com/");
//var apiKey = new ApiKeyCredential(Environment.GetEnvironmentVariable("AZURE_AI_SECRET") ?? throw new InvalidOperationException("Missing AZURE_AI_SECRET environment variable. Ensure you followed the instructions to setup an OpenAI API Key."));
var apiKey = new ApiKeyCredential("");
IChatClient client = new AzureOpenAIClient(
    endpoint,
    apiKey)
.AsChatClient(deploymentName);

var response = await client.GetResponseAsync("What is AI?");

Console.WriteLine(response.Message);