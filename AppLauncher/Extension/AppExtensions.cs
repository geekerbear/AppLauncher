using AppLauncher.Helper;

namespace AppLauncher.Extension
{
    public static class AppExtensions
    {
        /// <summary>
        /// 使用单实例启动App
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApp UseSingletonStartup(this IApp app, Action? block = null)
        {
            ThrowHelper.ThrowIfNull(app);

            //if (SystemdHelpers.IsSystemdService())
            //{
            //    hostBuilder.ConfigureServices((hostContext, services) =>
            //    {
            //        AddSystemdLifetime(services);
            //    });
            //}
            return app;
        }
    }
}
