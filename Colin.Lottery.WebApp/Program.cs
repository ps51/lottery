﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Colin.Lottery.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseUrls("http://*:5000;https://*:5001")
                .UseStartup<Startup>();
    }
}
