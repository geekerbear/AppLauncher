namespace AppLauncher
{
    /// <summary>
    /// App接口
    /// </summary>
    public interface IApp : IDisposable
    {
        IServiceProvider Services { get; }

        /// <summary>
        /// 启动App
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task StartAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 停止APP
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task StopAsync(CancellationToken cancellationToken = default);
    }
}
