using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace kuisPertemuan11_Hilwa.Controller
{
    internal class DataController : Model.Connection
    {
        public DataTable tampilData()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM mahasiswa";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahData(char NIM, varchar Nama, varchar Alamat, varchar Prodi, varchar Hobi)
        {
            string tambah = "insert into mahasiswa values(" + "@nim,@nama,@alamat,@prodi,@hobi)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@nim", MySqlConnector.MySqlDbType.VarChar).Value = NIM;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = Nama;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = Alamat;
                cmd.Parameters.Add("@prodi", MySqlConnector.MySqlDbType.VarChar).Value = Prodi;
                cmd.Parameters.Add("@hobi", MySqlConnector.MySqlDbType.VarChar).Value = Hobi;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambah data gagal " + ex.Message);
            }
        }
    }
}
