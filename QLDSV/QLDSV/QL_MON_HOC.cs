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
    public partial class QL_MON_HOC : Form
    {
        public QL_MON_HOC()
        {
            InitializeComponent();
        }
        SqlConnection con;
        
        private void QL_MON_HOC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDiemsvDataSet.MON' table. You can move, or remove it, as needed.
            //this.mONTableAdapter.Fill(this.qLDiemsvDataSet.MON);
            String connection = ConfigurationManager.ConnectionStrings["QLDSV.Properties.Settings.UTTquanlisvConnectionString"].ConnectionString.ToString();
            con = new SqlConnection(connection);
            con.Open();
            Hienthi();
            this.LoadComboBox();
            this.bringding();
        }
        public void Hienthi()
        {
            string sqlSELECT = "SELECT *FROM MON";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        void LoadComboBox()
        {
            var cmd = new SqlCommand("SELECT MaKhoa FROM KHOA", con);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbmakhoa.DisplayMember = "MaKhoa";
            cbmakhoa.DataSource = dt;

        }
        private void QL_MON_HOC_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        private void txttenkhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select2 = "Select * From Mon where MaMon='" + txtmamon.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtmamon.Text == "")
            {
                errorProvider1.SetError(txtmamon, "Mã Môn trống !");
                txtmamon.Focus();
            }
            else if (txttenmon.Text == "")
            {
                errorProvider1.SetError(txttenmon, "Tên Môn Trống");
                txttenmon.Focus();
            }
            else if (txtDVHT.Text == "")
            {
                errorProvider1.SetError(txtDVHT, "Số DVHT Trống");
                txtDVHT.Focus();
            }
            else if (txtmagv.Text == "")
            {
                errorProvider1.SetError(txtmagv, "Mã GV  Trống");
                txtmagv.Focus();
            }
            else if (txthocky.Text == "")
            {
                errorProvider1.SetError(txthocky, "Học KỳTrống");
                txthocky.Focus();
            }
            else if (cbmakhoa.Text == "")
            {
                errorProvider1.SetError(cbmakhoa, "Tên Khoa Trống");
                cbmakhoa.Focus();
            }
            else if (reader2.Read())
            {
                MessageBox.Show("Mã môn " + txtmamon.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                string sqlNhap = "INSERT INTO MON VALUES (@MaMon, @TenMon, @SoDVHT, @MaGV, @HocKi, @MaKhoa)";
                SqlCommand cmd = new SqlCommand(sqlNhap, con);
                cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
                cmd.Parameters.AddWithValue("TenMon", txttenmon.Text);
                cmd.Parameters.AddWithValue("SoDVHT", txtDVHT.Text);
                cmd.Parameters.AddWithValue("MaGV", txtmagv.Text);
                cmd.Parameters.AddWithValue("HocKi", txthocky.Text);
                cmd.Parameters.AddWithValue("MaKhoa", cbmakhoa.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmd.Dispose();
                Hienthi();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                string sqlSua = "UPDATE MON SET TenMon = @TenMon, SoDVHT = @SoDVHT, MaGV = @MaGV, HocKi = @HocKi, MaKhoa = @MaKhoa Where MaMon = @MaMon";
                SqlCommand cmd = new SqlCommand(sqlSua, con);
                cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
                cmd.Parameters.AddWithValue("TenMon", txttenmon.Text);
                cmd.Parameters.AddWithValue("SoDVHT", txtDVHT.Text);
                cmd.Parameters.AddWithValue("MaGV", txtmagv.Text);
                cmd.Parameters.AddWithValue("HocKi", txthocky.Text);
                cmd.Parameters.AddWithValue("MaKhoa", cbmakhoa.Text);
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
                string sqlXoa = "DELETE FROM MON WHERE MaMon = @MaMon ";
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
                cmd.Parameters.AddWithValue("TenMon", txttenmon.Text);
                cmd.Parameters.AddWithValue("SoDVHT", txtDVHT.Text);
                cmd.Parameters.AddWithValue("MaGV", txtmagv.Text);
                cmd.Parameters.AddWithValue("HocKi", txthocky.Text);
                cmd.Parameters.AddWithValue("MaKhoa", cbmakhoa.Text);
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
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("text", dataGridView1.DataSource, "MaMon");
            cbmakhoa.DataBindings.Clear();
            cbmakhoa.DataBindings.Add("text", dataGridView1.DataSource, "MaKhoa");
            txttenmon.DataBindings.Clear();
            txttenmon.DataBindings.Add("text", dataGridView1.DataSource, "TenMon");
            txtDVHT.DataBindings.Clear();
            txtDVHT.DataBindings.Add("text", dataGridView1.DataSource, "SoDVHT");
            txtmagv.DataBindings.Clear();
            txtmagv.DataBindings.Add("text", dataGridView1.DataSource, "MaGV");
            txthocky.DataBindings.Clear();
            txthocky.DataBindings.Add("text", dataGridView1.DataSource, "HocKi");
        }
    }
  }
