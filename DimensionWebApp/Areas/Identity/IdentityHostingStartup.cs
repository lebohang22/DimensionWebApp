using System;
using DimensionWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DimensionWebApp.Areas.Identity.IdentityHostingStartup))]
namespace DimensionWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DimensionWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DimensionWebAppContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    //.AddEntityFrameworkStores<DimensionWebAppContext>();//
            });
        }
    }
}