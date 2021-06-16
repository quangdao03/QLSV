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
    public partial class QL_Lop : Form
    {
        public QL_Lop()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QL_Lop_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-I4VNS42R\SQLEXPRESS;Initial Catalog=sinhvien;Integrated Security=True");
            con.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM lop";
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
            string sqlNhap = "INSERT INTO Lop VALUES(@MaLop, @MaKhoa, @TenLop)";
            SqlCommand cmd = new SqlCommand(sqlNhap, con);
            cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
            cmd.Parameters.AddWithValue("MaKhoa", combomakhoa.Text);
            cmd.Parameters.AddWithValue("TenLop", txttenlop.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE  lop WHERE MaLop = @MaLop";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaKhoa", combomakhoa.Text);
            cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
            cmd.Parameters.AddWithValue("TenLop", txttenlop.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE lop SET MaKhoa = @MaKhoa, TenLop = @TenLop WHERE MaLop = @MaLop";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaKhoa", combomakhoa.Text);
            cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
            cmd.Parameters.AddWithValue("TenLop", txttenlop.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(f == DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
