using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_QTCSDL
{
    public partial class FormThemSach : Form
    {
        public FormThemSach()
        {
            InitializeComponent();
        }
        OracleConnection conn = new OracleConnection();
        Chucnang cn = new Chucnang();
        private void FormThemSach_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            cn.hienthiComboBox("select maloai, tenloai from loaisach", conn, comboBox1, "tenloai", "maloai");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.TuDongTangID(conn, "masach", "3", "3", "sach", "SS", textBox1);
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masach = textBox1.Text;
            string tensach = textBox2.Text;
            string nxb = textBox3.Text;
            string tacgia = textBox4.Text;
            string maloai = comboBox1.SelectedValue.ToString();
            string gia = textBox5.Text;

            if (string.IsNullOrEmpty(masach) || string.IsNullOrEmpty(tensach) || string.IsNullOrEmpty(nxb) || string.IsNullOrEmpty(tacgia) || string.IsNullOrEmpty(maloai) || string.IsNullOrEmpty(gia))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql_insert = "insert into sach values ('" + masach + "', '" + tensach + "', '" + nxb + "', '" + tacgia + "', '" + maloai + "', '" + gia + "')";
            cn.cap_nhat(sql_insert, conn);
            MessageBox.Show("Thêm sách thành công");
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string masach = Interaction.InputBox("Nhập mã sách muốn xóa: ", "Xóa loại sách", "").ToUpper().Trim();
            OracleDataReader reader = new OracleCommand("select * from sach where masach = '" + masach + "'", conn).ExecuteReader();
            if (reader.Read())
            {
                string sql_delete = "delete from sach where masach = '" + masach + "'";
                cn.cap_nhat(sql_delete, conn);
                MessageBox.Show("Đã xóa sách có mã " + masach, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Không tìm thấy mã sách " + masach, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
