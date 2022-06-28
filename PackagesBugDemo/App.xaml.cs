using Microsoft.AspNetCore.Builder;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PackagesBugDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private WebApplication? app;
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var logger = LogManager.Setup();

            var builder = WebApplication.CreateBuilder();

            app = builder.Build();

            await app.RunAsync();
        }
    }
}
