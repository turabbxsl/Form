using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace InternetKafe
{
    class csdatabase
    {
        Baglanti bg = new Baglanti();
        public DataTable Sebetlist(DataGridView gridview)
        {
            SqlDataAdapter da = new SqlDataAdapter(" select * from tblsebet ", bg.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridview.DataSource = dt;
            return dt;

        }
        public DataTable ComboBosStolGetir(ComboBox combo)
        {
            bg.Baslat();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblstol where veziyyet = 'Bos'", bg.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = "Stollar";
            combo.ValueMember = "Stolid";
            bg.Bitir();
            return dt;
        }
        public void ESG(SqlCommand command, string sorgu)
        {
            bg.Baslat();
            command.Connection = bg.baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            bg.Bitir();
        }
        public SqlDataReader ListviewGoster(ListView list)
        {
            list.Items.Clear();
            bg.Baslat();
            SqlCommand cmd = new SqlCommand("select * from hereketler where tarix >= @tarix",bg.baglanti);
            cmd.Parameters.AddWithValue("@tarix",DateTime.Parse(DateTime.Now.ToShortDateString()));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem elave = new ListViewItem();
                elave.Text = dr[0].ToString();
                elave.SubItems.Add(dr[1].ToString());
                elave.SubItems.Add(dr[2].ToString());
                elave.SubItems.Add(dr[3].ToString());
                elave.SubItems.Add(dr[4].ToString());
                elave.SubItems.Add(dr[5].ToString());
                elave.SubItems.Add(dr[6].ToString());
                list.Items.Add(elave);
            }
            bg.Bitir();
            return dr;
        }
    }
}
