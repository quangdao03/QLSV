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
using System.Drawing.Drawing2D;

namespace phanmemquanlidiemUTT
{
    public partial class quanlinguoidung : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public quanlinguoidung()
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
        private void quanlinguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uTTquanlisvDataSet.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.uTTquanlisvDataSet.LOGIN);
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) 
            //Fill du lieu 
            FillDataGridView_Login();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string select2 = "Select * From LOGIN where TenDN='" + tenTaiKhoanTextBox.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (tenTaiKhoanTextBox.Text == "")
            {
                errorProvider1.SetError(tenTaiKhoanTextBox, "Tên tài khoản không  để trống !");
                tenTaiKhoanTextBox.Focus();
            }
            else if (matKhauTextBox.Text == "")
            {
                errorProvider1.SetError(matKhauTextBox, "Bạn chưa nhập mật khẩu !");
                matKhauTextBox.Focus();
            }
            else if (txtNhaplaimatkhau.Text == "")
            {
                errorProvider1.SetError(txtNhaplaimatkhau, "Bạn chưa nhập lại mật khẩu !");
                txtNhaplaimatkhau.Focus();
            }
            else if (txtNhaplaimatkhau.Text != txtNhaplaimatkhau.Text)

                MessageBox.Show("Bạn nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (reader2.Read())
            {
                MessageBox.Show("Tài khoản " + tenTaiKhoanTextBox.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tenTaiKhoanTextBox.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into LOGIN(TenDN,MatKhau,HoTen,Gioitinh,DienThoai,Email,Quyen)" +
                                "Values('" + tenTaiKhoanTextBox.Text + "','" + matKhauTextBox.Text + "',N'" + hoTenTextBox.Text + "',N'" + gioiTinhComboBox.Text + "','" +
                                dienThoaiTextBox.Text + "','" + emailTextBox.Text + "', '" + quyenComboBox.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();

            }
            // Trả tài nguyên
            cmd2.Dispose();
            reader2.Dispose();
            //Fill du lieu 
            FillDataGridView_Login();
        }
        public void FillDataGridView_Login()
        {
            // Thực hiện truy vấn
            string select = "Select * From LOGIN  ";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            lOGINDataGridView.DataSource = ds;
            lOGINDataGridView.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void lOGINDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tenTaiKhoanTextBox.Text = lOGINDataGridView.CurrentRow.Cells[0].Value.ToString();
            matKhauTextBox.Text = lOGINDataGridView.CurrentRow.Cells[1].Value.ToString();
            hoTenTextBox.Text = lOGINDataGridView.CurrentRow.Cells[2].Value.ToString();
            gioiTinhComboBox.Text = lOGINDataGridView.CurrentRow.Cells[3].Value.ToString();
            dienThoaiTextBox.Text = lOGINDataGridView.CurrentRow.Cells[4].Value.ToString();
            emailTextBox.Text = lOGINDataGridView.CurrentRow.Cells[5].Value.ToString();
            quyenComboBox.Text = lOGINDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            if (tenTaiKhoanTextBox.Text == "")
                errorProvider2.SetError(tenTaiKhoanTextBox, "Tên tài khoản không để trống!");
            else
            {

                string update = "Update LOGIN Set MatKhau=N'" + matKhauTextBox.Text + "',HoTen=N'" + hoTenTextBox.Text + "',GioiTinh=N'" +
                                gioiTinhComboBox.Text + "',DienThoai='" + dienThoaiTextBox.Text + "',Email='" +
                                emailTextBox.Text + "',Quyen=N'" + quyenComboBox.Text + "' where TenDN='" + tenTaiKhoanTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //Load lai du lieu
                FillDataGridView_Login();
                // Trả tài nguyên
                cmd.Dispose();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu

                SqlCommand cmd = new SqlCommand("delete from LOGIN where TenDN='" + tenTaiKhoanTextBox.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Fill du lieu 
                FillDataGridView_Login();
            }
        }

        private void btLammoi_Click(object sender, EventArgs e)
        {
            hoTenTextBox.ResetText();
            tenTaiKhoanTextBox.ResetText();
            gioiTinhComboBox.ResetText();
            dienThoaiTextBox.ResetText();
            quyenComboBox.ResetText();
            matKhauTextBox.ResetText();
            tenTaiKhoanTextBox.ResetText();
            txtNhaplaimatkhau.ResetText();
            emailTextBox.ResetText();
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
