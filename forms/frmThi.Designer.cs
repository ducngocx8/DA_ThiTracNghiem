namespace CSDLPT_TN.forms
{
    partial class frmThi
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
            this.components = new System.ComponentModel.Container();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.dsTN = new CSDLPT_TN.TNDataSet();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.lbTG = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbLanThi = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.txtTenLop = new DevExpress.XtraEditors.LabelControl();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.btnBatDauThi = new System.Windows.Forms.Button();
            this.pnBatDau = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.tableAdapterManager = new CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new CSDLPT_TN.TNDataSetTableAdapters.LOPTableAdapter();
            this.MONHOCTableAdapter = new CSDLPT_TN.TNDataSetTableAdapters.MONHOCTableAdapter();
            this.timerThi = new System.Windows.Forms.Timer(this.components);
            this.bdsBaiThi = new System.Windows.Forms.BindingSource(this.components);
            this.listviewCauHoi = new System.Windows.Forms.ListView();
            this.cauHoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dapAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnCauHoi = new System.Windows.Forms.Panel();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.pnBtnCauHoi = new System.Windows.Forms.Panel();
            this.BANGDIEMTableAdapter = new CSDLPT_TN.TNDataSetTableAdapters.BANGDIEMTableAdapter();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.pnlTuaDe = new System.Windows.Forms.Panel();
            this.grbThongTinBaiThi = new System.Windows.Forms.GroupBox();
            this.dtNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.lbNgayThi = new System.Windows.Forms.Label();
            this.txtTrinhDo = new System.Windows.Forms.Label();
            this.txtThoiGianThi = new System.Windows.Forms.Label();
            this.txtSoCauHoi = new System.Windows.Forms.Label();
            this.txtLanThi = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.Label();
            this.lbTrinhDo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSoCau = new System.Windows.Forms.Label();
            this.lbLanThiInfo = new System.Windows.Forms.Label();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.grbThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTN)).BeginInit();
            this.pnBatDau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaiThi)).BeginInit();
            this.pnBtnCauHoi.SuspendLayout();
            this.pnlTuaDe.SuspendLayout();
            this.grbThongTinBaiThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties)).BeginInit();
            this.grbThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.dsTN;
            // 
            // dsTN
            // 
            this.dsTN.DataSetName = "TNDataSet";
            this.dsTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNopBai.Enabled = false;
            this.btnNopBai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.ForeColor = System.Drawing.Color.White;
            this.btnNopBai.Location = new System.Drawing.Point(959, 14);
            this.btnNopBai.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(166, 49);
            this.btnNopBai.TabIndex = 17;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.BackColor = System.Drawing.Color.White;
            this.lbTG.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold);
            this.lbTG.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTG.Location = new System.Drawing.Point(571, 35);
            this.lbTG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(71, 17);
            this.lbTG.TabIndex = 16;
            this.lbTG.Text = "Thời gian";
            this.lbTG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLop.Location = new System.Drawing.Point(108, 30);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(211, 26);
            this.txtMaLop.TabIndex = 22;
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(108, 29);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(211, 26);
            this.cbbLop.TabIndex = 20;
            this.cbbLop.Visible = false;
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Appearance.BackColor = System.Drawing.Color.White;
            this.txtHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtHoTen.Appearance.Options.UseBackColor = true;
            this.txtHoTen.Appearance.Options.UseFont = true;
            this.txtHoTen.Appearance.Options.UseForeColor = true;
            this.txtHoTen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtHoTen.Location = new System.Drawing.Point(480, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtHoTen.Size = new System.Drawing.Size(141, 34);
            this.txtHoTen.TabIndex = 19;
            this.txtHoTen.Text = "Nguyễn Văn A";
            // 
            // lbLanThi
            // 
            this.lbLanThi.AutoSize = true;
            this.lbLanThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLanThi.Location = new System.Drawing.Point(368, 104);
            this.lbLanThi.Name = "lbLanThi";
            this.lbLanThi.Size = new System.Drawing.Size(64, 18);
            this.lbLanThi.TabIndex = 7;
            this.lbLanThi.Text = "Lần thi:";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(438, 102);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(132, 26);
            this.cbbLanThi.TabIndex = 2;
            this.cbbLanThi.SelectedIndexChanged += new System.EventHandler(this.cbbLanThi_SelectedIndexChanged);
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonHoc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbMonHoc.Location = new System.Drawing.Point(22, 104);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(74, 18);
            this.lbMonHoc.TabIndex = 6;
            this.lbMonHoc.Text = "Môn học:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenLop.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtTenLop.Appearance.Options.UseBackColor = true;
            this.txtTenLop.Appearance.Options.UseFont = true;
            this.txtTenLop.Appearance.Options.UseForeColor = true;
            this.txtTenLop.Location = new System.Drawing.Point(108, 66);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(15, 18);
            this.txtTenLop.TabIndex = 19;
            this.txtTenLop.Text = "...";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbMaLop.Location = new System.Drawing.Point(21, 33);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(62, 18);
            this.lbMaLop.TabIndex = 12;
            this.lbMaLop.Text = "Mã lớp:";
            // 
            // btnBatDauThi
            // 
            this.btnBatDauThi.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBatDauThi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDauThi.ForeColor = System.Drawing.Color.White;
            this.btnBatDauThi.Location = new System.Drawing.Point(241, 20);
            this.btnBatDauThi.Name = "btnBatDauThi";
            this.btnBatDauThi.Size = new System.Drawing.Size(172, 44);
            this.btnBatDauThi.TabIndex = 14;
            this.btnBatDauThi.Text = "BẮT ĐẦU THI";
            this.btnBatDauThi.UseVisualStyleBackColor = false;
            this.btnBatDauThi.Click += new System.EventHandler(this.btnBatDauThi_Click);
            // 
            // pnBatDau
            // 
            this.pnBatDau.BackColor = System.Drawing.Color.White;
            this.pnBatDau.Controls.Add(this.btnNopBai);
            this.pnBatDau.Controls.Add(this.lbTG);
            this.pnBatDau.Controls.Add(this.btnBatDauThi);
            this.pnBatDau.Controls.Add(this.lbTime);
            this.pnBatDau.Location = new System.Drawing.Point(3, 148);
            this.pnBatDau.Name = "pnBatDau";
            this.pnBatDau.Size = new System.Drawing.Size(1193, 79);
            this.pnBatDau.TabIndex = 23;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.White;
            this.lbTime.Font = new System.Drawing.Font("Tahoma", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTime.Location = new System.Drawing.Point(647, 20);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(138, 41);
            this.lbTime.TabIndex = 15;
            this.lbTime.Text = "00 : 00";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // timerThi
            // 
            this.timerThi.Interval = 1000;
            this.timerThi.Tick += new System.EventHandler(this.timerThi_Tick);
            // 
            // listviewCauHoi
            // 
            this.listviewCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cauHoi,
            this.dapAn});
            this.listviewCauHoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.listviewCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewCauHoi.GridLines = true;
            this.listviewCauHoi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewCauHoi.HideSelection = false;
            this.listviewCauHoi.Location = new System.Drawing.Point(1357, 0);
            this.listviewCauHoi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listviewCauHoi.Name = "listviewCauHoi";
            this.listviewCauHoi.Size = new System.Drawing.Size(198, 668);
            this.listviewCauHoi.TabIndex = 24;
            this.listviewCauHoi.UseCompatibleStateImageBehavior = false;
            this.listviewCauHoi.View = System.Windows.Forms.View.Details;
            // 
            // cauHoi
            // 
            this.cauHoi.Text = "Câu hỏi";
            this.cauHoi.Width = 72;
            // 
            // dapAn
            // 
            this.dapAn.Text = "Đáp án";
            this.dapAn.Width = 120;
            // 
            // pnCauHoi
            // 
            this.pnCauHoi.Location = new System.Drawing.Point(3, 245);
            this.pnCauHoi.Name = "pnCauHoi";
            this.pnCauHoi.Size = new System.Drawing.Size(917, 305);
            this.pnCauHoi.TabIndex = 25;
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCauTruoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCauTruoc.ForeColor = System.Drawing.Color.Transparent;
            this.btnCauTruoc.Location = new System.Drawing.Point(171, 0);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(142, 48);
            this.btnCauTruoc.TabIndex = 12;
            this.btnCauTruoc.Text = "Câu Trước";
            this.btnCauTruoc.UseVisualStyleBackColor = false;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnCauSau
            // 
            this.btnCauSau.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCauSau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCauSau.ForeColor = System.Drawing.Color.Transparent;
            this.btnCauSau.Location = new System.Drawing.Point(432, 0);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(142, 48);
            this.btnCauSau.TabIndex = 11;
            this.btnCauSau.Text = "Câu Sau";
            this.btnCauSau.UseVisualStyleBackColor = false;
            this.btnCauSau.Click += new System.EventHandler(this.btnCauSau_Click);
            // 
            // pnBtnCauHoi
            // 
            this.pnBtnCauHoi.Controls.Add(this.btnCauTruoc);
            this.pnBtnCauHoi.Controls.Add(this.btnCauSau);
            this.pnBtnCauHoi.Location = new System.Drawing.Point(19, 566);
            this.pnBtnCauHoi.Name = "pnBtnCauHoi";
            this.pnBtnCauHoi.Size = new System.Drawing.Size(782, 55);
            this.pnBtnCauHoi.TabIndex = 26;
            this.pnBtnCauHoi.Visible = false;
            // 
            // BANGDIEMTableAdapter
            // 
            this.BANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTenLop.Location = new System.Drawing.Point(21, 66);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTenLop.Size = new System.Drawing.Size(71, 18);
            this.lbTenLop.TabIndex = 13;
            this.lbTenLop.Text = "Tên Lớp:";
            // 
            // pnlTuaDe
            // 
            this.pnlTuaDe.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlTuaDe.Controls.Add(this.grbThongTinBaiThi);
            this.pnlTuaDe.Controls.Add(this.grbThongTinSinhVien);
            this.pnlTuaDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlTuaDe.Location = new System.Drawing.Point(0, -57);
            this.pnlTuaDe.Name = "pnlTuaDe";
            this.pnlTuaDe.Size = new System.Drawing.Size(1543, 199);
            this.pnlTuaDe.TabIndex = 22;
            // 
            // grbThongTinBaiThi
            // 
            this.grbThongTinBaiThi.Controls.Add(this.dtNgayThi);
            this.grbThongTinBaiThi.Controls.Add(this.lbNgayThi);
            this.grbThongTinBaiThi.Controls.Add(this.txtTrinhDo);
            this.grbThongTinBaiThi.Controls.Add(this.txtThoiGianThi);
            this.grbThongTinBaiThi.Controls.Add(this.txtSoCauHoi);
            this.grbThongTinBaiThi.Controls.Add(this.txtLanThi);
            this.grbThongTinBaiThi.Controls.Add(this.txtTenMonHoc);
            this.grbThongTinBaiThi.Controls.Add(this.lbTrinhDo);
            this.grbThongTinBaiThi.Controls.Add(this.label5);
            this.grbThongTinBaiThi.Controls.Add(this.lbSoCau);
            this.grbThongTinBaiThi.Controls.Add(this.lbLanThiInfo);
            this.grbThongTinBaiThi.Controls.Add(this.lbTenMonHoc);
            this.grbThongTinBaiThi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinBaiThi.Location = new System.Drawing.Point(676, 57);
            this.grbThongTinBaiThi.Name = "grbThongTinBaiThi";
            this.grbThongTinBaiThi.Size = new System.Drawing.Size(511, 139);
            this.grbThongTinBaiThi.TabIndex = 23;
            this.grbThongTinBaiThi.TabStop = false;
            this.grbThongTinBaiThi.Text = "Thông tin bài thi";
            // 
            // dtNgayThi
            // 
            this.dtNgayThi.EditValue = null;
            this.dtNgayThi.Enabled = false;
            this.dtNgayThi.Location = new System.Drawing.Point(92, 100);
            this.dtNgayThi.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayThi.Name = "dtNgayThi";
            this.dtNgayThi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThi.Properties.Appearance.Options.UseFont = true;
            this.dtNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayThi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.dtNgayThi.Size = new System.Drawing.Size(152, 24);
            this.dtNgayThi.TabIndex = 14;
            // 
            // lbNgayThi
            // 
            this.lbNgayThi.AutoSize = true;
            this.lbNgayThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNgayThi.Location = new System.Drawing.Point(18, 102);
            this.lbNgayThi.Name = "lbNgayThi";
            this.lbNgayThi.Size = new System.Drawing.Size(76, 18);
            this.lbNgayThi.TabIndex = 5;
            this.lbNgayThi.Text = "Ngày thi:";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.AutoSize = true;
            this.txtTrinhDo.BackColor = System.Drawing.Color.White;
            this.txtTrinhDo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrinhDo.ForeColor = System.Drawing.Color.Crimson;
            this.txtTrinhDo.Location = new System.Drawing.Point(101, 66);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTrinhDo.Size = new System.Drawing.Size(23, 18);
            this.txtTrinhDo.TabIndex = 13;
            this.txtTrinhDo.Text = "...";
            // 
            // txtThoiGianThi
            // 
            this.txtThoiGianThi.AutoSize = true;
            this.txtThoiGianThi.BackColor = System.Drawing.Color.White;
            this.txtThoiGianThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianThi.ForeColor = System.Drawing.Color.Crimson;
            this.txtThoiGianThi.Location = new System.Drawing.Point(400, 103);
            this.txtThoiGianThi.Name = "txtThoiGianThi";
            this.txtThoiGianThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThoiGianThi.Size = new System.Drawing.Size(57, 18);
            this.txtThoiGianThi.TabIndex = 13;
            this.txtThoiGianThi.Text = "... phút";
            // 
            // txtSoCauHoi
            // 
            this.txtSoCauHoi.AutoSize = true;
            this.txtSoCauHoi.BackColor = System.Drawing.Color.White;
            this.txtSoCauHoi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCauHoi.ForeColor = System.Drawing.Color.Crimson;
            this.txtSoCauHoi.Location = new System.Drawing.Point(400, 66);
            this.txtSoCauHoi.Name = "txtSoCauHoi";
            this.txtSoCauHoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoCauHoi.Size = new System.Drawing.Size(23, 18);
            this.txtSoCauHoi.TabIndex = 13;
            this.txtSoCauHoi.Text = "...";
            // 
            // txtLanThi
            // 
            this.txtLanThi.AutoSize = true;
            this.txtLanThi.BackColor = System.Drawing.Color.White;
            this.txtLanThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanThi.ForeColor = System.Drawing.Color.Crimson;
            this.txtLanThi.Location = new System.Drawing.Point(400, 33);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLanThi.Size = new System.Drawing.Size(23, 18);
            this.txtLanThi.TabIndex = 13;
            this.txtLanThi.Text = "...";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.BackColor = System.Drawing.Color.White;
            this.txtTenMonHoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.ForeColor = System.Drawing.Color.Crimson;
            this.txtTenMonHoc.Location = new System.Drawing.Point(128, 33);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenMonHoc.Size = new System.Drawing.Size(83, 18);
            this.txtTenMonHoc.TabIndex = 13;
            this.txtTenMonHoc.Text = "...";
            // 
            // lbTrinhDo
            // 
            this.lbTrinhDo.AutoSize = true;
            this.lbTrinhDo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrinhDo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTrinhDo.Location = new System.Drawing.Point(18, 66);
            this.lbTrinhDo.Name = "lbTrinhDo";
            this.lbTrinhDo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTrinhDo.Size = new System.Drawing.Size(77, 18);
            this.lbTrinhDo.TabIndex = 13;
            this.lbTrinhDo.Text = "Trình Độ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(300, 103);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thời Gian:";
            // 
            // lbSoCau
            // 
            this.lbSoCau.AutoSize = true;
            this.lbSoCau.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoCau.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbSoCau.Location = new System.Drawing.Point(300, 66);
            this.lbSoCau.Name = "lbSoCau";
            this.lbSoCau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSoCau.Size = new System.Drawing.Size(93, 18);
            this.lbSoCau.TabIndex = 13;
            this.lbSoCau.Text = "Số Câu Hỏi:";
            // 
            // lbLanThiInfo
            // 
            this.lbLanThiInfo.AutoSize = true;
            this.lbLanThiInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanThiInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLanThiInfo.Location = new System.Drawing.Point(300, 33);
            this.lbLanThiInfo.Name = "lbLanThiInfo";
            this.lbLanThiInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLanThiInfo.Size = new System.Drawing.Size(67, 18);
            this.lbLanThiInfo.TabIndex = 13;
            this.lbLanThiInfo.Text = "Lần Thi:";
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMonHoc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTenMonHoc.Location = new System.Drawing.Point(18, 33);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTenMonHoc.Size = new System.Drawing.Size(107, 18);
            this.lbTenMonHoc.TabIndex = 13;
            this.lbTenMonHoc.Text = "Tên Môn Học:";
            // 
            // grbThongTinSinhVien
            // 
            this.grbThongTinSinhVien.Controls.Add(this.cbbLop);
            this.grbThongTinSinhVien.Controls.Add(this.txtMaLop);
            this.grbThongTinSinhVien.Controls.Add(this.txtHoTen);
            this.grbThongTinSinhVien.Controls.Add(this.lbLanThi);
            this.grbThongTinSinhVien.Controls.Add(this.cbbLanThi);
            this.grbThongTinSinhVien.Controls.Add(this.lbMonHoc);
            this.grbThongTinSinhVien.Controls.Add(this.txtTenLop);
            this.grbThongTinSinhVien.Controls.Add(this.lbMaLop);
            this.grbThongTinSinhVien.Controls.Add(this.lbTenLop);
            this.grbThongTinSinhVien.Controls.Add(this.lbHoTen);
            this.grbThongTinSinhVien.Controls.Add(this.cbbMonHoc);
            this.grbThongTinSinhVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinSinhVien.Location = new System.Drawing.Point(3, 57);
            this.grbThongTinSinhVien.Name = "grbThongTinSinhVien";
            this.grbThongTinSinhVien.Size = new System.Drawing.Size(644, 139);
            this.grbThongTinSinhVien.TabIndex = 22;
            this.grbThongTinSinhVien.TabStop = false;
            this.grbThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHoTen.Location = new System.Drawing.Point(370, 33);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(107, 18);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ và tên SV:";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(108, 101);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(211, 26);
            this.cbbMonHoc.TabIndex = 17;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "BANGDIEM";
            this.bdsBangDiem.DataSource = this.dsTN;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dsTN;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1555, 668);
            this.Controls.Add(this.pnBatDau);
            this.Controls.Add(this.listviewCauHoi);
            this.Controls.Add(this.pnCauHoi);
            this.Controls.Add(this.pnBtnCauHoi);
            this.Controls.Add(this.pnlTuaDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThi";
            this.Text = "TIẾN HÀNH THI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTN)).EndInit();
            this.pnBatDau.ResumeLayout(false);
            this.pnBatDau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaiThi)).EndInit();
            this.pnBtnCauHoi.ResumeLayout(false);
            this.pnlTuaDe.ResumeLayout(false);
            this.grbThongTinBaiThi.ResumeLayout(false);
            this.grbThongTinBaiThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties)).EndInit();
            this.grbThongTinSinhVien.ResumeLayout(false);
            this.grbThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsMONHOC;
        private TNDataSet dsTN;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.ComboBox cbbLop;
        private DevExpress.XtraEditors.LabelControl txtHoTen;
        private System.Windows.Forms.Label lbLanThi;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label lbMonHoc;
        private DevExpress.XtraEditors.LabelControl txtTenLop;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Button btnBatDauThi;
        private System.Windows.Forms.Panel pnBatDau;
        private System.Windows.Forms.Label lbTime;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TNDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private TNDataSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.Timer timerThi;
        private System.Windows.Forms.BindingSource bdsBaiThi;
        public System.Windows.Forms.ListView listviewCauHoi;
        private System.Windows.Forms.ColumnHeader cauHoi;
        private System.Windows.Forms.ColumnHeader dapAn;
        private System.Windows.Forms.Panel pnCauHoi;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.Panel pnBtnCauHoi;
        private TNDataSetTableAdapters.BANGDIEMTableAdapter BANGDIEMTableAdapter;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Panel pnlTuaDe;
        private System.Windows.Forms.GroupBox grbThongTinBaiThi;
        private DevExpress.XtraEditors.DateEdit dtNgayThi;
        private System.Windows.Forms.Label lbNgayThi;
        private System.Windows.Forms.Label txtTrinhDo;
        private System.Windows.Forms.Label txtThoiGianThi;
        private System.Windows.Forms.Label txtSoCauHoi;
        private System.Windows.Forms.Label txtLanThi;
        private System.Windows.Forms.Label txtTenMonHoc;
        private System.Windows.Forms.Label lbTrinhDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSoCau;
        private System.Windows.Forms.Label lbLanThiInfo;
        private System.Windows.Forms.Label lbTenMonHoc;
        private System.Windows.Forms.GroupBox grbThongTinSinhVien;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private System.Windows.Forms.BindingSource lOPBindingSource;
    }
}