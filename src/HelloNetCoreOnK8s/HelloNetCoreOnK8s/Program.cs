using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HelloNetCoreOnK8s
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InstanceId = Guid.NewGuid().ToString();
            CreateWebHostBuilder(args).Build().Run();
        }
        
        public static string InstanceId { get; set; }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}