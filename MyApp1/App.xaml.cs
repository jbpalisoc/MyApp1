using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp1.Model;
using MyApp1.Page;
using MyApp1.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        #region Private members
        private readonly IServiceProvider serviceProvider;
        #endregion
        #region Constructor
        public App()
        {

            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<VehicleContext>(options =>
            {
                options.UseSqlite("Data Source = fleet_management.db");
            });
            services.AddSingleton<MainWindow>();
            services.AddSingleton<VehicleViewModel>();
            services.AddTransient<Page.Vehicle>();
            serviceProvider = services.BuildServiceProvider();
        }   
        #endregion
        #region Event Handlers
        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();  
            mainWindow.Show();
        }

        #endregion
    }
}
