using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS464_G_INDIVIDUAL_PROJECT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void QuanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["MonHoc"] == null)
            {
                MonHoc qlmn = new MonHoc();
                qlmn.MdiParent = this.MdiParent;
                qlmn.Show();
            }
            else
            {
                Application.OpenForms["MonHoc"].Activate();
            }
        }

        private void SinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["SinhVien"] == null)
            {
                SinhVien sv = new SinhVien();
                sv.MdiParent = this.MdiParent;
                sv.Show();

            }
            else
            {
                Application.OpenForms["SinhVien"].Activate();
            }
        }
    }
}
