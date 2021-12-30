using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NickWebApi.Data;
using System.Threading.Tasks;

namespace NickWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var host = CreateHostBuilder(args).Build();

            //using (var serviceScope = host.Services.CreateScope())
            //{
            //    var dbContext = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
            //    await dbContext.Database.MigrateAsync();
            //}

            //await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
