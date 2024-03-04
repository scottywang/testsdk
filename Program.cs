using Azure;
using Azure.AI.OpenAI;

OpenAIClient client = new OpenAIClient(new Uri("https://testaoai202340304pm.openai.azure.com/"), new AzureKeyCredential("09bedb56720f4a62855c8524ca92d018"));

// Build completion options object
ChatCompletionsOptions chatCompletionsOptions = new ChatCompletionsOptions()
{
    Messages =
    {
        new ChatMessage(ChatRole.System, "You are a helpful assistant."),
        new ChatMessage(ChatRole.User, "第一名城市有多少人口"),
    },
    MaxTokens = 120,
    Temperature = 0.7f,
    DeploymentName = "gpt3516k"
};
// Send request to Azure OpenAI model
ChatCompletions response = client.GetChatCompletions(chatCompletionsOptions);
string completion = response.Choices[0].Message.Content;
Console.WriteLine($"Answer: {completion}");
