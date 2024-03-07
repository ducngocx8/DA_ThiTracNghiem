namespace CSDLPT_TN.forms
{
    partial class frmXemKetQua
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
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dsTN = new CSDLPT_TN.TNDataSet();
            this.MONHOCTableAdapter = new CSDLPT_TN.TNDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.dtNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.lbNgayThi = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.Label();
            this.txtLanThi = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.Label();
            this.tnDataSet1 = new CSDLPT_TN.TNDataSet();
            this.txtTenLop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLThi = new System.Windows.Forms.Label();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.lbMaSinhVien = new System.Windows.Forms.Label();
            this.pnBtn = new System.Windows.Forms.Panel();
            this.txtTenSinhVien = new System.Windows.Forms.Label();
            this.monhocTableAdapter1 = new CSDLPT_TN.TNDataSetTableAdapters.MONHOCTableAdapter();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtMaSinhVien = new DevExpress.XtraEditors.TextEdit();
            this.grbThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.lbLanThi = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager();
            this.grbThongTinBaiThi = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnNhapThongTin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnDataSet1)).BeginInit();
            this.pnBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSinhVien.Properties)).BeginInit();
            this.grbThongTinSinhVien.SuspendLayout();
            this.grbThongTinBaiThi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnNhapThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dsTN;
            // 
            // dsTN
            // 
            this.dsTN.DataSetName = "TNDataSet";
            this.dsTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(438, 96);
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
            this.lbMonHoc.Location = new System.Drawing.Point(22, 98);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(68, 18);
            this.lbMonHoc.TabIndex = 6;
            this.lbMonHoc.Text = "Môn thi:";
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.BackColor = System.Drawing.Color.DeepPink;
            this.btnXemKetQua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemKetQua.ForeColor = System.Drawing.Color.White;
            this.btnXemKetQua.Location = new System.Drawing.Point(175, 24);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(172, 44);
            this.btnXemKetQua.TabIndex = 8;
            this.btnXemKetQua.Text = "XEM KẾT QUẢ";
            this.btnXemKetQua.UseVisualStyleBackColor = false;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnInKetQua_Click);
            // 
            // dtNgayThi
            // 
            this.dtNgayThi.EditValue = null;
            this.dtNgayThi.Enabled = false;
            this.dtNgayThi.Location = new System.Drawing.Point(92, 102);
            this.dtNgayThi.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayThi.Name = "dtNgayThi";
            this.dtNgayThi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThi.Properties.Appearance.Options.UseFont = true;
            this.dtNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayThi.Size = new System.Drawing.Size(152, 24);
            this.dtNgayThi.TabIndex = 14;
            // 
            // lbNgayThi
            // 
            this.lbNgayThi.AutoSize = true;
            this.lbNgayThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNgayThi.Location = new System.Drawing.Point(18, 104);
            this.lbNgayThi.Name = "lbNgayThi";
            this.lbNgayThi.Size = new System.Drawing.Size(76, 18);
            this.lbNgayThi.TabIndex = 5;
            this.lbNgayThi.Text = "Ngày thi:";
            // 
            // txtDiem
            // 
            this.txtDiem.AutoSize = true;
            this.txtDiem.BackColor = System.Drawing.Color.White;
            this.txtDiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.ForeColor = System.Drawing.Color.Crimson;
            this.txtDiem.Location = new System.Drawing.Point(313, 69);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiem.Size = new System.Drawing.Size(25, 21);
            this.txtDiem.TabIndex = 13;
            this.txtDiem.Text = "...";
            // 
            // txtLanThi
            // 
            this.txtLanThi.AutoSize = true;
            this.txtLanThi.BackColor = System.Drawing.Color.White;
            this.txtLanThi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanThi.ForeColor = System.Drawing.Color.Crimson;
            this.txtLanThi.Location = new System.Drawing.Point(88, 67);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLanThi.Size = new System.Drawing.Size(25, 21);
            this.txtLanThi.TabIndex = 13;
            this.txtLanThi.Text = "...";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.BackColor = System.Drawing.Color.White;
            this.txtTenMonHoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.ForeColor = System.Drawing.Color.Crimson;
            this.txtTenMonHoc.Location = new System.Drawing.Point(528, 90);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenMonHoc.Size = new System.Drawing.Size(229, 26);
            this.txtTenMonHoc.TabIndex = 13;
            this.txtTenMonHoc.Text = "...";
            // 
            // tnDataSet1
            // 
            this.tnDataSet1.DataSetName = "TNDataSet";
            this.tnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenLop
            // 
            this.txtTenLop.BackColor = System.Drawing.Color.White;
            this.txtTenLop.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.ForeColor = System.Drawing.Color.Crimson;
            this.txtTenLop.Location = new System.Drawing.Point(492, 26);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenLop.Size = new System.Drawing.Size(229, 25);
            this.txtTenLop.TabIndex = 13;
            this.txtTenLop.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(265, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Điểm:";
            // 
            // lbLThi
            // 
            this.lbLThi.AutoSize = true;
            this.lbLThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLThi.Location = new System.Drawing.Point(18, 69);
            this.lbLThi.Name = "lbLThi";
            this.lbLThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLThi.Size = new System.Drawing.Size(67, 18);
            this.lbLThi.TabIndex = 13;
            this.lbLThi.Text = "Lần Thi:";
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMonHoc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTenMonHoc.Location = new System.Drawing.Point(415, 96);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTenMonHoc.Size = new System.Drawing.Size(107, 18);
            this.lbTenMonHoc.TabIndex = 13;
            this.lbTenMonHoc.Text = "Tên Môn Học:";
            // 
            // lbMaSinhVien
            // 
            this.lbMaSinhVien.AutoSize = true;
            this.lbMaSinhVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSinhVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbMaSinhVien.Location = new System.Drawing.Point(22, 41);
            this.lbMaSinhVien.Name = "lbMaSinhVien";
            this.lbMaSinhVien.Size = new System.Drawing.Size(59, 18);
            this.lbMaSinhVien.TabIndex = 6;
            this.lbMaSinhVien.Text = "Mã SV:";
            // 
            // pnBtn
            // 
            this.pnBtn.BackColor = System.Drawing.Color.White;
            this.pnBtn.Controls.Add(this.btnXemKetQua);
            this.pnBtn.Location = new System.Drawing.Point(5, 159);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(1543, 97);
            this.pnBtn.TabIndex = 5;
            this.pnBtn.Visible = false;
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.BackColor = System.Drawing.Color.White;
            this.txtTenSinhVien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSinhVien.ForeColor = System.Drawing.Color.Crimson;
            this.txtTenSinhVien.Location = new System.Drawing.Point(129, 31);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenSinhVien.Size = new System.Drawing.Size(229, 26);
            this.txtTenSinhVien.TabIndex = 13;
            this.txtTenSinhVien.Text = "...";
            // 
            // monhocTableAdapter1
            // 
            this.monhocTableAdapter1.ClearBeforeFill = true;
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTenLop.Location = new System.Drawing.Point(415, 29);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTenLop.Size = new System.Drawing.Size(71, 18);
            this.lbTenLop.TabIndex = 13;
            this.lbTenLop.Text = "Tên Lớp:";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(108, 96);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(211, 26);
            this.cbbMonHoc.TabIndex = 21;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(108, 41);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSinhVien.Properties.Appearance.Options.UseFont = true;
            this.txtMaSinhVien.Size = new System.Drawing.Size(211, 24);
            this.txtMaSinhVien.TabIndex = 20;
            this.txtMaSinhVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSinhVien_KeyPress);
            // 
            // grbThongTinSinhVien
            // 
            this.grbThongTinSinhVien.Controls.Add(this.cbbMonHoc);
            this.grbThongTinSinhVien.Controls.Add(this.txtMaSinhVien);
            this.grbThongTinSinhVien.Controls.Add(this.lbLanThi);
            this.grbThongTinSinhVien.Controls.Add(this.cbbLanThi);
            this.grbThongTinSinhVien.Controls.Add(this.lbMaSinhVien);
            this.grbThongTinSinhVien.Controls.Add(this.lbMonHoc);
            this.grbThongTinSinhVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinSinhVien.Location = new System.Drawing.Point(0, 3);
            this.grbThongTinSinhVien.Name = "grbThongTinSinhVien";
            this.grbThongTinSinhVien.Size = new System.Drawing.Size(644, 139);
            this.grbThongTinSinhVien.TabIndex = 22;
            this.grbThongTinSinhVien.TabStop = false;
            this.grbThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // lbLanThi
            // 
            this.lbLanThi.AutoSize = true;
            this.lbLanThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLanThi.Location = new System.Drawing.Point(368, 98);
            this.lbLanThi.Name = "lbLanThi";
            this.lbLanThi.Size = new System.Drawing.Size(64, 18);
            this.lbLanThi.TabIndex = 7;
            this.lbLanThi.Text = "Lần thi:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHoTen.Location = new System.Drawing.Point(18, 33);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbHoTen.Size = new System.Drawing.Size(114, 18);
            this.lbHoTen.TabIndex = 13;
            this.lbHoTen.Text = "Tên Sinh Viên:";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.COSOTableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grbThongTinBaiThi
            // 
            this.grbThongTinBaiThi.Controls.Add(this.dtNgayThi);
            this.grbThongTinBaiThi.Controls.Add(this.lbNgayThi);
            this.grbThongTinBaiThi.Controls.Add(this.txtDiem);
            this.grbThongTinBaiThi.Controls.Add(this.txtLanThi);
            this.grbThongTinBaiThi.Controls.Add(this.txtTenMonHoc);
            this.grbThongTinBaiThi.Controls.Add(this.txtTenLop);
            this.grbThongTinBaiThi.Controls.Add(this.txtTenSinhVien);
            this.grbThongTinBaiThi.Controls.Add(this.label1);
            this.grbThongTinBaiThi.Controls.Add(this.lbLThi);
            this.grbThongTinBaiThi.Controls.Add(this.lbTenMonHoc);
            this.grbThongTinBaiThi.Controls.Add(this.lbTenLop);
            this.grbThongTinBaiThi.Controls.Add(this.lbHoTen);
            this.grbThongTinBaiThi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinBaiThi.Location = new System.Drawing.Point(680, 3);
            this.grbThongTinBaiThi.Name = "grbThongTinBaiThi";
            this.grbThongTinBaiThi.Size = new System.Drawing.Size(806, 139);
            this.grbThongTinBaiThi.TabIndex = 23;
            this.grbThongTinBaiThi.TabStop = false;
            this.grbThongTinBaiThi.Text = "Thông tin bài thi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.grbThongTinBaiThi);
            this.panel1.Controls.Add(this.grbThongTinSinhVien);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 150);
            this.panel1.TabIndex = 2;
            // 
            // pnNhapThongTin
            // 
            this.pnNhapThongTin.BackColor = System.Drawing.Color.White;
            this.pnNhapThongTin.Controls.Add(this.panel1);
            this.pnNhapThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnNhapThongTin.Location = new System.Drawing.Point(2, 0);
            this.pnNhapThongTin.Name = "pnNhapThongTin";
            this.pnNhapThongTin.Size = new System.Drawing.Size(1546, 163);
            this.pnNhapThongTin.TabIndex = 4;
            // 
            // frmXemKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 703);
            this.Controls.Add(this.pnBtn);
            this.Controls.Add(this.pnNhapThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmXemKetQua";
            this.Text = "KẾT QUẢ THI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnDataSet1)).EndInit();
            this.pnBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSinhVien.Properties)).EndInit();
            this.grbThongTinSinhVien.ResumeLayout(false);
            this.grbThongTinSinhVien.PerformLayout();
            this.grbThongTinBaiThi.ResumeLayout(false);
            this.grbThongTinBaiThi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnNhapThongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsMonHoc;
        private TNDataSet dsTN;
        private TNDataSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Button btnXemKetQua;
        private DevExpress.XtraEditors.DateEdit dtNgayThi;
        private System.Windows.Forms.Label lbNgayThi;
        private System.Windows.Forms.Label txtDiem;
        private System.Windows.Forms.Label txtLanThi;
        private System.Windows.Forms.Label txtTenMonHoc;
        private TNDataSet tnDataSet1;
        private System.Windows.Forms.Label txtTenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLThi;
        private System.Windows.Forms.Label lbTenMonHoc;
        private System.Windows.Forms.Label lbMaSinhVien;
        private System.Windows.Forms.Panel pnBtn;
        private System.Windows.Forms.Label txtTenSinhVien;
        private TNDataSetTableAdapters.MONHOCTableAdapter monhocTableAdapter1;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private DevExpress.XtraEditors.TextEdit txtMaSinhVien;
        private System.Windows.Forms.GroupBox grbThongTinSinhVien;
        private System.Windows.Forms.Label lbLanThi;
        private System.Windows.Forms.Label lbHoTen;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox grbThongTinBaiThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnNhapThongTin;
    }
}