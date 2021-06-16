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
using System.Configuration;

namespace phanmemquanlidiemUTT
{
    public partial class dangnhap2 : Form
    {
        public dangnhap2()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string connections = ConfigurationManager.ConnectionStrings["phanmemquanlidiemUTT.Properties.Settings.UTTquanlisvConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);//khoi tao bien con de ket noi database su dung thu vien sqlClient
            try
            {
                con.Open();// mo ket noi den database
                string query = "SELECT * FROM LOGIN WHERE TenDN = '" + txtUserName.Text + "' AND MatKhau = '" + txtPassWord.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);//xac dinh thao tac can xu ly doi voi data
                SqlDataReader reader = cmd.ExecuteReader();//doc du lieu tu database
                if (reader.HasRows)//rows > 0
                {
                    reader.Read();
                    String LoaiDN = reader[6].ToString();//phan loai dang nhap
                    if (LoaiDN == "Admin")
                    {
                        MessageBox.Show("Đăng nhập thành công!!! (Admin)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainform.Quyen = "Admin";
                        this.Hide();
                        this.Close();
                    }
                    else if (LoaiDN == "Member")
                    {
                        MessageBox.Show("Đăng nhập thành công!!! (Member)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainform.Quyen = "Member";
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
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
