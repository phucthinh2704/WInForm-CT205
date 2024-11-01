
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace Oracle_QTCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        OracleConnection conn = new OracleConnection();
        Chucnang cn = new Chucnang();

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            cn.hienthiDG("select masach as \"Mã sách\", tensach as \"Tên sách\", nxb as \"Nhà xuất bản\", tentacgia as \"Tên tác giả\", tenloai as \"Tên loại sách\", gia as \"Giá\" from sach s, loaisach ls where s.maloai = ls.maloai order by masach", conn, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand("get_all_price", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter result = new OracleParameter();
                    result.ParameterName = "result"; // Thêm tên tham số
                    result.Direction = ParameterDirection.ReturnValue; // Định hướng tham số
                    cmd.Parameters.Add(result);
                    string gia = "0";
                    OracleDataReader reader = new OracleCommand("select sum(gia) from sach", conn).ExecuteReader();
                    if (reader.Read())
                    {
                        gia = reader[0].ToString();
                    }
                    textBox1.Text = gia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand("get_avg_price", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter result = new OracleParameter();
                    result.ParameterName = "result"; // Thêm tên tham số
                    result.Direction = ParameterDirection.ReturnValue; // Định hướng tham số
                    cmd.Parameters.Add(result);
                    string giaAVG = "0";
                    OracleDataReader reader = new OracleCommand("select round(avg(gia), 2) from sach", conn).ExecuteReader();
                    if (reader.Read())
                    {
                        giaAVG = reader[0].ToString();
                    }
                    textBox2.Text = giaAVG;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand("get_kimdong_price", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter result = new OracleParameter();
                    result.ParameterName = "result"; // Thêm tên tham số
                    result.Direction = ParameterDirection.ReturnValue; // Định hướng tham số
                    cmd.Parameters.Add(result);
                    string giaKD = "0";
                    OracleDataReader reader = new OracleCommand("select sum(gia) from sach where nxb like '%Kim Dong%'", conn).ExecuteReader();
                    if (reader.Read())
                    {
                        giaKD = reader[0].ToString();
                    }
                    textBox3.Text = giaKD;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMaSach.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            lbTenSach.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            lbNXB.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            lbTacGia.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            lbGia.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormThemSach frm = new FormThemSach();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cn.hienthiDG("select masach as \"Mã sách\", tensach as \"Tên sách\", nxb as \"Nhà xuất bản\", tentacgia as \"Tên tác giả\", tenloai as \"Tên loại sách\", gia as \"Giá\" from sach s, loaisach ls where s.maloai = ls.maloai order by masach", conn, dataGridView1);
        }
    }
}
