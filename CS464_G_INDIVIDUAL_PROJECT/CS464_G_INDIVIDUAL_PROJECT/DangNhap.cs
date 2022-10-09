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
    public partial class DangNhap : Form
    {
        LopDungChung lopchung;

        public DangNhap()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            string sql = "select count (*)  from DANGNHAP where TenDN ='"
                + txt_TenDN.Text  +  "' and MatKhau = '"+ txt_MK.Text + "' ";
            int kq = (int)lopchung.Scalar(sql);
            if(kq >= 1)
            {   
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu sai");
                Application.Exit();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
