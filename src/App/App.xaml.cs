namespace Pokemon
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost AppHost;

        public App()
        {
            this.AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<IHttpClientWrapper, HttpClientWrapper>();
                    services.AddSingleton<ISubtypeRequester, SubtypeRequester>();
                    services.AddSingleton<ICardRequester, CardRequester>();
                }).Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await this.AppHost.StartAsync();
            var startUp = this.AppHost.Services.GetRequiredService<MainWindow>();
            startUp.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await this.AppHost.StopAsync();

            base.OnExit(e);
        }
    }
}
