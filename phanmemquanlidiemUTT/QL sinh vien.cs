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

namespace phanmemquanlidiemUTT
{
    public partial class QL_sinh_vien : Form
    {
        public QL_sinh_vien()
        {
            InitializeComponent();
            datagrid();
        }
        SqlConnection con;
        public void Hienthi()
        {
            string sqlSelect = "SELECT * FROM SINH_VIEN";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO SINH_VIEN VALUES(@MaSv,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaLop)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaSv", maSvTextBox.Text);
            cmd.Parameters.AddWithValue("HoTen", txthoten.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimengaysinh.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("MaLop", maLopTextBox.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void QL_sinh_vien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uTTquanlisvDataSet.SINH_VIEN' table. You can move, or remove it, as needed.
            this.sINH_VIENTableAdapter.Fill(this.uTTquanlisvDataSet.SINH_VIEN);
            // this.sINH_VIENTableAdapter.Fill(this.uTTquanlisvDataSet.SINH_VIEN);
            con = new SqlConnection("Data Source=DESKTOP-QHD64DQ\\SQLEXPRESS;Initial Catalog=UTTquanlisv;Integrated Security=True");
            con.Open();
            Hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE SINH_VIEN SET HoTen = @HoTen,NgaySinh = @NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,MaLop=@MaLop WHERE MaSv = @MaSv";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaSv", maSvTextBox.Text);
            cmd.Parameters.AddWithValue("HoTen", txthoten.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimengaysinh.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("MaLop", maLopTextBox.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM  SINH_VIEN WHERE MaSv = @MaSv";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaSv", maSvTextBox.Text);
            cmd.Parameters.AddWithValue("HoTen", txthoten.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimengaysinh.Text);
            cmd.Parameters.AddWithValue("GioiTinh", listBoxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("MaLop", maLopTextBox.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
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
            cmd.Parameters.AddWithValue("MaLop", maLopTextBox.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            //dataGridView1.Show();
        }
        public void datagrid()
        {
            DataTable dt = new DataTable();
            App_Config configdb = new App_Config();
            String sql = " SELECT MaSo, HoTen,DiaChi";
            sql += " Convert(varchar, NgaySinh, 103) as NgaySinh,";
            sql += " CASE When GioiTinh= 'False' Then N'Nữ'";
            sql += " When GioiTinh='True' Then 'Nam'";
            sql += " END as GioiTinh,";
            sql += " MaLop, Lop.MaLop";
            sql += " FROM Sinh_Vien";
            sql += " Inner join Lop on Lop.MaLop = Sinh_Vien.MaLop";
            dt = configdb.SelectDb(sql);

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaSv";
            column.HeaderText = "Mã sinh viên";
            dataGridView1.Columns.Add(column);
            //cột 2 với fields là HoTen
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "HoTen";
            column2.HeaderText = "Tên sinh viên";
            dataGridView1.Columns.Add(column2);
            // cột 3 với fields là NgaySinh
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "NgaySinh";
            column3.HeaderText = "Ngày sinh";
            dataGridView1.Columns.Add(column3);
            //cột 4 với fields là Giới tính
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "GioiTinh";
            column4.HeaderText = "Giới tính";
            dataGridView1.Columns.Add(column4);
            // cột 5 là DiaChi
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "DiaChi";
            column5.HeaderText = "Địa chỉ";
            dataGridView1.Columns.Add(column5);
            //Cột 6 là DienThoai
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "MaLop";
            column6.HeaderText = "Mã Lớp";

            dataGridView1.Columns.Add(column6);

            dataGridView1.DataSource = dt;
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

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
