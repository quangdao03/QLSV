using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace phanmemquanlidiemUTT
{
    public partial class quanlithongtinsv : Form
    {
        public quanlithongtinsv()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO SINH_VIEN VALUES(@MaSv,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaLop)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaSv", txtmsv.Text);
            cmd.Parameters.AddWithValue("HoTen", txthoten.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimengaysinh.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE SINH_VIEN SET HoTen = @HoTen,NgaySinh = @NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,MaLop=@MaLop WHERE MaSv = @MaSv";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaSv", txtmsv.Text);
            cmd.Parameters.AddWithValue("HoTen", txthoten.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimengaysinh.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM  SINH_VIEN WHERE MaSv = @MaSv";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaSv", txtmsv.Text);
            cmd.Parameters.AddWithValue("HoTen", txthoten.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimengaysinh.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT * FROM SINH_VIEN";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sqlTimkiem = "SELECT * FROM  SINH_VIEN WHERE MaSv = @MaSv";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, con);
            cmd.Parameters.AddWithValue("MaSv", txttimkiem.Text);
            cmd.Parameters.AddWithValue("HoTen", txthoten.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimengaysinh.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("MaLop", txtmalop.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void quanlithongtinsv_Load(object sender, EventArgs e)
        {
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            con = new SqlConnection("Data Source=DESKTOP-QHD64DQ-SQLEXPRESS;Initial Catalog=UTTquanlisv;Integrated Security=True");
            con.Open();
            Hienthi();
        }
    }
}
