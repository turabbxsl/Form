using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InternetKafe
{
    public partial class frmStolBagla : Form
    {
        public frmStolBagla()
        {
            InitializeComponent();
        }
        csdatabase c = new csdatabase();
        csistifadeci cs = new csistifadeci();
        Baglanti bg = new Baglanti();
        private void btncixis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnstolbagla_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into tblsatis(ISTIFADECIiD,STOLiD,ACILISTURU,BASLANGICSAAT,BITISSAAT,VAXT,TUTAR,ACIQLAMA,TARIX) values('" + cs.istifadeciid + "','" + int.Parse(txtstolid.Text) + "','"+ txtacilisturu.Text + "',@baslangic,@bitis,@vaxt,@tutar,'Edilmeyib',@tarix)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@baslangic",DateTime.Parse(txtbaslamasaati.Text));
            cmd.Parameters.AddWithValue("@bitis", DateTime.Parse(txtbitissaati.Text));
            cmd.Parameters.AddWithValue("@vaxt",decimal.Parse(txtvaxt.Text));
            cmd.Parameters.AddWithValue("@tutar",decimal.Parse(txtcem.Text));
            cmd.Parameters.AddWithValue("@tarix",DateTime.Parse(txttarix.Text));
            c.ESG(cmd,sorgu);
            //this.Close();
            //string sorgu1 = "update tblstol set veziyyet = 'Bos' where Stolid = '" + txtstolid.Text + "'";
            //SqlCommand cmd1 = new SqlCommand();
            //c.ESG(cmd1, sorgu1);
            //string sorgu2 = "delete from tblsebet where Sebetid = '" + txtid.Text + "'";
            //SqlCommand cmd2 = new SqlCommand();
            //c.ESG(cmd2, sorgu2);
            this.Close();
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            frm.Yenile();
            
        }
    }
}
