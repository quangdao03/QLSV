using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDIEMSINHVIEN
{
    public partial class Danhmuc : Form
    {
        public Danhmuc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_Lop frmQuanlylop = new QL_Lop();
            frmQuanlylop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QL_Khoa frmQuanlykhoa = new QL_Khoa();
            frmQuanlykhoa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QL_Mon_Hoc frmQuanlymonhoc = new QL_Mon_Hoc();
            frmQuanlymonhoc.Show();
        }
    }
}
