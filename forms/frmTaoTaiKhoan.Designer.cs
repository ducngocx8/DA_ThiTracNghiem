namespace CSDLPT_TN.forms
{
    partial class frmTaoTaiKhoan
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
            this.cbbGVSV = new System.Windows.Forms.ComboBox();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtCoSo = new System.Windows.Forms.RadioButton();
            this.rdbtGiangVien = new System.Windows.Forms.RadioButton();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.lbNhom = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbGVSV
            // 
            this.cbbGVSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGVSV.FormattingEnabled = true;
            this.cbbGVSV.Location = new System.Drawing.Point(699, 130);
            this.cbbGVSV.Name = "cbbGVSV";
            this.cbbGVSV.Size = new System.Drawing.Size(279, 27);
            this.cbbGVSV.TabIndex = 0;
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.AutoSize = true;
            this.lbDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSach.Location = new System.Drawing.Point(367, 131);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(326, 22);
            this.lbDanhSach.TabIndex = 1;
            this.lbDanhSach.Text = "Danh sách giảng viên chưa có tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(837, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHỌN GIẢNG VIÊN TRONG DANH SÁCH ĐỂ TẠO TÀI KHOẢN";
            // 
            // rdbtCoSo
            // 
            this.rdbtCoSo.AutoSize = true;
            this.rdbtCoSo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtCoSo.Location = new System.Drawing.Point(699, 176);
            this.rdbtCoSo.Name = "rdbtCoSo";
            this.rdbtCoSo.Size = new System.Drawing.Size(81, 23);
            this.rdbtCoSo.TabIndex = 3;
            this.rdbtCoSo.TabStop = true;
            this.rdbtCoSo.Text = "CƠ SỞ";
            this.rdbtCoSo.UseVisualStyleBackColor = true;
            // 
            // rdbtGiangVien
            // 
            this.rdbtGiangVien.AutoSize = true;
            this.rdbtGiangVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtGiangVien.Location = new System.Drawing.Point(847, 177);
            this.rdbtGiangVien.Name = "rdbtGiangVien";
            this.rdbtGiangVien.Size = new System.Drawing.Size(131, 23);
            this.rdbtGiangVien.TabIndex = 4;
            this.rdbtGiangVien.TabStop = true;
            this.rdbtGiangVien.Text = "GIẢNG VIÊN";
            this.rdbtGiangVien.UseVisualStyleBackColor = true;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(699, 222);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(279, 27);
            this.txtTenTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(699, 282);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(279, 27);
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu:";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Gold;
            this.btnTao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.Black;
            this.btnTao.Location = new System.Drawing.Point(775, 324);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(118, 37);
            this.btnTao.TabIndex = 10;
            this.btnTao.Text = "TẠO";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // lbNhom
            // 
            this.lbNhom.AutoSize = true;
            this.lbNhom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhom.Location = new System.Drawing.Point(367, 177);
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(63, 22);
            this.lbNhom.TabIndex = 11;
            this.lbNhom.Text = "Nhóm:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(12, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 37);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1716, 619);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbNhom);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.rdbtGiangVien);
            this.Controls.Add(this.rdbtCoSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.cbbGVSV);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "Tạo tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbGVSV;
        private System.Windows.Forms.Label lbDanhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbtCoSo;
        private System.Windows.Forms.RadioButton rdbtGiangVien;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label lbNhom;
        private System.Windows.Forms.Button btnThoat;
    }
}