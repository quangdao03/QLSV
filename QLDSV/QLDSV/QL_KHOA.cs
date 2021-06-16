using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace QLDSV
{
    public partial class QL_KHOA : Form
    {
        public QL_KHOA()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void QL_KHOA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDiemsvDataSet.KHOA' table. You can move, or remove it, as needed.
           // this.kHOATableAdapter.Fill(this.qLDiemsvDataSet.KHOA);
            String connection = ConfigurationManager.ConnectionStrings["QLDSV.Properties.Settings.UTTquanlisvConnectionString"].ConnectionString.ToString();
            con = new SqlConnection(connection);
            con.Open();
            Hienthi();
            this.bringding();

        }
        public void Hienthi()
        {
            string sqlSELECT = "SELECT *FROM KHOA";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select2 = "Select * From KHOA where MaKhoa='" + txtmakhoa.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtmakhoa.Text == "")
            {
                errorProvider1.SetError(txtmakhoa, "Mã Khoa trống !");
                txtmakhoa.Focus();
            }
            else if (txttenkhoa.Text == "")
            {
                errorProvider1.SetError(txttenkhoa, "Tên Khoa Trống");
                txttenkhoa.Focus();
            }
            else if (reader2.Read())
            {
                MessageBox.Show("Mã Khoa " + txtmakhoa.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhoa.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                string sqlNhap = "INSERT INTO KHOA VALUES (@MaKhoa, @TenKhoa)";
                SqlCommand cmd = new SqlCommand(sqlNhap, con);
                cmd.Parameters.AddWithValue("MaKhoa", txtmakhoa.Text);
                cmd.Parameters.AddWithValue("TenKhoa", txttenkhoa.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Mã Khoa " + txtmakhoa.Text + " đã tồn tại", "Thông báo");
                cmd.Dispose();
                Hienthi();
            }
        }

        private void QL_KHOA_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                string sqlSua = "UPDATE KHOA SET TenKhoa = @TenKhoa Where MaKhoa = @MaKhoa";
                SqlCommand cmd = new SqlCommand(sqlSua, con);
                cmd.Parameters.AddWithValue("MaKhoa", txtmakhoa.Text);
                cmd.Parameters.AddWithValue("TenKhoa", txttenkhoa.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmd.Dispose();
                Hienthi();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                string sqlXoa = "DELETE FROM KHOA WHERE MaKhoa = @MaKhoa ";
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.Parameters.AddWithValue("MaKhoa", txtmakhoa.Text);
                cmd.Parameters.AddWithValue("TenKhoa", txttenkhoa.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Hienthi();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void bringding()
        {
            txtmakhoa.DataBindings.Clear();
            txtmakhoa.DataBindings.Add("text", dataGridView1.DataSource, "MaKhoa");
            txttenkhoa.DataBindings.Clear();
            txttenkhoa.DataBindings.Add("text", dataGridView1.DataSource, "TenKhoa");
        }
    }
}
    

