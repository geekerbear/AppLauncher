using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "测试程序";
        Console.Read();

        //    static IHostBuilder CreateHostBuilder(string[] args) =>
        //Host.CreateDefaultBuilder(args)
        //    .UseSystemd() // Enable running as a Systemd service
        //    .ConfigureServices((hostContext, services) =>
        //    {

        //    });
    }
}