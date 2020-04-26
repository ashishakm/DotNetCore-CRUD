using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.AzureAppServices;

namespace DotNetCoreSqlDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddAzureWebAppDiagnostics();
                });
        //    .ConfigureLogging(logging => logging.AddAzureWebAppDiagnostics())
        //.ConfigureServices(serviceCollection => serviceCollection
        // .Configure<AzureFileLoggerOptions>(options =>
        //    {
        //        options.FileName = "azure-diagnostics-";
        //        options.FileSizeLimit = 50 * 1024;
        //        options.RetainedFileCountLimit = 5;
        //    }).Configure<AzureBlobLoggerOptions>(options =>
        //    {
        //        options.BlobName = "log.txt";
        //    })
        //)
    }
}
