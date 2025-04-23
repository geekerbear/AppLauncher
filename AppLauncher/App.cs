using AppLauncher.Extension;

namespace AppLauncher
{
    /// <summary>
    /// 应用启动器
    /// </summary>
    public static class App
    {
        /// <summary>
        /// 创建默认App构建器
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IAppBuilder CreateDefaultBuilder(string[]? args)
        {
            AppBuilder builder = new();
            return builder.ConfigureDefaults(args);
        }
    }
}
