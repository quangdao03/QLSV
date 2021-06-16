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
using System.Drawing.Drawing2D;

namespace UTTquanlisv
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            datagrid();
        }
        SqlConnection con;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uTTquanlisvDataSet.GIANG_VIEN' table. You can move, or remove it, as needed.
            this.gIANG_VIENTableAdapter.Fill(this.uTTquanlisvDataSet.GIANG_VIEN);
            con = new SqlConnection("Data Source=LAPTOP-O7FU2P67;Initial Catalog=UTTquanlisv;Integrated Security=True");
            con.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT * FROM GIANG_VIEN";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO GIANG_VIEN VALUES(@MaGV,@TenGV,@GioiTinh,@DienThoai,@Email,@PhanLoaiGV)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaGV", giangvien.Text);
            cmd.Parameters.AddWithValue("TenGV", txthoten.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtdienthoai.Text);
            cmd.Parameters.AddWithValue("Email", txtemail.Text);
            cmd.Parameters.AddWithValue("PhanLoaiGV", txtphanloai.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE GIANG_VIEN SET TenGV = @TenGV,GioiTinh=@GioiTinh,DienThoai=@DienThoai,Email=@Email,PhanLoaiGV=@PhanLoaiGV WHERE MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaGV", giangvien.Text);
            cmd.Parameters.AddWithValue("TenGV", txthoten.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtdienthoai.Text);
            cmd.Parameters.AddWithValue("Email", txtemail.Text);
            cmd.Parameters.AddWithValue("PhanLoaiGV", txtphanloai.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM  GIANG_VIEN WHERE MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaGV", giangvien.Text);
            cmd.Parameters.AddWithValue("TenGV", txthoten.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtdienthoai.Text);
            cmd.Parameters.AddWithValue("Email", txtemail.Text);
            cmd.Parameters.AddWithValue("PhanLoaiGV", txtphanloai.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        public void datagrid()
        {
            DataTable dt = new DataTable();
            App_Config configdb = new App_Config();
            String sql = " SELECT MaGV, TenGV,DienThoai,Email,PhanLoaiGV";
            sql += " Convert(varchar, NgaySinh, 103) as NgaySinh,";
            sql += " CASE When GioiTinh= 'False' Then N'Nữ'";
            sql += " When GioiTinh='True' Then 'Nam'";
            sql += " END as GioiTinh,";
            dt = configdb.SelectDb(sql);

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaGV";
            column.HeaderText = "Mã giảng viên";
            dataGridView1.Columns.Add(column);
            //cột 2 với fields là HoTen
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "TenGV";
            column2.HeaderText = "Giảng viên";
            dataGridView1.Columns.Add(column2);
            // cột 3 với fields là NgaySinh
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "GioiTinh";
            column3.HeaderText = "Giới tính";
            dataGridView1.Columns.Add(column3);
            //cột 4 với fields là Giới tính
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "DienThoai";
            column4.HeaderText = "Điện Thoại";
            dataGridView1.Columns.Add(column4);
            // cột 5 là DiaChi
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "Email";
            column5.HeaderText = "Email";
            dataGridView1.Columns.Add(column5);
            //Cột 6 là DienThoai
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "PhanLoaiGV";
            column6.HeaderText = "Đánh giá";

            dataGridView1.Columns.Add(column6);

            dataGridView1.DataSource = dt;
        }
    }
}
