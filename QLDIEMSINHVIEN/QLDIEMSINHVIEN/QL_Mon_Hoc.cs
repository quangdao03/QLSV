using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDIEMSINHVIEN
{
    public partial class QL_Mon_Hoc : Form
    {
        public QL_Mon_Hoc()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void QL_Mon_Hoc_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-I4VNS42R\SQLEXPRESS;Initial Catalog=quanlydiemsinhvien;Integrated Security=True");
            con.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM tblMon";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void QL_Lop_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlNhap = "INSERT INTO tblMon VALUES(@MaMon, @TenMon, @MaGV, @HocKy, @MaKhoa  )";
            SqlCommand cmd = new SqlCommand(sqlNhap, con);
            cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
            cmd.Parameters.AddWithValue("MaKhoa", combomakhoa.Text);
            cmd.Parameters.AddWithValue("TenMon", txttenmon.Text);
            cmd.Parameters.AddWithValue("MaGV", txtmagv.Text);
            cmd.Parameters.AddWithValue("HocKy", txthocky.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE tblMon SET MaGV = @MaGV, TenMon = @TenMon, HocKy = @HocKy, MaKhoa = @MaKhoa WHERE MaMon = @MaMon";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
            cmd.Parameters.AddWithValue("MaKhoa", combomakhoa.Text);
            cmd.Parameters.AddWithValue("TenMon", txttenmon.Text);
            cmd.Parameters.AddWithValue("MaGV", txtmagv.Text);
            cmd.Parameters.AddWithValue("HocKy", txthocky.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE  tblMon WHERE MaMon = @MaMon";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
            cmd.Parameters.AddWithValue("MaKhoa", combomakhoa.Text);
            cmd.Parameters.AddWithValue("TenMon", txttenmon.Text);
            cmd.Parameters.AddWithValue("MaGV", txtmagv.Text);
            cmd.Parameters.AddWithValue("HocKy", txthocky.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
