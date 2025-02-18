﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mylibraries.Data;
using mylibraries.Areas.Identity.Data;


[assembly: HostingStartup(typeof(mylibraries.Areas.Identity.IdentityHostingStartup))]
namespace mylibraries.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<mylibrariesDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("mylibrariesDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<mylibrariesDbContext>();
                });
        }
    }
}