using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicatio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //builder.Services.AddDbContext<InMemoryDBContext>(options =>
        //    options.UseInMemoryDatabase("Shop"));
        //builder.Services.AddControllers()
        //.ConfigureApiBehaviorOptions(options =>
        //{
        //            // options.SuppressModelStateInvalidFilter = true;
        //        }
        //);
    }
}
