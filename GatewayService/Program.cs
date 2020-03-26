using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GatewayService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
                Microsoft.AspNetCore.WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>()
                 .UseUrls(urls: "http://localhost:10001")
                 .Build();
    }
}
