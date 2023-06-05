using QuickLook;
using Foundation;

namespace DxReportViewerMauiApp.Platforms.MacCatalyst
{
    public class ReportPreviewItem : QLPreviewItem
    {
        private readonly string reportName;
        private readonly string path;
        public ReportPreviewItem(string reportName, string path)
        {
            this.reportName = reportName;
            this.path = path;
        }

        public override string PreviewItemTitle => reportName;

        public override NSUrl PreviewItemUrl
        {
            get
            {
                var fileName = Path.Combine(NSBundle.MainBundle.BundlePath, path);
                return NSUrl.FromFilename(fileName);
            }
        }
    }

    public class ReportPreviewControllerDataSource : QLPreviewControllerDataSource
    {
        private QLPreviewItem reportPreviewItem;

        public ReportPreviewControllerDataSource(QLPreviewItem reportPreviewItem)
        {
            this.reportPreviewItem = reportPreviewItem;
        }

        public override nint PreviewItemCount(QLPreviewController controller) => 1;

        public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index) => reportPreviewItem;
    }
}
