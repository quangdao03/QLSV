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
    public partial class Form1 : Form
    {
        //Khai báo đối tượng Commonconnect
        private CommonConnect cc = new CommonConnect();

        //Khai báo đối tượng SqlConnection
        private SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void lOGINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uTTquanlisvDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uTTquanlisvDataSet.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.uTTquanlisvDataSet.LOGIN);

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
                   // mnuDN.Enabled = false;
                    //frm.MnuItemDanhMuc.Enabled = false;
                     // frm.mnuItemQuanli.Enabled = false;
                    this.Hide();
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

    }
    }
