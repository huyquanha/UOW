using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using UOW.Areas.Identity.Data;
using UOW.Models;

[assembly: HostingStartup(typeof(UOW.Areas.Identity.IdentityHostingStartup))]
namespace UOW.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<Student>().AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<UOWContext>();
            });
        }
    }
}