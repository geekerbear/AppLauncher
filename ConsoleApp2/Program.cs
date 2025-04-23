using AppLauncher;
using AppLauncher.Extension;

internal class Program
{
    private static void Main(string[] args)
    {
        IAppBuilder builder = App.CreateDefaultBuilder(args)
            .WithAppType(AppType.Console)
            .UseConsoleApp();

        IApp app = builder.Build()
            .UseSingletonStartup(() => 
            {
                //多个实例时拦截后操作
            });
        
        app.StartAsync();
    }
}