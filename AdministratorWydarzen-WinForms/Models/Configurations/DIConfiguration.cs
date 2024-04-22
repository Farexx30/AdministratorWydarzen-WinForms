using AdministratorWydarzen_WinForms.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Models.Configurations
{
    static internal class DIConfiguration 
    {
        public static IServiceProvider? ServiceProvider { get; set; }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
               .ConfigureServices((context, services) =>
               {
                   services.RegisterServices();
               });

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IEventView, EventView>();
            services.AddTransient<IEventModel, EventModel>();
            services.AddTransient<IEventPresenter, EventPresenter>();

            return services;
        }
    }
}
