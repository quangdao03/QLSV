using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class DANHMUC : Form
    {
        public DANHMUC()
        {
            InitializeComponent();
        }

        private void DANHMUC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QL_KHOA frmQuanlykhoa = new QL_KHOA();
            frmQuanlykhoa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_LOP frmQuanlylop = new QL_LOP();
            frmQuanlylop.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QL_MON_HOC frmQuanlymonhoc = new QL_MON_HOC();
            frmQuanlymonhoc.Show();
        }
    }
}
