using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InternetKafe
{
    class Baglanti
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=internetkafe;Integrated Security=True");


        public void Baslat()
        {
            baglanti.Open();
            if (baglanti.State != System.Data.ConnectionState.Closed)
            {

            }
            else
            {
                MessageBox.Show("Baglanti Xetasi");
            }
        }
        public void Bitir()
        {
            try
            {
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Baglanti Xetasi" + ex);
            }

        }
    }
}
