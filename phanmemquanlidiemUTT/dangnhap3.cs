using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace phanmemquanlidiemUTT
{
    public partial class dangnhap3 : Form
    {
        //Khai báo đối tượng Commonconnect
        private CommonConnect cc = new CommonConnect();
        //Khai báo đối tượng SqlConnection
        private SqlConnection conn = null;
        public dangnhap3()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string select = "Select * From LOGIN where TenDN='" + txtTenDN.Text + "' and MatKhau='" + txtMatKhau.Text + "' and Quyen='Admin'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                mainform frm = new mainform();
                frm.Show();
                //frm.mnuDN.Enabled = false;
                this.Hide();


                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }

            else
            {
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                string select1 = "Select * From LOGIN where TenDN='" + txtTenDN.Text + "' and MatKhau='" + txtMatKhau.Text + "' and Quyen='Member'";
                SqlCommand cmd1 = new SqlCommand(select1, conn);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");

                    mainform frm = new mainform();
                    frm.Show();
                   // frm.MnuItemDanhMuc.Enabled = false;
                  //  frm.MnuItemDanhMuc.Enabled = false;
                   // frm.mnuItemQuanli.Enabled = false;
                    this.Hide();

                   // frm.mnuQuanlinguoidung.Enabled = false;

                   
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                cmd1.Dispose();
                reader1.Close();
                reader1.Dispose();

            }
        }

        private void dangnhap3_Load(object sender, EventArgs e)
        {
            // Mở kết nối
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open)
                cboName.Items.Add(SystemInformation.UserDomainName.ToString() + "\\SQLServer");
            cboName.Text = cboName.Items[0].ToString();
            string select = "select*from sys.servers";
        }
    }
}
