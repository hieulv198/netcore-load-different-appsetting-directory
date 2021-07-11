using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using load_different_appsetting_directory.Common;
using Microsoft.Extensions.Configuration;

namespace load_different_appsetting_directory.Configuration
{
    public class SetConfigurationBuilder
    {
        public static void SetConfigBuilder(IConfigurationBuilder builder)
        {
            var basePath = Util.GetBasePath();
            
            builder.SetBasePath(basePath);
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                    optional: true).AddEnvironmentVariables();
        }
    }
}
