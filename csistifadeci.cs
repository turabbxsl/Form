using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MaterialSkin.Controls;

namespace InternetKafe
{
    class csistifadeci
    {
        Baglanti bg = new Baglanti();

        public int istifadeciid = 0;
        public bool veziyyet = false;
        public SqlDataReader Istifadecigirisi(TextBox istifadeciadi,TextBox sifre)
        {
            bg.Baslat();
            SqlCommand cmd = new SqlCommand(" select * from tblistifadeci where istifadeciadi = '" + istifadeciadi.Text + "' AND sifre = '"+ sifre.Text + "' ",bg.baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                veziyyet = true;
                istifadeciid =int.Parse(dr["istifadeciid"].ToString());
            }
            else
            {
                veziyyet = false;
                bg.Bitir();
            }
            return dr;
        }
    }
}
