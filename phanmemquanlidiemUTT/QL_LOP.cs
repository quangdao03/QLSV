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

namespace phanmemquanlidiemUTT
{
    public partial class QL_LOP : Form
    {
        public QL_LOP()
        {
            InitializeComponent();

        }
        SqlConnection con;
        public void Hienthi()
        {
            string sqlSELECT = "SELECT *FROM LOP";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void QL_LOP_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string select2 = "Select * From LOP where MaLop='" + txtmalop.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtmalop.Text == "")
            {
                errorProvider1.SetError(txtmalop, "Mã Lớp trống !");
                txtmalop.Focus();
            }
            else if (cbmakhoa.Text == "")
            {
                errorProvider1.SetError(cbmakhoa, "Mã Khoa trống !");
                cbmakhoa.Focus();
            }
            else if (txttenlop.Text == "")
            {
                errorProvider1.SetError(txttenlop, "Tên Lớp Trống");
                txttenlop.Focus();
            }
            else if (reader2.Read())
            {
                MessageBox.Show("Mã Lớp " + txtmalop.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmalop.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                string sqlNhap = "INSERT INTO LOP VALUES (@MaLop, @MaKhoa, @TenLop)";
                SqlCommand cmd = new SqlCommand(sqlNhap, con);
                cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
                cmd.Parameters.AddWithValue("MaKhoa", cbmakhoa.Text);
                cmd.Parameters.AddWithValue("TenLop", txttenlop.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Mã Khoa " + txtmakhoa.Text + " đã tồn tại", "Thông báo");
                cmd.Dispose();
                Hienthi();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                string sqlSua = "UPDATE LOP SET MaKhoa = @MaKhoa, TenLop = @TenLop Where MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(sqlSua, con);
                cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
                cmd.Parameters.AddWithValue("MaKhoa", cbmakhoa.Text);
                cmd.Parameters.AddWithValue("TenLop", txttenlop.Text);
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
                string sqlXoa = "DELETE FROM LOP WHERE MaLop = @MaLop ";
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
                cmd.Parameters.AddWithValue("MaKhoa", cbmakhoa.Text);
                cmd.Parameters.AddWithValue("TenLop", txttenlop.Text);
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
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("text", dataGridView1.DataSource, "MaLop");
            cbmakhoa.DataBindings.Clear();
            cbmakhoa.DataBindings.Add("text", dataGridView1.DataSource, "MaKhoa");
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("text", dataGridView1.DataSource, "TenLop");
        }

        private void QL_LOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uTTquanlisvDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.uTTquanlisvDataSet.LOP);

        }
    }
}
