using FortunaPickWPF.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace FortunaPickWPF
{
    public partial class App : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            await host.StartAsync().ConfigureAwait(true);
            App app = new();
            app.InitializeComponent();
            app.MainWindow = host.Services.GetRequiredService<MainWindow>();
            app.MainWindow.Visibility = Visibility.Visible;
            app.Run();
            await host.StopAsync().ConfigureAwait(true);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostBuilderContext, configurationBuilder)
                => configurationBuilder.AddUserSecrets(typeof(App).Assembly))
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<AboutViewModel>();
                services.AddSingleton<BallstatsViewModel>();
                services.AddSingleton<DrawhistoryViewModel>();
                services.AddSingleton<EuromillionsViewModel>();
                services.AddSingleton<LottoViewModel>();
                services.AddSingleton<SetforlifeViewModel>();
                services.AddSingleton<ThunderballViewModel>();
            });
    }

}