﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hackland.AccessControl.Shared;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Hackland.AccessControl.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (Settings.IsRunningInDocker)
            {
                CreateWebHostBuilder(args)
                .UseUrls("http://0.0.0.0:5555")
                .Build().Run();
            }
            else
            {
                CreateWebHostBuilder(args)
                .Build().Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
