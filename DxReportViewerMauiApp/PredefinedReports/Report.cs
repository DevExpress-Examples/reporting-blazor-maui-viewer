using DevExpress.XtraReports.UI;
    public class Report : XtraReport {
        private TopMarginBand topMarginBand1;
        private XRPageInfo xrPageInfo4;
        private XRPageInfo xrPageInfo3;
        private BottomMarginBand bottomMarginBand1;
        private DetailBand detailBand1;
        private XRLabel xrLabel1;
        private XRBarCode xrBarCode1;
        private XRLabel xrLabel4;
        private XRLabel xrLabel5;
        private XRLabel xrLabel6;
        private XRLabel xrLabel7;
        private XRLabel xrLabel8;
        private XRLabel xrLabel9;
        private XRLabel xrLabel10;
        private XRLabel xrLabel11;
        private XRLabel xrLabel12;
        private XRLabel xrLabel13;
        private SubBand SubBand1;
        private XRTable xrTable5;
        private XRTableRow xrTableRow9;
        private XRTableCell xrTableCell18;
        private XRTableCell xrTableCell20;
        private XRTableRow xrTableRow11;
        private XRTableCell xrTableCell24;
        private XRTableCell xrTableCell25;
        private XRTableRow xrTableRow12;
        private XRTableCell xrTableCell26;
        private XRTableCell xrTableCell27;
        private XRTableRow xrTableRow10;
        private XRTableCell xrTableCell21;
        private XRTableCell xrTableCell23;
        private XRTableRow xrTableRow13;
        private XRTableCell xrTableCell28;
        private XRTableCell xrTableCell29;
        private XRLabel xrLabel2;
        private DetailReportBand detailReportBand1;
        private GroupHeaderBand groupHeaderBand1;
        private XRTable xrTable2;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell11;
        private DetailBand detailBand2;
        private XRTable xrTable3;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell13;
        private XRTableCell xrTableCell15;
        private XRTableCell xrTableCell16;
        private ReportHeaderBand ReportHeader;
        private XRLabel xrLabel3;
        private ReportFooterBand ReportFooter;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell4;
        private XRTableCell xrTableCell5;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private XRControlStyle Title;
        private XRControlStyle ReportTitleCaption;
        private XRControlStyle DetailData3;
        private XRControlStyle DetailData3_Odd;
        private XRControlStyle PageInfo;
        private XRControlStyle Headers;
        private XRControlStyle SummaryTitles;
        private XRControlStyle SummaryValues;
        protected DevExpress.XtraReports.Parameters.Parameter RowCountParameter;
        private System.ComponentModel.IContainer components;

        public Report() : this(5u) { }

        public Report(uint countParameter) {
            InitializeComponent();
            RowCountParameter.Value = countParameter;
            Name = "LargeDatasetReport";
            DisplayName = "Large Dataset";
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new();
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new();
            DevExpress.DataAccess.ObjectBinding.Parameter parameter1 = new();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.detailReportBand1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.xrPageInfo4 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.detailBand2 = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportTitleCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Headers = new DevExpress.XtraReports.UI.XRControlStyle();
            this.SummaryTitles = new DevExpress.XtraReports.UI.XRControlStyle();
            this.SummaryValues = new DevExpress.XtraReports.UI.XRControlStyle();
            this.RowCountParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo4,
            this.xrPageInfo3});
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrBarCode1,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13});
            this.detailBand1.HeightF = 197.9167F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            // 
            // detailReportBand1
            // 
            this.detailReportBand1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.groupHeaderBand1,
            this.detailBand2,
            this.ReportHeader,
            this.ReportFooter});
            this.detailReportBand1.DataMember = "Adjustments";
            this.detailReportBand1.DataSource = this.objectDataSource1;
            this.detailReportBand1.Level = 0;
            this.detailReportBand1.Name = "detailReportBand1";
            this.detailReportBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // xrPageInfo4
            // 
            this.xrPageInfo4.LocationFloat = new DevExpress.Utils.PointFloat(461.75F, 38.73147F);
            this.xrPageInfo4.Name = "xrPageInfo4";
            this.xrPageInfo4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo4.SizeF = new System.Drawing.SizeF(178.875F, 23F);
            this.xrPageInfo4.StyleName = "PageInfo";
            this.xrPageInfo4.StylePriority.UseForeColor = false;
            this.xrPageInfo4.StylePriority.UsePadding = false;
            this.xrPageInfo4.StylePriority.UseTextAlignment = false;
            this.xrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrPageInfo4.TextFormatString = "Issued: {0}";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.73146F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(300.2737F, 23F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseForeColor = false;
            this.xrPageInfo3.StylePriority.UsePadding = false;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrPageInfo3.TextFormatString = "Page {0} of {1} Pages";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(650F, 50F);
            this.xrLabel1.StyleName = "ReportTitleCaption";
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.Text = "Paris spécialités";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address] + NewLine() + [City] + \' , \' + [PostalCode] + NewLine() + [Phone]")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(514.9792F, 50.18913F);
            this.xrBarCode1.Module = 4.7F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(135.021F, 124.9819F);
            this.xrBarCode1.StylePriority.UsePadding = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            this.xrBarCode1.Symbology = qrCodeGenerator1;
            this.xrBarCode1.Text = "12, rue des Bouchers\r\nMarseille , 13008\r\n91.24.45.40";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.41667F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(140F, 25F);
            this.xrLabel4.StyleName = "Headers";
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "CUSTOMER ACCOUNT:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerAccount]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(163.3871F, 60.41667F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(127.8075F, 25F);
            this.xrLabel5.StyleName = "DetailData3";
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Energy";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel6.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 89.58334F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(140F, 25F);
            this.xrLabel6.StyleName = "Headers";
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "CUSTOMER IDENTIFIERS:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel7.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerIdentifiers]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(163.3871F, 89.58334F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(127.8075F, 25F);
            this.xrLabel7.StyleName = "DetailData3";
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "1273-86";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel8.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.BorderWidth = 1F;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 118.75F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(140F, 25F);
            this.xrLabel8.StyleName = "Headers";
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "EMAIL:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.AutoWidth = true;
            this.xrLabel9.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel9.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(163.3871F, 118.75F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(127.8075F, 24.99997F);
            this.xrLabel9.StyleName = "DetailData3";
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "laurence@bon.com";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel9.WordWrap = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel10.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")});
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(370.034F, 60.41667F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(144.7905F, 25F);
            this.xrLabel10.StyleName = "DetailData3";
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "12, rue des Bouchers";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel10.WordWrap = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel11.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[City] + \', \' + [Region] + \' \' + [PostalCode]")});
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(370.034F, 89.58334F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(144.7907F, 25F);
            this.xrLabel11.StyleName = "DetailData3";
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Marseille,  13008";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")});
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(370.0327F, 118.75F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(144.792F, 25.00002F);
            this.xrLabel12.StyleName = "DetailData3";
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "France";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel13.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(370.034F, 147.9167F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(144.792F, 25F);
            this.xrLabel13.StyleName = "DetailData3";
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "91.24.45.40";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5,
            this.xrLabel2});
            this.SubBand1.HeightF = 226.7708F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrTable5
            // 
            this.xrTable5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTable5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 48.95833F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9,
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow10,
            this.xrTableRow13});
            this.xrTable5.SizeF = new System.Drawing.SizeF(640.625F, 145.8333F);
            this.xrTable5.StylePriority.UseBorderColor = false;
            this.xrTable5.StylePriority.UseBorders = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.083345F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(640.625F, 35F);
            this.xrLabel2.StyleName = "Title";
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Monthly Billing Invoice Statement";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell18,
            this.xrTableCell20});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 10.208333833436589D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell24,
            this.xrTableCell25});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 10.208333401633816D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell26,
            this.xrTableCell27});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 10.208334312922753D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21,
            this.xrTableCell23});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 10.208334312922753D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrTableCell29});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 10.208332922147651D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            this.xrTableCell18.StyleName = "DetailData3_Odd";
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.StylePriority.UseForeColor = false;
            this.xrTableCell18.StylePriority.UsePadding = false;
            this.xrTableCell18.Text = "CONTACT NAME";
            this.xrTableCell18.Weight = 0.13177048207687855D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            this.xrTableCell20.StyleName = "DetailData3_Odd";
            this.xrTableCell20.StylePriority.UsePadding = false;
            this.xrTableCell20.Text = "Laurence Lebihan";
            this.xrTableCell20.Weight = 0.31267396236756584D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            this.xrTableCell24.StyleName = "Headers";
            this.xrTableCell24.StylePriority.UseBackColor = false;
            this.xrTableCell24.StylePriority.UseBorderColor = false;
            this.xrTableCell24.StylePriority.UseBorders = false;
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.StylePriority.UseForeColor = false;
            this.xrTableCell24.StylePriority.UsePadding = false;
            this.xrTableCell24.Text = "CONTACT TITLE";
            this.xrTableCell24.Weight = 0.13177048207687855D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactTitle]")});
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            this.xrTableCell25.StyleName = "DetailData3";
            this.xrTableCell25.StylePriority.UseBorderColor = false;
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.StylePriority.UsePadding = false;
            this.xrTableCell25.Text = "Owner";
            this.xrTableCell25.Weight = 0.31267396236756584D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            this.xrTableCell26.StyleName = "DetailData3_Odd";
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.StylePriority.UseForeColor = false;
            this.xrTableCell26.StylePriority.UsePadding = false;
            this.xrTableCell26.Text = "BILLING STATEMENT DATE";
            this.xrTableCell26.Weight = 0.13177048207687855D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillingDate]")});
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            this.xrTableCell27.StyleName = "DetailData3_Odd";
            this.xrTableCell27.StylePriority.UsePadding = false;
            this.xrTableCell27.Text = "9/5/2018";
            this.xrTableCell27.TextFormatString = "{0:M/d/yyyy}";
            this.xrTableCell27.Weight = 0.31267396236756584D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            this.xrTableCell21.StyleName = "Headers";
            this.xrTableCell21.StylePriority.UseBackColor = false;
            this.xrTableCell21.StylePriority.UseBorderColor = false;
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseForeColor = false;
            this.xrTableCell21.StylePriority.UsePadding = false;
            this.xrTableCell21.Text = "BILLING PERIOD";
            this.xrTableCell21.Weight = 0.13177048207687855D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:M/d/yyyy}\',[BillingPeriodStart] ) + \' To \' + FormatString(\'{0:M/" +
                    "d/yyyy}\',[BillingPeriodEnd])")});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            this.xrTableCell23.StyleName = "DetailData3";
            this.xrTableCell23.StylePriority.UseBorderColor = false;
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.StylePriority.UsePadding = false;
            this.xrTableCell23.Text = "8/4/2018 To 8/17/2018";
            this.xrTableCell23.Weight = 0.31267396236756584D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell28.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            this.xrTableCell28.StyleName = "DetailData3_Odd";
            this.xrTableCell28.StylePriority.UseBorderColor = false;
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.StylePriority.UseForeColor = false;
            this.xrTableCell28.StylePriority.UsePadding = false;
            this.xrTableCell28.Text = "TERMS";
            this.xrTableCell28.Weight = 0.13177048207687855D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Terms]")});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            this.xrTableCell29.StyleName = "DetailData3_Odd";
            this.xrTableCell29.StylePriority.UseBorderColor = false;
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.StylePriority.UsePadding = false;
            this.xrTableCell29.Text = "End of month";
            this.xrTableCell29.Weight = 0.31267396236756584D;
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand1.HeightF = 29.16667F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // detailBand2
            // 
            this.detailBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.detailBand2.EvenStyleName = "DetailData3";
            this.detailBand2.HeightF = 29.16667F;
            this.detailBand2.Name = "detailBand2";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
            this.ReportHeader.HeightF = 46.875F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.ReportFooter.HeightF = 98.95834F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PrintAtBottom = true;
            // 
            // xrTable2
            // 
            this.xrTable2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.BorderWidth = 1.2F;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(4.238557E-05F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable2.SizeF = new System.Drawing.SizeF(640.625F, 29.16667F);
            this.xrTable2.StyleName = "Headers";
            this.xrTable2.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell11});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.StyleName = "Headers";
            this.xrTableRow3.Weight = 1.0416666991890433D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell7.BorderWidth = 2F;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.xrTableCell7.StyleName = "Headers";
            this.xrTableCell7.StylePriority.UseBorderColor = false;
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseBorderWidth = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.Text = "DATE";
            this.xrTableCell7.Weight = 0.26282052324906857D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell8.BorderWidth = 2F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell8.StyleName = "Headers";
            this.xrTableCell8.StylePriority.UseBorderColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.Text = "DESCRIPTION";
            this.xrTableCell8.Weight = 0.2264102459817007D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell9.BorderWidth = 2F;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell9.StyleName = "Headers";
            this.xrTableCell9.StylePriority.UseBorderColor = false;
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseBorderWidth = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "AMOUNT";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell9.Weight = 0.24679486710782655D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.xrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell11.BorderWidth = 2F;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.xrTableCell11.StyleName = "Headers";
            this.xrTableCell11.StylePriority.UseBorderColor = false;
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseBorderWidth = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "BALANCE";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell11.Weight = 0.26397427885888153D;
            // 
            // xrTable3
            // 
            this.xrTable3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTable3.BorderWidth = 0.8F;
            this.xrTable3.EvenStyleName = "DetailData3_Odd";
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(5.298196E-05F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.OddStyleName = "DetailData3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable3.SizeF = new System.Drawing.SizeF(640.6249F, 29.16667F);
            this.xrTable3.StylePriority.UseBorderColor = false;
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell15,
            this.xrTableCell16});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 13.416666666666666D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Date]")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.xrTableCell12.StyleName = "DetailData3";
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.Text = "9/9/2018";
            this.xrTableCell12.TextFormatString = "{0:M/d/yyyy}";
            this.xrTableCell12.Weight = 0.22071864610205358D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell13.StyleName = "DetailData3";
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.Text = "Bill - Rent";
            this.xrTableCell13.Weight = 0.19014097853086204D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(Contains([Description], \'Balance\'), \'\', [Amount])")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.xrTableCell15.StyleName = "DetailData3";
            this.xrTableCell15.StylePriority.UsePadding = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "$210.00";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell15.TextFormatString = "{0:$#,##.00}";
            this.xrTableCell15.Weight = 0.20726019714891972D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRunningSum([Amount])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Name", "\'Segoe UI\'"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Size", "8"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "[DataSource.CurrentRowIndex] == [DataSource.RowCount] -1")});
            this.xrTableCell16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 10, 0, 0, 100F);
            this.xrTableCell16.StyleName = "DetailData3";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UsePadding = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell16.Summary = xrSummary1;
            this.xrTableCell16.Text = "xrTableCell16";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell16.TextFormatString = "{0:$#,##.00}";
            this.xrTableCell16.Weight = 0.22168754127396906D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.083306F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(640.625F, 27.94597F);
            this.xrLabel3.StyleName = "Title";
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Payments and Adjustments";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 98.95834F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.KeepTogether = false;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.299592056274414D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow2.KeepTogether = false;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.70040771484374986D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell3.BorderWidth = 2F;
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell3.StyleName = "SummaryTitles";
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseBorderWidth = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "NEW CHARGES\r\n";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell3.Weight = 0.99038461538461531D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell1.BorderWidth = 2F;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.StyleName = "SummaryTitles";
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseBorderWidth = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "PAYMENTS";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.StyleName = "SummaryTitles";
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseBorderWidth = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "CURRENT BALANCE";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell2.Weight = 1.0096153846153846D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.xrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell6.BorderWidth = 2F;
            this.xrTableCell6.CanGrow = false;
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[][[Amount] > 0 And !Contains([Description], \'Balance\')].Sum([Amount])")});
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 23F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F);
            this.xrTableCell6.StyleName = "SummaryValues";
            this.xrTableCell6.StylePriority.UseBorderColor = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseBorderWidth = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.Text = "+$210.00";
            this.xrTableCell6.TextFormatString = "+{0:$#,##.00}";
            this.xrTableCell6.Weight = 0.99038461538461531D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell4.BorderWidth = 2F;
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[][[Amount] < 0].Sum([Amount])")});
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 23F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F);
            this.xrTableCell4.StyleName = "SummaryValues";
            this.xrTableCell4.StylePriority.UseBorderColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseBorderWidth = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.Text = "-$280.00";
            this.xrTableCell4.TextFormatString = "{0:$#,##.00}";
            this.xrTableCell4.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([Amount])")});
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 23F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F);
            this.xrTableCell5.StyleName = "SummaryValues";
            this.xrTableCell5.StylePriority.UseBorderColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseBorderWidth = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.Text = "$1,480.00";
            this.xrTableCell5.TextFormatString = "{0:$#,##.00}";
            this.xrTableCell5.Weight = 1.0096153846153846D;
            // 
            // objectDataSource1
            // 
            parameter1.Name = "rowCount";
            parameter1.Type = typeof(DevExpress.DataAccess.Expression);
            parameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.RowCountParameter]", typeof(int));
            objectConstructorInfo1.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter1});
            this.objectDataSource1.Constructor = objectConstructorInfo1;
            this.objectDataSource1.DataSource = typeof(DxReportViewerMauiApp.Data.DataItemList);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Segoe UI", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.Title.Name = "Title";
            // 
            // ReportTitleCaption
            // 
            this.ReportTitleCaption.BackColor = System.Drawing.Color.Transparent;
            this.ReportTitleCaption.BorderColor = System.Drawing.Color.Transparent;
            this.ReportTitleCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ReportTitleCaption.Font = new DevExpress.Drawing.DXFont("Segoe UI", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ReportTitleCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.ReportTitleCaption.Name = "ReportTitleCaption";
            this.ReportTitleCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.ReportTitleCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F);
            this.DetailData3.ForeColor = System.Drawing.Color.Black;
            this.DetailData3.Name = "DetailData3";
            this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // Headers
            // 
            this.Headers.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Headers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.Headers.Name = "Headers";
            this.Headers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // SummaryTitles
            // 
            this.SummaryTitles.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SummaryTitles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(185)))), ((int)(((byte)(214)))));
            this.SummaryTitles.Name = "SummaryTitles";
            this.SummaryTitles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SummaryValues
            // 
            this.SummaryValues.Font = new DevExpress.Drawing.DXFont("Segoe UI", 23F);
            this.SummaryValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.SummaryValues.Name = "SummaryValues";
            this.SummaryValues.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 16, 0, 100F);
            this.SummaryValues.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // RowCountParameter
            // 
            this.RowCountParameter.Description = "Row Count";
            this.RowCountParameter.Name = "RowCountParameter";
            this.RowCountParameter.Type = typeof(int);
            this.RowCountParameter.ValueInfo = "100000";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.detailReportBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.RowCountParameter});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.ReportTitleCaption,
            this.DetailData3,
            this.DetailData3_Odd,
            this.PageInfo,
            this.Headers,
            this.SummaryTitles,
            this.SummaryValues});
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }

