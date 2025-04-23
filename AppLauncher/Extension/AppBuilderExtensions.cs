using AppLauncher.Helper;

namespace AppLauncher.Extension
{
    public static class AppBuilderExtensions
    {
        /// <summary>
        /// 默认配置
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IAppBuilder ConfigureDefaults(this IAppBuilder builder, string[]? args)
        {
            return builder;

            //return builder.ConfigureHostConfiguration(config => ApplyDefaultHostConfiguration(config, args))
            //              .ConfigureAppConfiguration((hostingContext, config) => ApplyDefaultAppConfiguration(hostingContext, config, args))
            //              .ConfigureServices(AddDefaultServices)
            //              .UseServiceProviderFactory(context => new DefaultServiceProviderFactory(CreateDefaultServiceProviderOptions(context)));
        }

        /// <summary>
        /// 设置App类型
        /// </summary>
        /// <param name="appBuilder"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IAppBuilder WithAppType(this IAppBuilder appBuilder, AppType type)
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
