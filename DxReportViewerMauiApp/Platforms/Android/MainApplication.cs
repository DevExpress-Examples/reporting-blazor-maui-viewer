using Android.App;
using Android.Runtime;
using DevExpress.Blazor.Reporting.Services;
[assembly: UsesPermission(Android.Manifest.Permission.ReadExternalStorage)]

namespace DxReportViewerMauiApp;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() {
		var builder = MauiProgram.CreateMauiApp();
		return builder.Build();
	}
}
