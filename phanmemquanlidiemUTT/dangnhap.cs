using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace phanmemquanlidiemUTT
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush bush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(bush, rc);
            }
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            //string strUsername = txtUserName.Text.Trim();
            //string strPassWord = txtPassWord.Text.Trim();
            //string strErr = string.Empty;
            //if (strUsername == string.Empty)
            //    strErr = "Bạn vui lòng nhập tên đăng nhập";
            //if (strPassWord == string.Empty)
            //    strErr += "\n Bạn chưa nhập mật khẩu";
            //if (strErr != string.Empty)
            //{
            //    MessageBox.Show("Error:" + strErr);
            //    return;
            //}
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QHD64DQ\SQLEXPRESS;Initial Catalog=UTTquanlisv;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtUserName.Text;
                string mk = txtPassWord.Text;
                string sql = "select *from LOGIN where TenDN ='" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)//rows > 0
                {
                    reader.Read();
                    String LoaiDN = reader[6].ToString();//phan loai dang nhap
                    if (LoaiDN == "Admin     ")
                    {
                        MessageBox.Show("Đăng nhập thành công!!! (Admin)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainform.Quyen = "Admin     ";
                        this.Hide();
                        this.Close();
                    }
                    else if (LoaiDN == "Member      ")
                    {
                        MessageBox.Show("Đăng nhập thành công!!! (Member)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainform.Quyen = "Member      ";
                        this.Hide();
                        this.Close();
                    }
                    mainform frm = new mainform();
                    frm.ShowDialog();
                    cmd.Dispose();
                    reader.Dispose();

                }
                else
                {
                    if (txtUserName.Text == "" && txtPassWord.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập đầy đủ Tên đăng nhập và Mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserName.Text = "";
                        txtPassWord.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối ");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
