using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PowerRun.Areas.Identity.Data;
using PowerRun.Models;

[assembly: HostingStartup(typeof(PowerRun.Areas.Identity.IdentityHostingStartup))]
namespace PowerRun.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PowerRunContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PowerRunContextConnection")));

                services.AddDefaultIdentity<PowerRunUser>()
                    .AddEntityFrameworkStores<PowerRunContext>();
            });
        }
    }
}