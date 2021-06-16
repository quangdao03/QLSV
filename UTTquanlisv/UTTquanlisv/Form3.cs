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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            datagrid();
        }
        SqlConnection con;

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uTTquanlisvDataSet.KET_QUA' table. You can move, or remove it, as needed.
            this.kET_QUATableAdapter.Fill(this.uTTquanlisvDataSet.KET_QUA);
            con = new SqlConnection("Data Source=LAPTOP-O7FU2P67;Initial Catalog=UTTquanlisv;Integrated Security=True");
            con.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT * FROM KET_QUA";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string sqlThem = "INSERT INTO KET_QUA VALUES(@MaSV,@HoTen,@MaLop,@MaMon,@DiemTB,@DiemThiLan1,@DiemTongKet,@HanhKiem,@HocKi,@GhiChu)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaSV", msv.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("MaLop", cboLop.Text);
            cmd.Parameters.AddWithValue("MaMon", cboMonHoc.Text);
            cmd.Parameters.AddWithValue("DiemTB", txtDiemTB.Text);
            cmd.Parameters.AddWithValue("DiemThiLan1", txtDiemThi1.Text);
            cmd.Parameters.AddWithValue("DiemTongKet", txtDiemTK.Text);
            cmd.Parameters.AddWithValue("HanhKiem", cboHanhKiem.Text);
            cmd.Parameters.AddWithValue("HocKi", cboHocKi.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE KET_QUA SET HoTen=@HoTen,MaLop=@MaLop,MaMon=@MaMon,DiemThiLan1=@DiemThiLan1,DiemTongKet=@DiemTongKet,HanhKiem=@HanhKiem,HocKi=@HocKi,GhiChu=@GhiChu WHERE MaSV = @MaSV ";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaSV", msv.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("MaLop", cboLop.Text);
            cmd.Parameters.AddWithValue("MaMon", cboMonHoc.Text);
            cmd.Parameters.AddWithValue("DiemTB", txtDiemTB.Text);
            cmd.Parameters.AddWithValue("DiemThiLan1", txtDiemThi1.Text);
            cmd.Parameters.AddWithValue("DiemTongKet", txtDiemTK.Text);
            cmd.Parameters.AddWithValue("HanhKiem", cboHanhKiem.Text);
            cmd.Parameters.AddWithValue("HocKi", cboHocKi.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            this.kET_QUATableAdapter.Fill(this.uTTquanlisvDataSet.KET_QUA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM  KET_QUA WHERE MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaSV", msv.Text);
            cmd.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("MaLop", cboLop.Text);
            cmd.Parameters.AddWithValue("MaMon", cboMonHoc.Text);
            cmd.Parameters.AddWithValue("DiemTB", txtDiemTB.Text);
            cmd.Parameters.AddWithValue("DiemThiLan1", txtDiemThi1.Text);
            cmd.Parameters.AddWithValue("DiemTongKet", txtDiemTK.Text);
            cmd.Parameters.AddWithValue("HanhKiem", cboHanhKiem.Text);
            cmd.Parameters.AddWithValue("HocKi", cboHocKi.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            this.kET_QUATableAdapter.Fill(this.uTTquanlisvDataSet.KET_QUA);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // mở file excel 
            //trước tiên phải thêm thư viện Microsoft.Office.Interop.Excel
            // khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // khởi tạo wordbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            //khởi tạo worksheet và chạy excel
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Trang_tính1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;

            // đổ dữ liệu vào sheets

            worksheet.Cells[2, 1] = "Mã sinh viên";
            worksheet.Cells[2, 2] = "Tên sinh viên";
            worksheet.Cells[2, 3] = "Mã lớp";
            worksheet.Cells[2, 4] = "Mã môn";
            worksheet.Cells[2, 5] = "Điểm trung bình";
            worksheet.Cells[2, 6] = "Điểm thi";
            worksheet.Cells[2, 7] = "Điểm tổng kết";
            worksheet.Cells[2, 8] = "Hạnh Kiểm";
            worksheet.Cells[2, 9] = "Học Kì";
            worksheet.Cells[2, 10] = "Ghi chú";

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)// 
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void label5_Click(object sender, EventArgs e)
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
            String sql = " SELECT MaSv, HoTen,MaLop,MaMon,DiemTB,DiemThiLan1,DiemTongKet,HanhKiem,HocKi,GhiChu";
    
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
            column3.DataPropertyName = "MaLop";
            column3.HeaderText = "Mã lớp";
            dataGridView1.Columns.Add(column3);
            //cột 4 với fields là Giới tính
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "MaMon";
            column4.HeaderText = "Mã môn";
            dataGridView1.Columns.Add(column4);
            // cột 5 là DiaChi
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "DiemTB";
            column5.HeaderText = "Điểm trung bình";
            dataGridView1.Columns.Add(column5);
            //Cột 6 là DienThoai
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "DiemThiLan1";
            column6.HeaderText = "Điểm thi";
            dataGridView1.Columns.Add(column6);
            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.DataPropertyName = "DiemTongKet";
            column7.HeaderText = "Điểm tổng kết";
            dataGridView1.Columns.Add(column7);
            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.DataPropertyName = "HanhKiem";
            column8.HeaderText = "Hạnh Kiểm";
            dataGridView1.Columns.Add(column8);
            DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn();
            column9.DataPropertyName = "HocKi";
            column9.HeaderText = "Học Kì";
            dataGridView1.Columns.Add(column9);
            DataGridViewTextBoxColumn column10 = new DataGridViewTextBoxColumn();
            column10.DataPropertyName = "GhiChu";
            column10.HeaderText = "Ghi chú";
            dataGridView1.Columns.Add(column10);
            dataGridView1.DataSource = dt;
        }

    }
}
