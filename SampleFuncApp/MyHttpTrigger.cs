using System;
using System.IO;
using System.Threading.Tasks;
using Hasura.EventTriggers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SampleFuncApp.Models;

namespace SampleFuncApp;

public static class MyHttpTrigger
{
    [FunctionName("MyHttpTrigger")]
    public static async Task<IActionResult> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] EventTriggerPayload<TodoModel> req, ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");


        return new ObjectResult(req);

    }
}