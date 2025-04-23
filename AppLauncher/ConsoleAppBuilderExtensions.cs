using AppLauncher.Helper;

namespace AppLauncher
{
    public static class ConsoleAppBuilderExtensions
    {
        public static IAppBuilder UseConsoleApp(this IAppBuilder appBuilder)
        {
            ThrowHelper.ThrowIfNull(appBuilder);

            //if (SystemdHelpers.IsSystemdService())
            //{
            //    hostBuilder.ConfigureServices((hostContext, services) =>
            //    {
            //        AddSystemdLifetime(services);
            //    });
            //}
            return appBuilder;
        }
    }
}
