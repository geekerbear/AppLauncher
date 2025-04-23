using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace AppLauncher
{
    public partial class AppBuilder : IAppBuilder
    {
        private const string HostBuildingDiagnosticListenerName = "Microsoft.Extensions.Hosting";
        private const string AppBuildingEventName = "AppBuilding";
        private const string AppBuiltEventName = "AppBuilt";

        private bool _hostBuilt;

        public IDictionary<object, object> Properties { get; } = new Dictionary<object, object>();

        public IApp Build()
        {
            throw new NotImplementedException();
        }

        private static DiagnosticListener LogHostBuilding(IAppBuilder appBuilder)
        {
            var diagnosticListener = new DiagnosticListener(HostBuildingDiagnosticListenerName);

            if (diagnosticListener.IsEnabled() && diagnosticListener.IsEnabled(AppBuildingEventName))
            {
                //Write(diagnosticListener, AppBuildingEventName, appBuilder);
            }

            return diagnosticListener;
        }

        internal static DiagnosticListener LogHostBuilding(HostApplicationBuilder hostApplicationBuilder)
        {
            var diagnosticListener = new DiagnosticListener(HostBuildingDiagnosticListenerName);

            if (diagnosticListener.IsEnabled() && diagnosticListener.IsEnabled(AppBuildingEventName))
            {
                //Write(diagnosticListener, AppBuildingEventName, hostApplicationBuilder.AsHostBuilder());
            }

            return diagnosticListener;
        }
    }
}
