using DevExpress.Blazor.Reporting.Models;
using DevExpress.Blazor.Reporting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxReportViewerMauiApp
{
    public class SharedReportExportProcessor : IExportProcessor
    {
        public async Task ProcessExportResult(ExportResultItem exportResultItem, bool isPrintOperation)
        {
            var fileName = Path.Combine(FileSystem.CacheDirectory, exportResultItem.FileName);
            using (var file = File.Create(fileName))
            {
                file.Write(exportResultItem.Bytes);
            }

            await Share.Default.RequestAsync(new ShareFileRequest
            {
                Title = "Share a Report",
                File = new ShareFile(fileName)
            });
        }
    }
}
