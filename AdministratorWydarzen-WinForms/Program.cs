using AdministratorWydarzen_WinForms.Models.Configurations;
using AdministratorWydarzen_WinForms.Presenters;
using Microsoft.Extensions.DependencyInjection;

namespace AdministratorWydarzen_WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = DIConfiguration.CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            DIConfiguration.ServiceProvider = builder.Services;

            IEventPresenter eventPresenter = DIConfiguration.ServiceProvider.GetRequiredService<IEventPresenter>();
     
            Application.Run((Form)eventPresenter.View);
        }
    }
}