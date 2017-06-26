namespace DXApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.New_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LoadFile_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Explain_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Fix_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Project_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Members_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ViewHelp_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Exit_barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.chart = new DevExpress.XtraBars.BarCheckItem();
            this.File_ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.New_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LoadFile_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Explain_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Exit_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.About_ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Project_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Members_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Help_ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ViewHelp_ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DoAm_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.NhietDo_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.TinhTrangMay_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.ItMay_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.NhieuMay_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.DuBao_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.KetQua_panelControl = new DevExpress.XtraEditors.PanelControl();
            this.chartGra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.boxL = new System.Windows.Forms.TextBox();
            this.boxMM = new System.Windows.Forms.TextBox();
            this.boxM = new System.Windows.Forms.TextBox();
            this.boxN = new System.Windows.Forms.TextBox();
            this.Lanh_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.Mat_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.Mua_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.Nang_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.KetQua_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.KetQua_pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.ItMay_radioButton = new System.Windows.Forms.RadioButton();
            this.NhieuMay_radioButton = new System.Windows.Forms.RadioButton();
            this.TraVeDoAm = new System.Windows.Forms.Button();
            this.NhietdoBox_textEdit = new System.Windows.Forms.NumericUpDown();
            this.DoAmBox_textEdit = new System.Windows.Forms.NumericUpDown();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KetQua_panelControl)).BeginInit();
            this.KetQua_panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KetQua_pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhietdoBox_textEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAmBox_textEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.New_barButtonItem,
            this.LoadFile_barButtonItem,
            this.Explain_barButtonItem,
            this.Fix_barButtonItem,
            this.Project_barButtonItem,
            this.Members_barButtonItem,
            this.ViewHelp_barButtonItem,
            this.Exit_barButtonItem,
            this.chart});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 11;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.chart);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.File_ribbonPage,
            this.About_ribbonPage,
            this.Help_ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(856, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            // 
            // New_barButtonItem
            // 
            this.New_barButtonItem.Caption = "New";
            this.New_barButtonItem.Id = 1;
            this.New_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("New_barButtonItem.ImageOptions.Image")));
            this.New_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("New_barButtonItem.ImageOptions.LargeImage")));
            this.New_barButtonItem.Name = "New_barButtonItem";
            this.New_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.New_barButtonItem_ItemClick);
            // 
            // LoadFile_barButtonItem
            // 
            this.LoadFile_barButtonItem.Caption = "Load File";
            this.LoadFile_barButtonItem.Id = 2;
            this.LoadFile_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LoadFile_barButtonItem.ImageOptions.Image")));
            this.LoadFile_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoadFile_barButtonItem.ImageOptions.LargeImage")));
            this.LoadFile_barButtonItem.Name = "LoadFile_barButtonItem";
            this.LoadFile_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LoadFile_barButtonItem_ItemClick);
            // 
            // Explain_barButtonItem
            // 
            this.Explain_barButtonItem.Caption = "Explain";
            this.Explain_barButtonItem.Id = 3;
            this.Explain_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Explain_barButtonItem.ImageOptions.Image")));
            this.Explain_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Explain_barButtonItem.ImageOptions.LargeImage")));
            this.Explain_barButtonItem.Name = "Explain_barButtonItem";
            this.Explain_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Explain_barButtonItem_ItemClick);
            // 
            // Fix_barButtonItem
            // 
            this.Fix_barButtonItem.Caption = "Fix Training File";
            this.Fix_barButtonItem.Id = 4;
            this.Fix_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Fix_barButtonItem.ImageOptions.Image")));
            this.Fix_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Fix_barButtonItem.ImageOptions.LargeImage")));
            this.Fix_barButtonItem.Name = "Fix_barButtonItem";
            // 
            // Project_barButtonItem
            // 
            this.Project_barButtonItem.Caption = "Project";
            this.Project_barButtonItem.Id = 1;
            this.Project_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Project_barButtonItem.ImageOptions.Image")));
            this.Project_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Project_barButtonItem.ImageOptions.LargeImage")));
            this.Project_barButtonItem.Name = "Project_barButtonItem";
            this.Project_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Project_barButtonItem_ItemClick);
            // 
            // Members_barButtonItem
            // 
            this.Members_barButtonItem.Caption = "Members";
            this.Members_barButtonItem.Id = 2;
            this.Members_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Members_barButtonItem.ImageOptions.Image")));
            this.Members_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Members_barButtonItem.ImageOptions.LargeImage")));
            this.Members_barButtonItem.Name = "Members_barButtonItem";
            this.Members_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Members_barButtonItem_ItemClick);
            // 
            // ViewHelp_barButtonItem
            // 
            this.ViewHelp_barButtonItem.Caption = "View Help";
            this.ViewHelp_barButtonItem.Id = 3;
            this.ViewHelp_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ViewHelp_barButtonItem.ImageOptions.Image")));
            this.ViewHelp_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ViewHelp_barButtonItem.ImageOptions.LargeImage")));
            this.ViewHelp_barButtonItem.Name = "ViewHelp_barButtonItem";
            this.ViewHelp_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ViewHelp_barButtonItem_ItemClick);
            // 
            // Exit_barButtonItem
            // 
            this.Exit_barButtonItem.Caption = "Exit";
            this.Exit_barButtonItem.Id = 4;
            this.Exit_barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit_barButtonItem.ImageOptions.Image")));
            this.Exit_barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Exit_barButtonItem.ImageOptions.LargeImage")));
            this.Exit_barButtonItem.Name = "Exit_barButtonItem";
            this.Exit_barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Exit_barButtonItem_ItemClick);
            // 
            // chart
            // 
            this.chart.Caption = "Show chart";
            this.chart.Id = 10;
            this.chart.Name = "chart";
            this.chart.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chart_CheckedChanged);
            // 
            // File_ribbonPage
            // 
            this.File_ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.New_ribbonPageGroup,
            this.LoadFile_ribbonPageGroup,
            this.Explain_ribbonPageGroup,
            this.Exit_ribbonPageGroup});
            this.File_ribbonPage.Name = "File_ribbonPage";
            this.File_ribbonPage.Text = "File";
            // 
            // New_ribbonPageGroup
            // 
            this.New_ribbonPageGroup.ItemLinks.Add(this.New_barButtonItem);
            this.New_ribbonPageGroup.Name = "New_ribbonPageGroup";
            this.New_ribbonPageGroup.Text = "New";
            // 
            // LoadFile_ribbonPageGroup
            // 
            this.LoadFile_ribbonPageGroup.ItemLinks.Add(this.LoadFile_barButtonItem);
            this.LoadFile_ribbonPageGroup.Name = "LoadFile_ribbonPageGroup";
            this.LoadFile_ribbonPageGroup.Text = "Load File";
            // 
            // Explain_ribbonPageGroup
            // 
            this.Explain_ribbonPageGroup.ItemLinks.Add(this.Explain_barButtonItem);
            this.Explain_ribbonPageGroup.Name = "Explain_ribbonPageGroup";
            this.Explain_ribbonPageGroup.Text = "Explain";
            // 
            // Exit_ribbonPageGroup
            // 
            this.Exit_ribbonPageGroup.ItemLinks.Add(this.Exit_barButtonItem);
            this.Exit_ribbonPageGroup.Name = "Exit_ribbonPageGroup";
            this.Exit_ribbonPageGroup.Text = "Exit";
            // 
            // About_ribbonPage
            // 
            this.About_ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Project_ribbonPageGroup,
            this.Members_ribbonPageGroup});
            this.About_ribbonPage.Name = "About_ribbonPage";
            this.About_ribbonPage.Text = "About";
            // 
            // Project_ribbonPageGroup
            // 
            this.Project_ribbonPageGroup.ItemLinks.Add(this.Project_barButtonItem);
            this.Project_ribbonPageGroup.Name = "Project_ribbonPageGroup";
            this.Project_ribbonPageGroup.Text = "Project";
            // 
            // Members_ribbonPageGroup
            // 
            this.Members_ribbonPageGroup.ItemLinks.Add(this.Members_barButtonItem);
            this.Members_ribbonPageGroup.Name = "Members_ribbonPageGroup";
            this.Members_ribbonPageGroup.Text = "Members";
            // 
            // Help_ribbonPage
            // 
            this.Help_ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ViewHelp_ribbonPageGroup});
            this.Help_ribbonPage.Name = "Help_ribbonPage";
            this.Help_ribbonPage.Text = "Help";
            // 
            // ViewHelp_ribbonPageGroup
            // 
            this.ViewHelp_ribbonPageGroup.ItemLinks.Add(this.ViewHelp_barButtonItem);
            this.ViewHelp_ribbonPageGroup.Name = "ViewHelp_ribbonPageGroup";
            this.ViewHelp_ribbonPageGroup.Text = "View Help";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 459);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(856, 31);
            // 
            // DoAm_labelControl
            // 
            this.DoAm_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoAm_labelControl.Appearance.Options.UseFont = true;
            this.DoAm_labelControl.Location = new System.Drawing.Point(25, 234);
            this.DoAm_labelControl.Name = "DoAm_labelControl";
            this.DoAm_labelControl.Size = new System.Drawing.Size(65, 16);
            this.DoAm_labelControl.TabIndex = 2;
            this.DoAm_labelControl.Text = "Độ Ẩm (%)";
            // 
            // NhietDo_labelControl
            // 
            this.NhietDo_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhietDo_labelControl.Appearance.Options.UseFont = true;
            this.NhietDo_labelControl.Location = new System.Drawing.Point(25, 189);
            this.NhietDo_labelControl.Name = "NhietDo_labelControl";
            this.NhietDo_labelControl.Size = new System.Drawing.Size(77, 16);
            this.NhietDo_labelControl.TabIndex = 3;
            this.NhietDo_labelControl.Text = "Nhiệt Độ (°C)";
            // 
            // TinhTrangMay_labelControl
            // 
            this.TinhTrangMay_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrangMay_labelControl.Appearance.Options.UseFont = true;
            this.TinhTrangMay_labelControl.Location = new System.Drawing.Point(25, 280);
            this.TinhTrangMay_labelControl.Name = "TinhTrangMay_labelControl";
            this.TinhTrangMay_labelControl.Size = new System.Drawing.Size(98, 17);
            this.TinhTrangMay_labelControl.TabIndex = 4;
            this.TinhTrangMay_labelControl.Text = "Tình Trạng Mây";
            // 
            // ItMay_labelControl
            // 
            this.ItMay_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItMay_labelControl.Appearance.Options.UseFont = true;
            this.ItMay_labelControl.Location = new System.Drawing.Point(78, 313);
            this.ItMay_labelControl.Name = "ItMay_labelControl";
            this.ItMay_labelControl.Size = new System.Drawing.Size(35, 16);
            this.ItMay_labelControl.TabIndex = 5;
            this.ItMay_labelControl.Text = "Ít Mây";
            this.ItMay_labelControl.Click += new System.EventHandler(this.ItMay_labelControl_Click);
            // 
            // NhieuMay_labelControl
            // 
            this.NhieuMay_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhieuMay_labelControl.Appearance.Options.UseFont = true;
            this.NhieuMay_labelControl.Location = new System.Drawing.Point(150, 313);
            this.NhieuMay_labelControl.Name = "NhieuMay_labelControl";
            this.NhieuMay_labelControl.Size = new System.Drawing.Size(59, 16);
            this.NhieuMay_labelControl.TabIndex = 6;
            this.NhieuMay_labelControl.Text = "Nhiều Mây";
            this.NhieuMay_labelControl.Click += new System.EventHandler(this.NhieuMay_labelControl_Click);
            // 
            // DuBao_simpleButton
            // 
            this.DuBao_simpleButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuBao_simpleButton.Appearance.Options.UseFont = true;
            this.DuBao_simpleButton.Location = new System.Drawing.Point(58, 366);
            this.DuBao_simpleButton.Name = "DuBao_simpleButton";
            this.DuBao_simpleButton.Size = new System.Drawing.Size(124, 51);
            this.DuBao_simpleButton.TabIndex = 11;
            this.DuBao_simpleButton.Text = "DỰ BÁO";
            this.DuBao_simpleButton.Click += new System.EventHandler(this.DuBao_simpleButton_Click);
            // 
            // KetQua_panelControl
            // 
            this.KetQua_panelControl.Controls.Add(this.chartGra);
            this.KetQua_panelControl.Controls.Add(this.boxL);
            this.KetQua_panelControl.Controls.Add(this.boxMM);
            this.KetQua_panelControl.Controls.Add(this.boxM);
            this.KetQua_panelControl.Controls.Add(this.boxN);
            this.KetQua_panelControl.Controls.Add(this.Lanh_labelControl);
            this.KetQua_panelControl.Controls.Add(this.Mat_labelControl);
            this.KetQua_panelControl.Controls.Add(this.Mua_labelControl);
            this.KetQua_panelControl.Controls.Add(this.Nang_labelControl);
            this.KetQua_panelControl.Controls.Add(this.KetQua_labelControl);
            this.KetQua_panelControl.Controls.Add(this.KetQua_pictureEdit);
            this.KetQua_panelControl.Location = new System.Drawing.Point(234, 150);
            this.KetQua_panelControl.Name = "KetQua_panelControl";
            this.KetQua_panelControl.Size = new System.Drawing.Size(597, 289);
            this.KetQua_panelControl.TabIndex = 12;
            // 
            // chartGra
            // 
            this.chartGra.BorderSkin.BackImage = "C:\\Users\\Rainy\\Downloads\\18600962_1508936905825479_1544228918_n.gif";
            chartArea1.Name = "ChartArea1";
            this.chartGra.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGra.Legends.Add(legend1);
            this.chartGra.Location = new System.Drawing.Point(20, 41);
            this.chartGra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartGra.Name = "chartGra";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Phần trăm (%)";
            this.chartGra.Series.Add(series1);
            this.chartGra.Size = new System.Drawing.Size(398, 226);
            this.chartGra.TabIndex = 17;
            this.chartGra.Text = "chart1";
            this.chartGra.Visible = false;
            // 
            // boxL
            // 
            this.boxL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxL.Enabled = false;
            this.boxL.Location = new System.Drawing.Point(442, 216);
            this.boxL.Name = "boxL";
            this.boxL.ReadOnly = true;
            this.boxL.Size = new System.Drawing.Size(46, 21);
            this.boxL.TabIndex = 16;
            this.boxL.TabStop = false;
            this.boxL.UseWaitCursor = true;
            // 
            // boxMM
            // 
            this.boxMM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxMM.Enabled = false;
            this.boxMM.Location = new System.Drawing.Point(442, 166);
            this.boxMM.Name = "boxMM";
            this.boxMM.ReadOnly = true;
            this.boxMM.Size = new System.Drawing.Size(46, 21);
            this.boxMM.TabIndex = 15;
            this.boxMM.TabStop = false;
            this.boxMM.UseWaitCursor = true;
            // 
            // boxM
            // 
            this.boxM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxM.Enabled = false;
            this.boxM.Location = new System.Drawing.Point(442, 116);
            this.boxM.Name = "boxM";
            this.boxM.ReadOnly = true;
            this.boxM.Size = new System.Drawing.Size(46, 21);
            this.boxM.TabIndex = 14;
            this.boxM.TabStop = false;
            this.boxM.UseWaitCursor = true;
            // 
            // boxN
            // 
            this.boxN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxN.Enabled = false;
            this.boxN.Location = new System.Drawing.Point(442, 64);
            this.boxN.Name = "boxN";
            this.boxN.ReadOnly = true;
            this.boxN.Size = new System.Drawing.Size(46, 21);
            this.boxN.TabIndex = 13;
            this.boxN.TabStop = false;
            this.boxN.UseWaitCursor = true;
            // 
            // Lanh_labelControl
            // 
            this.Lanh_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lanh_labelControl.Appearance.Options.UseFont = true;
            this.Lanh_labelControl.Location = new System.Drawing.Point(502, 221);
            this.Lanh_labelControl.Name = "Lanh_labelControl";
            this.Lanh_labelControl.Size = new System.Drawing.Size(53, 16);
            this.Lanh_labelControl.TabIndex = 12;
            this.Lanh_labelControl.Text = "Lạnh (%)";
            // 
            // Mat_labelControl
            // 
            this.Mat_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat_labelControl.Appearance.Options.UseFont = true;
            this.Mat_labelControl.Location = new System.Drawing.Point(502, 171);
            this.Mat_labelControl.Name = "Mat_labelControl";
            this.Mat_labelControl.Size = new System.Drawing.Size(69, 16);
            this.Mat_labelControl.TabIndex = 7;
            this.Mat_labelControl.Text = "Mát mẻ (%)";
            // 
            // Mua_labelControl
            // 
            this.Mua_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mua_labelControl.Appearance.Options.UseFont = true;
            this.Mua_labelControl.Location = new System.Drawing.Point(502, 121);
            this.Mua_labelControl.Name = "Mua_labelControl";
            this.Mua_labelControl.Size = new System.Drawing.Size(51, 16);
            this.Mua_labelControl.TabIndex = 6;
            this.Mua_labelControl.Text = "Mưa (%)";
            // 
            // Nang_labelControl
            // 
            this.Nang_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nang_labelControl.Appearance.Options.UseFont = true;
            this.Nang_labelControl.Location = new System.Drawing.Point(502, 69);
            this.Nang_labelControl.Name = "Nang_labelControl";
            this.Nang_labelControl.Size = new System.Drawing.Size(55, 16);
            this.Nang_labelControl.TabIndex = 5;
            this.Nang_labelControl.Text = "Nắng (%)";
            // 
            // KetQua_labelControl
            // 
            this.KetQua_labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua_labelControl.Appearance.Options.UseFont = true;
            this.KetQua_labelControl.Location = new System.Drawing.Point(20, 18);
            this.KetQua_labelControl.Name = "KetQua_labelControl";
            this.KetQua_labelControl.Size = new System.Drawing.Size(118, 16);
            this.KetQua_labelControl.TabIndex = 2;
            this.KetQua_labelControl.Text = "THỜI TIẾT HÔM NAY";
            // 
            // KetQua_pictureEdit
            // 
            this.KetQua_pictureEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KetQua_pictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.KetQua_pictureEdit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KetQua_pictureEdit.Location = new System.Drawing.Point(20, 40);
            this.KetQua_pictureEdit.MenuManager = this.ribbonControl;
            this.KetQua_pictureEdit.Name = "KetQua_pictureEdit";
            this.KetQua_pictureEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KetQua_pictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.KetQua_pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.KetQua_pictureEdit.Size = new System.Drawing.Size(398, 229);
            this.KetQua_pictureEdit.TabIndex = 0;
            // 
            // ItMay_radioButton
            // 
            this.ItMay_radioButton.AutoSize = true;
            this.ItMay_radioButton.Location = new System.Drawing.Point(58, 316);
            this.ItMay_radioButton.Name = "ItMay_radioButton";
            this.ItMay_radioButton.Size = new System.Drawing.Size(14, 13);
            this.ItMay_radioButton.TabIndex = 14;
            this.ItMay_radioButton.TabStop = true;
            this.ItMay_radioButton.UseVisualStyleBackColor = true;
            // 
            // NhieuMay_radioButton
            // 
            this.NhieuMay_radioButton.AutoSize = true;
            this.NhieuMay_radioButton.Location = new System.Drawing.Point(130, 316);
            this.NhieuMay_radioButton.Name = "NhieuMay_radioButton";
            this.NhieuMay_radioButton.Size = new System.Drawing.Size(14, 13);
            this.NhieuMay_radioButton.TabIndex = 15;
            this.NhieuMay_radioButton.TabStop = true;
            this.NhieuMay_radioButton.UseVisualStyleBackColor = true;
            // 
            // TraVeDoAm
            // 
            this.TraVeDoAm.Location = new System.Drawing.Point(180, 234);
            this.TraVeDoAm.Name = "TraVeDoAm";
            this.TraVeDoAm.Size = new System.Drawing.Size(21, 19);
            this.TraVeDoAm.TabIndex = 18;
            this.TraVeDoAm.Text = "?";
            this.TraVeDoAm.UseVisualStyleBackColor = true;
            this.TraVeDoAm.Click += new System.EventHandler(this.TraVeDoAm_Click);
            // 
            // NhietdoBox_textEdit
            // 
            this.NhietdoBox_textEdit.Location = new System.Drawing.Point(117, 188);
            this.NhietdoBox_textEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhietdoBox_textEdit.Name = "NhietdoBox_textEdit";
            this.NhietdoBox_textEdit.Size = new System.Drawing.Size(58, 21);
            this.NhietdoBox_textEdit.TabIndex = 21;
            // 
            // DoAmBox_textEdit
            // 
            this.DoAmBox_textEdit.Location = new System.Drawing.Point(117, 232);
            this.DoAmBox_textEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoAmBox_textEdit.Name = "DoAmBox_textEdit";
            this.DoAmBox_textEdit.Size = new System.Drawing.Size(57, 21);
            this.DoAmBox_textEdit.TabIndex = 24;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Chart";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 490);
            this.Controls.Add(this.DoAmBox_textEdit);
            this.Controls.Add(this.NhietdoBox_textEdit);
            this.Controls.Add(this.TraVeDoAm);
            this.Controls.Add(this.NhieuMay_radioButton);
            this.Controls.Add(this.ItMay_radioButton);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.KetQua_panelControl);
            this.Controls.Add(this.DuBao_simpleButton);
            this.Controls.Add(this.NhieuMay_labelControl);
            this.Controls.Add(this.ItMay_labelControl);
            this.Controls.Add(this.TinhTrangMay_labelControl);
            this.Controls.Add(this.NhietDo_labelControl);
            this.Controls.Add(this.DoAm_labelControl);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(890, 581);
            this.MinimumSize = new System.Drawing.Size(763, 479);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Weather N3T";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KetQua_panelControl)).EndInit();
            this.KetQua_panelControl.ResumeLayout(false);
            this.KetQua_panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KetQua_pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhietdoBox_textEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAmBox_textEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage File_ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup New_ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage About_ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage Help_ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup LoadFile_ribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem New_barButtonItem;
        private DevExpress.XtraBars.BarButtonItem LoadFile_barButtonItem;
        private DevExpress.XtraBars.BarButtonItem Explain_barButtonItem;
        private DevExpress.XtraBars.BarButtonItem Fix_barButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Explain_ribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem Project_barButtonItem;
        private DevExpress.XtraBars.BarButtonItem Members_barButtonItem;
        private DevExpress.XtraBars.BarButtonItem ViewHelp_barButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Project_ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Members_ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ViewHelp_ribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem Exit_barButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Exit_ribbonPageGroup;
        private DevExpress.XtraEditors.LabelControl DoAm_labelControl;
        private DevExpress.XtraEditors.LabelControl NhietDo_labelControl;
        private DevExpress.XtraEditors.LabelControl TinhTrangMay_labelControl;
        private DevExpress.XtraEditors.LabelControl ItMay_labelControl;
        private DevExpress.XtraEditors.LabelControl NhieuMay_labelControl;
        private DevExpress.XtraEditors.SimpleButton DuBao_simpleButton;
        private DevExpress.XtraEditors.PanelControl KetQua_panelControl;
        private DevExpress.XtraEditors.LabelControl Mat_labelControl;
        private DevExpress.XtraEditors.LabelControl Mua_labelControl;
        private DevExpress.XtraEditors.LabelControl Nang_labelControl;
        private DevExpress.XtraEditors.LabelControl KetQua_labelControl;
        private DevExpress.XtraEditors.PictureEdit KetQua_pictureEdit;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.RadioButton ItMay_radioButton;
        private System.Windows.Forms.RadioButton NhieuMay_radioButton;
        private DevExpress.XtraEditors.LabelControl Lanh_labelControl;
        private System.Windows.Forms.TextBox boxN;
        private System.Windows.Forms.TextBox boxL;
        private System.Windows.Forms.TextBox boxMM;
        private System.Windows.Forms.TextBox boxM;
        private System.Windows.Forms.Button TraVeDoAm;
        private System.Windows.Forms.NumericUpDown NhietdoBox_textEdit;
        private System.Windows.Forms.NumericUpDown DoAmBox_textEdit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGra;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem chart;
    }
}

