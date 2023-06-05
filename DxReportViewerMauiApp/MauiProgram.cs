using Microsoft.Extensions.Logging;
using DxReportViewerMauiApp.Data;
using System.Runtime.InteropServices;
using DevExpress.Blazor.Reporting.Services;

namespace DxReportViewerMauiApp;

public static class MauiProgram
{
	public static MauiAppBuilder CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

		builder.Services.AddMauiBlazorWebView();
        builder.Services.AddDevExpressBlazor();
        builder.Services.AddDevExpressWebAssemblyBlazorReportViewer();
		builder.Services.AddScoped<IExportProcessor, SharedReportExportProcessor>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

        if(!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            DevExpress.Drawing.Internal.DXDrawingEngine.ForceSkia();
        }


        return builder;
	}
}
