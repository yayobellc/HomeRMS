using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace AzfunctioncicdExample
{
    public static class azfunctionExample
    {
        [FunctionName("azfunctionExample")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ExecutionContext context,
            ILogger log)
        {
            var config = new ConfigurationBuilder()
             .SetBasePath(context.FunctionAppDirectory)
             // This gives you access to your application settings
             // in your local development environment:
             .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
             // This is what actually gets you the application settings in Azure
             .AddEnvironmentVariables()
             .Build();

            string appsettingvalue = config["ConnectionStrings:DefaultConnection"];


            return new OkObjectResult($"Hello{appsettingvalue}");
        }
    }
}
