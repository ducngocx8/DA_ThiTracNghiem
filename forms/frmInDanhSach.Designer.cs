namespace CSDLPT_TN.forms
{
    partial class frmInDanhSach
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
            this.pnlTuaDe = new System.Windows.Forms.Panel();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.lbCNBCVT = new System.Windows.Forms.Label();
            this.lbHocVien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlTuaDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTuaDe
            // 
            this.pnlTuaDe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlTuaDe.Controls.Add(this.btnThoat);
            this.pnlTuaDe.Controls.Add(this.dtpkDenNgay);
            this.pnlTuaDe.Controls.Add(this.dtpkTuNgay);
            this.pnlTuaDe.Controls.Add(this.btnInBaoCao);
            this.pnlTuaDe.Controls.Add(this.lbDenNgay);
            this.pnlTuaDe.Controls.Add(this.lbTuNgay);
            this.pnlTuaDe.Controls.Add(this.lbCNBCVT);
            this.pnlTuaDe.Controls.Add(this.lbHocVien);
            this.pnlTuaDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlTuaDe.Location = new System.Drawing.Point(0, 1);
            this.pnlTuaDe.Name = "pnlTuaDe";
            this.pnlTuaDe.Size = new System.Drawing.Size(1562, 238);
            this.pnlTuaDe.TabIndex = 1;
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.Location = new System.Drawing.Point(152, 157);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(321, 30);
            this.dtpkDenNgay.TabIndex = 11;
            this.dtpkDenNgay.ValueChanged += new System.EventHandler(this.dtpkDenNgay_ValueChanged);
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.Location = new System.Drawing.Point(152, 112);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(321, 30);
            this.dtpkTuNgay.TabIndex = 10;
            this.dtpkTuNgay.ValueChanged += new System.EventHandler(this.dtpkTuNgay_ValueChanged);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnInBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInBaoCao.Location = new System.Drawing.Point(1323, 15);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(172, 34);
            this.btnInBaoCao.TabIndex = 8;
            this.btnInBaoCao.Text = "IN BÁO CÁO";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDenNgay.Location = new System.Drawing.Point(26, 162);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(96, 23);
            this.lbDenNgay.TabIndex = 7;
            this.lbDenNgay.Text = "Đến ngày:";
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTuNgay.Location = new System.Drawing.Point(26, 117);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(87, 23);
            this.lbTuNgay.TabIndex = 5;
            this.lbTuNgay.Text = "Từ ngày:";
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
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(12, 198);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 37);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmInDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 497);
            this.Controls.Add(this.pnlTuaDe);
            this.Name = "frmInDanhSach";
            this.Text = "DANH SÁCH ĐĂNG KÝ THI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInDanhSach_Load);
            this.pnlTuaDe.ResumeLayout(false);
            this.pnlTuaDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTuaDe;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.Label lbCNBCVT;
        private System.Windows.Forms.Label lbHocVien;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.Button btnThoat;
    }
}