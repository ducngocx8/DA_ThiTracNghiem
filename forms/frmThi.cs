using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_TN.forms
{
    public partial class frmThi : Form
    {
        private bool isSinhVien;
        private CauHoiItem[] listCauHoi;
        public static bool checkDangThi = false;
        public int index = 0;
        private int soCauThi = 0;
        private int thoigianThi = 0;
        private int s = 0;
        private DateTime ngayThi;
        int dem = 0;
        private double diemThi = 0.0;
        private String maSVTHI = Program.username;
        public frmThi()
        {
            InitializeComponent();
            // Program.mGroup = "SINHVIEN";
            // Program.mGroup = "GIANGVIEN";
        }

        private void frmThi_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dsTN.BANGDIEM' table. You can move, or remove it, as needed.
            dsTN.EnforceConstraints = false;
            this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.dsTN.BANGDIEM);
            pnBatDau.Visible = false;
            cbbLanThi.Items.Add(1);
            cbbLanThi.Items.Add(2);
            if (cbbLanThi.Items.Count > 0)
            {
                cbbLanThi.SelectedIndex = 1;
            }

            DataTable data_lop = new DataTable();
            DataTable data_monhoc = new DataTable();
            if (Program.mGroup.Equals("SINHVIEN"))
            {
                isSinhVien = true;
                txtMaLop.Visible = true;
                cbbLop.Visible = false;
                try
                {
                    data_lop = Program.ExecSqlDataTable("EXEC SP_TraCuuLop '" + maSVTHI + "'");
                    foreach (DataRow row in data_lop.Rows)
                    {
                        txtTenLop.Text = row["TENLOP"].ToString();
                        txtMaLop.Text = row["MALOP"].ToString();
                        txtHoTen.Text = row["HOTEN"].ToString();
                    }

                    data_monhoc = Program.ExecSqlDataTable("EXEC SP_LayMonHocChuaThi '" + maSVTHI + "'");
                    cbbMonHoc.DataSource = data_monhoc;
                    cbbMonHoc.DisplayMember = "TENMH";
                    cbbMonHoc.ValueMember = "MAMH";
                    if (cbbMonHoc.Items.Count == 0)
                    {
                        XtraMessageBox.Show("Hiện tại chưa có môn thi nào được đăng ký!", "THÔNG BÁO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        cbbMonHoc.SelectedIndex = 0;
                    }

                    loadThongTinThi();
                }
                catch { }
                
            }
            else
            {
                isSinhVien = false;
                cbbLop.Visible = true;
                txtMaLop.Visible = false;
                txtMaLop.Enabled = false;
                lbTenLop.Visible = false;
                txtTenLop.Visible = false;
                lbHoTen.Text = "Hệ thống thi thử";
                txtHoTen.Text = "";

                // Lấy các lớp có giáo viên đăng ký thi
                data_lop = Program.ExecSqlDataTable("SELECT DISTINCT LOP.MALOP, TENLOP FROM LOP JOIN GIAOVIEN_DANGKY ON LOP.MALOP = GIAOVIEN_DANGKY.MALOP");
                cbbLop.DataSource = data_lop;
                cbbLop.DisplayMember = "TENLOP";
                cbbLop.ValueMember = "MALOP";
                if (cbbLop.Items.Count <= 0)
                {
                    XtraMessageBox.Show("Hiện tại chưa có lớp nào đăng ký thi!", "THÔNG BÁO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenLop.Text = "";
                    return;
                }
                else
                {
                    cbbLop.SelectedIndex = 0;
                    txtTenLop.Text = cbbLop.Text;
                }
                String cbbLopCurrentValue = cbbLop.SelectedValue.ToString().Trim();
                data_monhoc = Program.ExecSqlDataTable("SELECT DISTINCT dbo.MONHOC.MAMH, dbo.MONHOC.TENMH FROM MONHOC JOIN GIAOVIEN_DANGKY ON GIAOVIEN_DANGKY.MAMH = MONHOC.MAMH AND GIAOVIEN_DANGKY.MALOP = '" + cbbLopCurrentValue + "'");
                cbbMonHoc.DataSource = data_monhoc;
                cbbMonHoc.DisplayMember = "TENMH";
                cbbMonHoc.ValueMember = "MAMH";
                if (cbbMonHoc.Items.Count <= 0)
                {
                    XtraMessageBox.Show("Hiện tại chưa có môn học nào thuộc lớp " + cbbLop.SelectedValue.ToString() + " đăng ký thi!", "THÔNG BÁO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    cbbMonHoc.SelectedIndex = 0;
                }
                loadThongTinThi();

            }
            dem++;
        }

        public bool kiemTraDaThiChua()
        {
            string sql = "EXEC SP_KiemTraDaThiChua '" + maSVTHI + "', '" + cbbMonHoc.SelectedValue.ToString().Trim() + "', " +
                int.Parse(cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString());
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null)
            {
                return false;
            }
            if (Program.myReader.Read())
            {
                if (Program.myReader.GetInt32(0) == 1)
                {
                    XtraMessageBox.Show("Môn học này bạn đã thi, không thể thi lại!", "THÔNG BÁO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    Program.conn.Close();
                    txtTrinhDo.Text = "X";
                    txtSoCauHoi.Text = "0 câu";
                    txtThoiGianThi.Text = "0 phút";
                    txtLanThi.Text = "X";
                    txtTenMonHoc.Text = "X";
                    return false;
                }
            }
            Program.myReader.Close();
            Program.conn.Close();
            return true;

        }

        private Boolean loadThongTinThi()
        {
            pnBatDau.Visible = false;
            string sql = "";
            if (isSinhVien == true)
            {
                if (txtMaLop.Text.Trim().Equals(""))
                {
                    XtraMessageBox.Show("Mã lớp sinh viên rỗng, vui lòng chọn lại...!", "THÔNG BÁO",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cbbMonHoc.SelectedValue.ToString().Trim().Equals(""))
                {
                    XtraMessageBox.Show("Môn học sinh viên rỗng, vui lòng chọn lại...!", "THÔNG BÁO",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim().Equals(""))
                {
                    XtraMessageBox.Show("Chưa chọn lần thi, vui lòng chọn lại...!", "THÔNG BÁO",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                sql += "exec SP_ThongTinLanThi N'"
                    + txtMaLop.Text + "', N'"
                    + cbbMonHoc.SelectedValue.ToString() + "', "
                    + cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim();
            }
            else
            {
                if (cbbLop.SelectedValue.ToString().Trim().Equals(""))
                {
                    XtraMessageBox.Show("Mã lớp thi thử rỗng, vui lòng chọn lại...!", "THÔNG BÁO",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cbbMonHoc.SelectedValue.ToString().Trim().Equals(""))
                {
                    XtraMessageBox.Show("Môn học thi thử rỗng, vui lòng chọn lại...!", "THÔNG BÁO",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim().Equals(""))
                {
                    XtraMessageBox.Show("Lần thi thi thử rỗng, vui lòng chọn lại...!", "THÔNG BÁO",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                sql = "exec SP_ThongTinLanThi N'"
                    + cbbLop.SelectedValue.ToString().Trim() + "', N'"
                    + cbbMonHoc.SelectedValue.ToString() + "', "
                    + cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim();
            }


            try
            {
                Program.myReader = Program.ExecSqlDataReader(sql);
                if (Program.myReader == null)
                {
                    return false;
                }
                else
                {
                    if (Program.myReader.Read())
                    {
                        txtTrinhDo.Text = Program.myReader.GetString(0);
                        soCauThi = Program.myReader.GetInt16(1);
                        txtSoCauHoi.Text = soCauThi.ToString() + " câu hỏi";
                        thoigianThi = Program.myReader.GetInt16(2);
                        txtThoiGianThi.Text = thoigianThi.ToString() + " phút";
                        lbTime.Text = thoigianThi.ToString() + " : 00";
                        dtNgayThi.DateTime = ngayThi = Program.myReader.GetDateTime(3);
                        txtLanThi.Text = cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim();
                        txtTenMonHoc.Text = cbbMonHoc.SelectedValue.ToString().Trim();
                        Program.myReader.Close();
                        Program.conn.Close();
                        if(dtNgayThi.DateTime.Date != DateTime.Now.Date)
                        {
                            pnBatDau.Visible = false;
                            btnBatDauThi.Visible = false;
                        }
                        else
                        {
                            pnBatDau.Visible = true;
                            btnBatDauThi.Visible = true;
                        }
                        return true;
                    }
                    else
                    {
                        txtTrinhDo.Text = "X";
                        txtSoCauHoi.Text = "0 câu";
                        txtThoiGianThi.Text = "0 phút";
                        txtLanThi.Text = "X";
                        txtTenMonHoc.Text = "X";
                        pnBatDau.Visible = false;
                        XtraMessageBox.Show("Không tìm thấy thông tin môn học đã đăng ký thi của lớp!", "THÔNG BÁO",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.conn.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi kết nối lấy thông tin ca thi!", "THÔNG BÁO",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }


        public void loadCauHoi()
        {
             string sql = "exec SP_LayCauHoi '"
                + cbbMonHoc.SelectedValue.ToString().Trim() + "', '"
                 + txtTrinhDo.Text.Trim() + "', "
                + soCauThi.ToString().Trim();


            DataTable data_baithi = Program.ExecSqlDataTable(sql);
            if (data_baithi == null)
            {
                XtraMessageBox.Show("Không thể lấy được đề thi...!", "THÔNG BÁO",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTrinhDo.Text = "X";
                txtSoCauHoi.Text = "0 câu";
                txtThoiGianThi.Text = "0 phút";
                txtLanThi.Text = "X";
                txtTenMonHoc.Text = "X";
                return;
            }
            bdsBaiThi.DataSource = Program.ExecSqlDataTable(sql);
            if ((int)(((DataRowView)bdsBaiThi[0])["CauHoi"]) == -1)
            {
                XtraMessageBox.Show("Không đủ số câu hỏi để thi...", "THÔNG BÁO",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnBatDau.Visible = false;
                txtTrinhDo.Text = "X";
                txtSoCauHoi.Text = "0 câu";
                txtThoiGianThi.Text = "0 phút";
                txtLanThi.Text = "X";
                txtTenMonHoc.Text = "X";
                return;
            }
            cbbLop.Enabled = cbbMonHoc.Enabled = cbbLanThi.Enabled = false;
            timerThi.Start();
            checkDangThi = true;
            btnBatDauThi.Enabled = false;
            btnNopBai.Enabled = true;
            listCauHoi = new CauHoiItem[soCauThi];
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                listCauHoi[i] = new CauHoiItem();
                listCauHoi[i].CauSo = i + 1;
                listCauHoi[i].IDBaiThi = (int)((DataRowView)bdsBaiThi[i])["CAUHOI"];
                Console.WriteLine("id cau hoi: " + listCauHoi[i].IDBaiThi);
                listCauHoi[i].NDCauHoi = ((DataRowView)bdsBaiThi[i])["NOIDUNG"].ToString();
                listCauHoi[i].CauA = ((DataRowView)bdsBaiThi[i])["A"].ToString();
                listCauHoi[i].CauB = ((DataRowView)bdsBaiThi[i])["B"].ToString();
                listCauHoi[i].CauC = ((DataRowView)bdsBaiThi[i])["C"].ToString();
                listCauHoi[i].CauD = ((DataRowView)bdsBaiThi[i])["D"].ToString();
                listCauHoi[i].CauDapAn = ((DataRowView)bdsBaiThi[i])["DAP_AN"].ToString();
                listCauHoi[i].CauDaChon = "";
                listCauHoi[i].AutoSize = true;

                String[] arr = new string[2];
                arr[0] = (i + 1).ToString();
                arr[1] = listCauHoi[i].CauDaChon;

                ListViewItem baiThi = new ListViewItem(arr);
                Console.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].CauDapAn);
                this.listviewCauHoi.Items.Add(baiThi);
            }

            listCauHoi[index].Parent = pnCauHoi;
            pnBtnCauHoi.Visible = true;
            if (index == 0)
            {
                btnCauTruoc.Enabled = false;
            }


        }


        private void btnBatDauThi_Click(object sender, EventArgs e)
        {
            if (loadThongTinThi() == false) return;
            if (isSinhVien == true)
            {
                if (kiemTraDaThiChua() == false)
                {
                    return;
                }
                DateTime today = DateTime.Today;
                if (today.CompareTo(ngayThi.Date) != 0)
                {
                    XtraMessageBox.Show("Chưa đến ngày thi, vui lòng quay lại sau!", "THÔNG BÁO",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            lbTG.Visible = lbTime.Visible = true;
            // load câu hỏi thi
            loadCauHoi();
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dem > 0)
                {
                    loadThongTinThi();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dem > 0)
                {
                    loadThongTinThi();
                }
            }
            catch (Exception)
            {

            }
        }

        public void tinhDiem()
        {
            double soCauDung = 0.0;
            double diemMoiCau = 10 * 1.0 / soCauThi;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].CauDaChon.Equals(listCauHoi[i].CauDapAn) == true)
                {
                    soCauDung++;
                }
            }
            diemThi = (double) (soCauDung * 1.0 * (double) diemMoiCau);
            diemThi = Math.Round(diemThi);
            XtraMessageBox.Show("Bạn làm đúng " + soCauDung + "/" + soCauThi + " và đạt " + diemThi + " điểm.", "KẾT QUẢ THI",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            index = 0;
            s = 0;
            btnCauTruoc.Enabled = false;
            btnCauSau.Enabled = true;
        }

        public void capNhatDapAnDaChon(int cauSo, string daChon)
        {
            string[] arr = new string[2];
            arr[0] = (cauSo).ToString();
            arr[1] = daChon;
            ListViewItem baiThi = new ListViewItem(arr);
            listviewCauHoi.Items[cauSo - 1] = baiThi;
        }

        private void timerThi_Tick(object sender, EventArgs e)
        {
            if (s < 10)
            {
                lbTime.Text = thoigianThi.ToString() + " : 0" + s.ToString();
            }
            else
            {
                lbTime.Text = thoigianThi.ToString() + " : " + s.ToString();
            }

            if (thoigianThi == 0 && s == 0)
            {
                timerThi.Stop(); //ĐANG TEST
                XtraMessageBox.Show("Thời gian thi đã hết, nhấn OKE để xem điểm của bạn!", "THI ĐÃ XONG",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                tinhDiem();
                if (isSinhVien == true)
                {
                    ghiKetQuaThi();
                    cbbMonHoc.DataSource = Program.ExecSqlDataTable("EXEC SP_LayMonHocChuaThi '" + maSVTHI + "'");
                }
                btnNopBai.Enabled = false;
                pnCauHoi.Controls.Clear();
                pnBatDau.Visible = false;
                btnBatDauThi.Enabled = true;
                listviewCauHoi.Items.Clear();
                cbbLanThi.Enabled = cbbMonHoc.Enabled = true;
                if (isSinhVien != true)
                {
                    cbbLop.Enabled = true;
                }
                pnBtnCauHoi.Visible = false;
                index = 0;
                return;
            }
            else if (s == 0)
            {
                s = 59;
                thoigianThi--;
            }
            else
            {
                s--;
            }

        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index--;
                pnCauHoi.Controls.Clear();
                listCauHoi[index].Parent = pnCauHoi;
                if (index == 0)
                {
                    btnCauTruoc.Enabled = false;
                }
                else
                {
                    btnCauSau.Enabled = true;
                }
            }
        }

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            if (index < soCauThi - 1)
            {
                index++;
                pnCauHoi.Controls.Clear();
                listCauHoi[index].Parent = pnCauHoi;
                if (index == soCauThi - 1)
                {
                    btnCauSau.Enabled = false;
                }
                else
                {
                    btnCauTruoc.Enabled = true;
                }
            }
        }

        public void ghiKetQuaThi()
        {
            string toDate = DateTime.Now.ToString("ddMMyyyy");
            string maMH = cbbMonHoc.SelectedValue.ToString().Trim();
            string lanThi = cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim();
            string baithi = maMH + maSVTHI + lanThi + toDate; // => CSDL001180520221
            DataRowView newRow = (DataRowView)bdsBangDiem.AddNew();

            newRow.Row.ItemArray = new object[]
            {maSVTHI, maMH, int.Parse(lanThi), dtNgayThi.DateTime, diemThi, baithi};

          //  this.bdsBangDiem.EndEdit();
         //   this.bdsBangDiem.ResetCurrentItem();
          //  this.BANGDIEMTableAdapter.Update(this.dsTN.BANGDIEM);

            DataTable data_temp = new DataTable();
            data_temp.Columns.Add("BAITHI", typeof(string));
            data_temp.Columns.Add("CAUHOI", typeof(int));
            data_temp.Columns.Add("STT", typeof(int));
            data_temp.Columns.Add("DACHON", typeof(string));


            DataTable data_temp_diem = new DataTable();
            data_temp_diem.Columns.Add("MASV", typeof(string));
            data_temp_diem.Columns.Add("MAMH", typeof(string));
            data_temp_diem.Columns.Add("LAN", typeof(int));
            data_temp_diem.Columns.Add("NGAYTHI", typeof(DateTime));
            data_temp_diem.Columns.Add("DIEM", typeof(float));
            data_temp_diem.Columns.Add("BAITHI", typeof(string));

            data_temp_diem.Rows.Add(maSVTHI, maMH, lanThi, dtNgayThi.DateTime, diemThi ,baithi);



            for (int i = 0; i < listCauHoi.Length; i++)
            {
                data_temp.Rows.Add(baithi, listCauHoi[i].IDBaiThi, i + 1, listCauHoi[i].CauDaChon);
            }
            try
            {
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_BAITHI";
                para.ParameterName = "@CAUHOITHI";
                para.Value = data_temp;


                SqlParameter para_diem = new SqlParameter();
                para_diem.SqlDbType = SqlDbType.Structured;
                para_diem.TypeName = "dbo.TYPE_DIEM";
                para_diem.ParameterName = "@DIEMTHI";
                para_diem.Value = data_temp_diem;

                Program.KetNoi();
                SqlCommand sqlCommand = new SqlCommand("SP_INSERT_BAITHI", Program.conn);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(para);
                sqlCommand.Parameters.Add(para_diem);
                sqlCommand.ExecuteNonQuery();
                XtraMessageBox.Show("Ghi kết quả thành công!", "Thành công",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi xảy ra trong quá trình ghi kết quả! " + e, "ERROR",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Chưa hết thời gian!\n" +
                                                "Bạn chắc chắn muốn nộp bài thi?", "QUESTION",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                timerThi.Stop();
                tinhDiem();
                if (isSinhVien == true)
                {
                    ghiKetQuaThi();
                    cbbMonHoc.DataSource = Program.ExecSqlDataTable("EXEC SP_LayMonHocChuaThi '" + maSVTHI + "'");
                }
                pnCauHoi.Controls.Clear();
                btnNopBai.Enabled = false;
                btnBatDauThi.Enabled = true;
                pnBatDau.Visible = false;
                listviewCauHoi.Items.Clear();
                pnBtnCauHoi.Visible = false;
                index = 0;
                cbbLanThi.Enabled = cbbMonHoc.Enabled = true;
                if (isSinhVien != true)
                {
                    cbbLop.Enabled = true;
                }
            }
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dem > 0)
            {
                String cbbLopCurrentValue = cbbLop.SelectedValue.ToString();
                cbbMonHoc.DataSource = Program.ExecSqlDataTable("SELECT DISTINCT dbo.MONHOC.MAMH, dbo.MONHOC.TENMH FROM MONHOC JOIN GIAOVIEN_DANGKY ON GIAOVIEN_DANGKY.MAMH = MONHOC.MAMH AND GIAOVIEN_DANGKY.MALOP = '" + cbbLopCurrentValue + "'");
                if (isSinhVien == false)
                {
                    txtTenLop.Text = cbbLop.SelectedValue.ToString();
                }
            }


        }
    }
}
