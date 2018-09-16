using System;
using ASPCoreNPMSeed.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ASPCoreNPMSeed.Areas.Identity.IdentityHostingStartup))]
namespace ASPCoreNPMSeed.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ASPCoreNPMSeedContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ASPCoreNPMSeedContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<ASPCoreNPMSeedContext>();
            });
        }
    }
}