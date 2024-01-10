using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace generic_host_wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;
        public App()
        {
            _host = new HostBuilder()
                .ConfigureServices((context, services) =>
                {
                    //add default logging
                    services.AddLogging();
                    services.AddSingleton<MainWindow>();
                })
                .Build();

            
        }
    }

}
