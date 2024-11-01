using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;
namespace Oracle_QTCSDL
{
    public partial class FormLoaiSach : Form
    {
        public FormLoaiSach()
        {
            InitializeComponent();
        }
        Chucnang cn = new Chucnang();
        OracleConnection conn = new OracleConnection();
        private void FormLoaiSach_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            cn.hienthiDG("select * from loaisach order by maloai", conn, dataGridView1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cn.TuDongTangID(conn, "maloai", "3", "3", "loaisach", "LS", txbMa);
            txbTen.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maloai = txbMa.Text;
            string tenloai = txbTen.Text;


            if (string.IsNullOrEmpty(maloai))
            {
                MessageBox.Show("Bạn chưa nhập mã loại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(tenloai))
            {
                MessageBox.Show("Bạn chưa nhập tên loại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OracleCommand command = new OracleCommand("them_loai_sach", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("maloai", OracleDbType.Char, 5).Value = maloai;
                    command.Parameters.Add("tenloai", OracleDbType.Varchar2, 100).Value = tenloai;

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            cn.hienthiDG("select * from loaisach order by maloai", conn, dataGridView1);
            MessageBox.Show("Thêm loại sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMa.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            txbTen.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maloai = Interaction.InputBox("Nhập mã loại sách muốn xóa: ", "Xóa loại sách", "").ToUpper().Trim();
            OracleDataReader reader = new OracleCommand("select * from loaisach where maloai = '" + maloai + "'", conn).ExecuteReader();
            if (reader.Read())
            {
                string sql_delete = "delete from loaisach where maloai = '" + maloai + "'";
                cn.cap_nhat(sql_delete, conn);
                cn.hienthiDG("select * from loaisach order by maloai", conn, dataGridView1);
                MessageBox.Show("Đã xóa loại sách có mã " + maloai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Không tìm thấy mã loại " + maloai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
