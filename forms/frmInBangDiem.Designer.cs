namespace CSDLPT_TN.forms
{
    partial class frmInBangDiem
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
            System.Windows.Forms.Label lbLop;
            System.Windows.Forms.Label lbMonHoc;
            this.pnlTuaDe = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource();
            this.dsTN = new CSDLPT_TN.TNDataSet();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.lbaCoSo = new System.Windows.Forms.Label();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.lbLanThi = new System.Windows.Forms.Label();
            this.lbCNBCVT = new System.Windows.Forms.Label();
            this.lbHocVien = new System.Windows.Forms.Label();
            this.LOPTableAdapter = new CSDLPT_TN.TNDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new CSDLPT_TN.TNDataSetTableAdapters.MONHOCTableAdapter();
            lbLop = new System.Windows.Forms.Label();
            lbMonHoc = new System.Windows.Forms.Label();
            this.pnlTuaDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Location = new System.Drawing.Point(16, 125);
            lbLop.Name = "lbLop";
            lbLop.Size = new System.Drawing.Size(51, 23);
            lbLop.TabIndex = 10;
            lbLop.Text = "Lớp:";
            // 
            // lbMonHoc
            // 
            lbMonHoc.AutoSize = true;
            lbMonHoc.Location = new System.Drawing.Point(16, 164);
            lbMonHoc.Name = "lbMonHoc";
            lbMonHoc.Size = new System.Drawing.Size(89, 23);
            lbMonHoc.TabIndex = 11;
            lbMonHoc.Text = "Môn học:";
            // 
            // pnlTuaDe
            // 
            this.pnlTuaDe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlTuaDe.Controls.Add(this.btnThoat);
            this.pnlTuaDe.Controls.Add(this.cbbLanThi);
            this.pnlTuaDe.Controls.Add(this.cbbMonHoc);
            this.pnlTuaDe.Controls.Add(this.cbbLop);
            this.pnlTuaDe.Controls.Add(this.cbbCoSo);
            this.pnlTuaDe.Controls.Add(lbMonHoc);
            this.pnlTuaDe.Controls.Add(lbLop);
            this.pnlTuaDe.Controls.Add(this.lbaCoSo);
            this.pnlTuaDe.Controls.Add(this.btnInBaoCao);
            this.pnlTuaDe.Controls.Add(this.lbLanThi);
            this.pnlTuaDe.Controls.Add(this.lbCNBCVT);
            this.pnlTuaDe.Controls.Add(this.lbHocVien);
            this.pnlTuaDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlTuaDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTuaDe.Name = "pnlTuaDe";
            this.pnlTuaDe.Size = new System.Drawing.Size(1538, 289);
            this.pnlTuaDe.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(11, 236);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 37);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbLanThi.Location = new System.Drawing.Point(118, 197);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(275, 27);
            this.cbbLanThi.TabIndex = 16;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "TENMH", true));
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(118, 161);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(275, 27);
            this.cbbMonHoc.TabIndex = 15;
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
            // cbbLop
            // 
            this.cbbLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(118, 122);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(275, 27);
            this.cbbLop.TabIndex = 14;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dsTN;
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(1314, 197);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(195, 31);
            this.cbbCoSo.TabIndex = 13;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged_1);
            // 
            // lbaCoSo
            // 
            this.lbaCoSo.AutoSize = true;
            this.lbaCoSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbaCoSo.Location = new System.Drawing.Point(1242, 200);
            this.lbaCoSo.Name = "lbaCoSo";
            this.lbaCoSo.Size = new System.Drawing.Size(66, 23);
            this.lbaCoSo.TabIndex = 9;
            this.lbaCoSo.Text = "Cơ sở:";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnInBaoCao.Location = new System.Drawing.Point(1314, 18);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(195, 37);
            this.btnInBaoCao.TabIndex = 8;
            this.btnInBaoCao.Text = "IN BÁO CÁO";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // lbLanThi
            // 
            this.lbLanThi.AutoSize = true;
            this.lbLanThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLanThi.Location = new System.Drawing.Point(16, 200);
            this.lbLanThi.Name = "lbLanThi";
            this.lbLanThi.Size = new System.Drawing.Size(77, 23);
            this.lbLanThi.TabIndex = 7;
            this.lbLanThi.Text = "Lần thi:";
            // 
            // lbCNBCVT
            // 
            this.lbCNBCVT.AutoSize = true;
            this.lbCNBCVT.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCNBCVT.ForeColor = System.Drawing.Color.Red;
            this.lbCNBCVT.Location = new System.Drawing.Point(14, 55);
            this.lbCNBCVT.Name = "lbCNBCVT";
            this.lbCNBCVT.Size = new System.Drawing.Size(545, 32);
            this.lbCNBCVT.TabIndex = 1;
            this.lbCNBCVT.Text = "CÔNG NGHỆ BƯU CHÍNH VIẾN THÔNG";
            // 
            // lbHocVien
            // 
            this.lbHocVien.AutoSize = true;
            this.lbHocVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHocVien.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbHocVien.Location = new System.Drawing.Point(15, 18);
            this.lbHocVien.Name = "lbHocVien";
            this.lbHocVien.Size = new System.Drawing.Size(132, 26);
            this.lbHocVien.TabIndex = 0;
            this.lbHocVien.Text = "HỌC VIỆN";
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_TN.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmInBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 527);
            this.Controls.Add(this.pnlTuaDe);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInBangDiem";
            this.Text = "Bảng điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInBangDiem_Load);
            this.pnlTuaDe.ResumeLayout(false);
            this.pnlTuaDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTuaDe;
        private System.Windows.Forms.Label lbCNBCVT;
        private System.Windows.Forms.Label lbHocVien;
        private System.Windows.Forms.Label lbLanThi;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Label lbaCoSo;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private TNDataSet dsTN;
        private System.Windows.Forms.BindingSource bdsLop;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbLop;
        private TNDataSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private TNDataSetTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.Button btnThoat;
    }
}