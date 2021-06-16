using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanmemquanlidiemUTT
{
    public partial class mainform : Form
    {
        private int childFormNumber = 0;
        public static string Quyen = "";

        public mainform()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            if(Quyen == "Admin")
            {
                MnuItemDanhMuc.Enabled = true;
                mnuDN.Enabled = true;

            }else if (Quyen == "Member")
            {
                MnuItemDanhMuc.Enabled = false;
                mnuDN.Enabled = false;
            }
        }

        public void MnuItemDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doimatkhau frm = new doimatkhau();
            frm.Text = "Đổi mật khẩu";
            frm.ShowDialog();
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlinguoidung frm = new quanlinguoidung();
            frm.Text = "Quản lí người dùng";
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_MON frm = new QL_MON();
            frm.Text = "Quản lí môn học";
            frm.ShowDialog();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_KHOA frm = new QL_KHOA();
            frm.Text = " Quản lí khoa";
            frm.ShowDialog();
        }

        private void lopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_MON frm = new QL_MON();
            frm.Text = "Quản lí lớp";
            frm.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_sinh_vien frm = new QL_sinh_vien();
            frm.Text = " Quản lí sinh viên";
            frm.ShowDialog();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_GiangVien frm = new QL_GiangVien();
            frm.Text = " Quản lí giảng viên";
            frm.ShowDialog();
        }

        private void điểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KetQua frm = new KetQua();
            frm.Text = "Quản lí điểm ";
            frm.ShowDialog();
        }
    }
}
