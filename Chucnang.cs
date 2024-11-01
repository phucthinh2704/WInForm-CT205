using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_QTCSDL
{
    internal class Chucnang
    {
        public void ketnoi(OracleConnection conn)
        {
            string chuoiketnoi = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.56.1)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl21)));User Id=abc;Password=abc;";
            conn.ConnectionString = chuoiketnoi;
            conn.Open();
        }

        public void hienthiDG(string sql, OracleConnection conn, DataGridView dg)
        {
            OracleDataAdapter adt = new OracleDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adt.Fill(ds, "Thinh");

            dg.DataSource = ds;
            dg.DataMember = "Thinh";
        }

        public void hienthiComboBox(string sql, OracleConnection conn, ComboBox cb, string hienthi, string giatri)
        {
            OracleDataReader reader = new OracleCommand(sql, conn).ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            cb.DataSource = dt;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
            reader.Close();
        }

        public void cap_nhat(string sql, OracleConnection conn)
        {
            OracleCommand comd = new OracleCommand(sql, conn);
            try
            {
                comd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Your query is: " + sql + " with the error is: " + e.Message);
            }
        }

        public void TuDongTangID(OracleConnection conn, string ma, string first, string count, string table, string id, TextBox txb)
        {
            string sql = "Select max(substr(" + ma + ", " + first + "," + count + ")) + 1 from " + table + " ";
            OracleCommand cmd = new OracleCommand(sql, conn);
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                int soht = int.Parse(rd[0].ToString());
                if (soht < 10)
                    txb.Text = "" + id + "00" + soht.ToString();
                else if (soht < 100)
                    txb.Text = "" + id + "0" + soht.ToString();
                else if (soht < 1000)
                    txb.Text = "" + id + "" + soht.ToString();

            }
            txb.Enabled = false;
            rd.Close();
        }
    }
}
