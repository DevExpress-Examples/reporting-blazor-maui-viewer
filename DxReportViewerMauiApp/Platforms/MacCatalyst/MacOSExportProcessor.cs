using DevExpress.Blazor.Reporting.Models;
using DevExpress.Blazor.Reporting.Services;
using DxReportViewerMauiApp.Platforms.MacCatalyst;
using Microsoft.Maui.Storage;
using QuickLook;
using System.IO;
using UIKit;

namespace DxReportViewerMauiApp {

    public class MacOSExportProcessor : IExportProcessor {
        public Task ProcessExportResult(ExportResultItem exportResultItem, bool isPrintable) {
            SaveAndView(exportResultItem);
            return Task.CompletedTask;
        }

        public void SaveAndView(ExportResultItem exportResultItem) {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, exportResultItem.FileName);
            try {
                FileStream fileStream = File.Open(filePath, FileMode.Create);
                fileStream.Write(exportResultItem.Bytes);
                fileStream.Flush();
                fileStream.Dispose();
            } catch {
            }

            UIViewController currentController = UIApplication.SharedApplication!.KeyWindow!.RootViewController;

            while(currentController!.PresentedViewController != null)
                currentController = currentController.PresentedViewController;

            QLPreviewController qlPreview = new();
            QLPreviewItem item = new ReportPreviewItem(exportResultItem.FileName, filePath);
            qlPreview.DataSource = new ReportPreviewControllerDataSource(item);
            currentController.PresentViewController((UIViewController)qlPreview, true, null);
        }
    }
}
