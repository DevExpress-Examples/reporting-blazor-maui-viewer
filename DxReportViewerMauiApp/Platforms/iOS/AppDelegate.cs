using Foundation;
using DevExpress.Blazor.Reporting.Services;
using DevExpress.Blazor.Reporting.Internal.Services;

namespace DxReportViewerMauiApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() {
        var builder = MauiProgram.CreateMauiApp();
        builder.Services.AddScoped<IExportProcessor, JSExportProcessor>();
        return builder.Build();
    }
}
