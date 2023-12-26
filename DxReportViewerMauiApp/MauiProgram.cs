using DevExpress.Blazor.Reporting.Services;
using DxReportViewerMauiApp.Data;
using Microsoft.Extensions.Logging;

namespace DxReportViewerMauiApp {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
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

            return builder.Build();
        }
    }
}
