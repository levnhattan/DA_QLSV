using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CS464_G_INDIVIDUAL_PROJECT
{
    class LopDungChung
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\DA_QLSV\CS464_G_INDIVIDUAL_PROJECT\CS464_G_INDIVIDUAL_PROJECT\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }
        public void Nonquery(string sql)
        {
            conn.Open();
            SqlCommand commm = new SqlCommand(sql, conn);
            int kq = commm.ExecuteNonQuery();
            conn.Close();
            if(kq >= 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
        public object Scalar(string sql)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int kq = (int)comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadGrid(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
