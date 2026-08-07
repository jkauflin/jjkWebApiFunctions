using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace jjkWebApiFunctions;

public class HttpTriggerTest1
{
    private readonly ILogger<HttpTriggerTest1> _logger;

    public HttpTriggerTest1(ILogger<HttpTriggerTest1> logger)
    {
        _logger = logger;
    }

    [Function("HttpTriggerTest1")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        // test comment #4
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}