public App()
{
    Program.Configure();
}

protected override async void OnStartup(StartupEventArgs e)
{
    await Program.AppHost.StartAsync();

    var mainWindow =
        Program.AppHost.Services.GetRequiredService<MainWindow>();

    mainWindow.Show();

    base.OnStartup(e);
}
