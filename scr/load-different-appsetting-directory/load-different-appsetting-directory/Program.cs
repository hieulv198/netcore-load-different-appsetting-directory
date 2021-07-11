using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using load_different_appsetting_directory.Configuration;

namespace load_different_appsetting_directory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost iHost = CreateHostBuilder(args).Build();

            // Use configuration here to config another service using appsetting.
            // Exam
            // object configuration = iHost.Services.GetService(typeof(IConfiguration));
            // NlogConfiguration.GetConfigurationFromJson(configuration);
            
            iHost.Run();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(SetConfigurationBuilder.SetConfigBuilder)
                .ConfigureAppConfiguration(SetConfigurationBuilder.SetConfigBuilder)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
