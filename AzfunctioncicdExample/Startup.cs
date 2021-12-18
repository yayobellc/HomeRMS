using AzfunctioncicdExample;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: WebJobsStartup(typeof(Startup))]
namespace AzfunctioncicdExample
{

    class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            //var executionContextOption = builder.Services.BuildServiceProvider().GetService<IOptions<ExecutionContextOptions>>().Value;
            //var appDirectory = executionContextOption.AppDirectory;
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(appDirectory)
            //    .AddJsonFile("appsettings.json")
            //    .AddEnvironmentVariables()
            //    .Build();
            //var connection = config.GetConnectionString("DatabaseConnection");
        }


    }
}
