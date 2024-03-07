namespace CSDLPT_TN.forms
{
    partial class frmDangNhap
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
            this.rdbtnGiangVien = new System.Windows.Forms.RadioButton();
            this.rdbtnSinhVien = new System.Windows.Forms.RadioButton();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnGiangVien
            // 
            this.rdbtnGiangVien.AutoSize = true;
            this.rdbtnGiangVien.Location = new System.Drawing.Point(450, 176);
            this.rdbtnGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnGiangVien.Name = "rdbtnGiangVien";
            this.rdbtnGiangVien.Size = new System.Drawing.Size(131, 23);
            this.rdbtnGiangVien.TabIndex = 0;
            this.rdbtnGiangVien.TabStop = true;
            this.rdbtnGiangVien.Text = "GIẢNG VIÊN";
            this.rdbtnGiangVien.UseVisualStyleBackColor = true;
            this.rdbtnGiangVien.CheckedChanged += new System.EventHandler(this.rdbtnGiangVien_CheckedChanged);
            // 
            // rdbtnSinhVien
            // 
            this.rdbtnSinhVien.AutoSize = true;
            this.rdbtnSinhVien.Location = new System.Drawing.Point(696, 176);
            this.rdbtnSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnSinhVien.Name = "rdbtnSinhVien";
            this.rdbtnSinhVien.Size = new System.Drawing.Size(114, 23);
            this.rdbtnSinhVien.TabIndex = 1;
            this.rdbtnSinhVien.TabStop = true;
            this.rdbtnSinhVien.Text = "SINH VIÊN";
            this.rdbtnSinhVien.UseVisualStyleBackColor = true;
            this.rdbtnSinhVien.CheckedChanged += new System.EventHandler(this.rdbtnSinhVien_CheckedChanged);
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCoSo.Location = new System.Drawing.Point(254, 229);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(79, 23);
            this.lbCoSo.TabIndex = 2;
            this.lbCoSo.Text = "CƠ SỞ:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhau.Location = new System.Drawing.Point(254, 364);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(124, 23);
            this.lbMatKhau.TabIndex = 3;
            this.lbMatKhau.Text = "MẬT KHẨU:";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(254, 297);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(129, 23);
            this.lbTaiKhoan.TabIndex = 4;
            this.lbTaiKhoan.Text = "TÀI KHOẢN:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(450, 360);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(340, 27);
            this.txtMatKhau.TabIndex = 6;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(450, 293);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(340, 27);
            this.txtTaiKhoan.TabIndex = 7;
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(450, 226);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(340, 27);
            this.cbbCoSo.TabIndex = 8;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(562, 412);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(118, 37);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1666, 821);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.cbbCoSo);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbCoSo);
            this.Controls.Add(this.rdbtnSinhVien);
            this.Controls.Add(this.rdbtnGiangVien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnGiangVien;
        private System.Windows.Forms.RadioButton rdbtnSinhVien;
        private System.Windows.Forms.Label lbCoSo;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Button btnDangNhap;
    }
}