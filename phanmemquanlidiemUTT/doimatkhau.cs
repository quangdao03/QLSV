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
using System.Drawing.Drawing2D;

namespace phanmemquanlidiemUTT
{
    public partial class doimatkhau : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public doimatkhau()
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

        private void btOK_Click(object sender, EventArgs e)
        {
            string select2 = "Select * From LOGIN where TenDN='" + txtTentaikhoan.Text + "' and MatKhau='" + txtMatkhaucu.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtTentaikhoan.Text == "")
                errorProvider1.SetError(txtTentaikhoan, "Chưa nhập tên tài khoản !");
            else if (txtMatkhaucu.Text == "")
            {
                errorProvider1.SetError(txtMatkhaucu, "!");
                txtMatkhaucu.Focus();
            }
            else if (txtMatkhaumoi.Text == "")
            {
                errorProvider1.SetError(txtMatkhaumoi, "!");
                txtMatkhaumoi.Focus();
            }
            else if (txtXacnhanmatkhau.Text == "")
            {
                errorProvider1.SetError(txtXacnhanmatkhau, "!");
                txtXacnhanmatkhau.Focus();
            }
            else if (txtXacnhanmatkhau.Text != txtMatkhaumoi.Text)
                MessageBox.Show("Bạn nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (reader2.Read())
            {
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string update = "Update LOGIN Set MatKhau='" + txtMatkhaumoi.Text + "' where TenDN='" + txtTentaikhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
            }

            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại hoặc mật khẩu sai! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTentaikhoan.Focus();

            }
            cmd2.Dispose();
            reader2.Dispose();


        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
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
