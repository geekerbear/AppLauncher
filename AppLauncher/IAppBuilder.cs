namespace AppLauncher
{
    /// <summary>
    /// App构建器
    /// </summary>
    public interface IAppBuilder
    {
        /// <summary>
        /// 获取APP属性
        /// </summary>
        IDictionary<object, object> Properties { get; }

        /// <summary>
        /// 构建APP
        /// </summary>
        /// <returns></returns>
        IApp Build();
    }
}
