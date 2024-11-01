using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Oracle_QTCSDL
{
    public partial class FormNguoiMuon : Form
    {
        public FormNguoiMuon()
        {
            InitializeComponent();
        }
        OracleConnection conn = new OracleConnection();
        Chucnang cn = new Chucnang();
        private void FormNguoiMuon_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            cn.hienthiDG("select m.madg, tendg, m.masach, tensach, ngaymuon, ngaytra from muon m, docgia dg, sach s where s.masach = m.masach and dg.madg = m.madg", conn, dataGridView1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MMM-yyyy";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMadg.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            txbTendg.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            txbMaSach.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            txbTenSach.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker2.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madg = txbMadg.Text;
            string masach = txbMaSach.Text;

            DateTime ngaymuon = DateTime.ParseExact(dateTimePicker1.Text.ToUpper(), "dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa người mượn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (OracleCommand command = new OracleCommand("xoa_nguoi_muon_sach", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("madg", OracleDbType.Char, 5).Value = madg;
                        command.Parameters.Add("masach", OracleDbType.Char, 5).Value = masach;
                        command.Parameters.Add("ngaymuon", OracleDbType.Date).Value = ngaymuon;

                        command.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa người mượn có mã độc giả " + madg + ", mượn sách " + masach + " vào ngày " + ngaymuon, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                cn.hienthiDG("select m.madg, tendg, m.masach, tensach, ngaymuon, ngaytra from muon m, docgia dg, sach s where s.masach = m.masach and dg.madg = m.madg", conn, dataGridView1);
            }
        }
    }
}
