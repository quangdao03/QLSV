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
    public partial class QL_Khoa : Form
    {
        public QL_Khoa()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlNhap = "INSERT INTO tblKHoa VALUES(@MaKhoa, @TenKhoa)";
            SqlCommand cmd = new SqlCommand(sqlNhap, con);
            cmd.Parameters.AddWithValue("MaKhoa", txtmakhoa.Text);
            cmd.Parameters.AddWithValue("TenKhoa", txttenkhoa.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void QL_Khoa_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-I4VNS42R\SQLEXPRESS;Initial Catalog=quanlydiemsinhvien;Integrated Security=True");
            con.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM tblKhoa";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE tblKHoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaKhoa", txtmakhoa.Text);
            cmd.Parameters.AddWithValue("TenKhoa", txttenkhoa.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE  tblKHoa WHERE MaKhoa = @MaKhoa";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaKhoa", txtmakhoa.Text);
            cmd.Parameters.AddWithValue("TenKhoa", txttenkhoa.Text);
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
