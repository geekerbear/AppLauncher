namespace AppLauncher.Menu
{
    /// <summary>
    /// 菜单输出
    /// </summary>
    public static class Output
    {
        /// <summary>
        /// 写一行
        /// </summary>
        /// <param name="color">颜色</param>
        /// <param name="format">格式化</param>
        /// <param name="args">格式化参数</param>
        public static void WriteLine(ConsoleColor color, string format, params object[] args)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(format, args);
            Console.ResetColor();
        }

        /// <summary>
        /// 写一行
        /// </summary>
        /// <param name="color">颜色</param>
        /// <param name="value">内容</param>
        public static void WriteLine(ConsoleColor color, string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        /// <summary>
        /// 写一行
        /// </summary>
        /// <param name="format">格式化</param>
        /// <param name="args">格式化参数</param>
        public static void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void DisplayPrompt(string format, params object[] args)
        {
            format = format.Trim() + " ";
            Console.Write(format, args);
        }
    }
}
