﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

using System.Linq;


namespace Main.Services
{
    public static class ServicesInstallerExtensions
    {
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes
     .Where(x => typeof(Services.IServicesInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
     .Select(Activator.CreateInstance).Cast<IServicesInstaller>()
       .ToList();
            installers.ForEach(installer => installer.InstallServices(services, configuration));

        }
    }
}
