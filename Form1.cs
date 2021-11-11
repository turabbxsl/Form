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
    public partial class Form1 : Form
    {
        Baglanti bg = new Baglanti();
        csdatabase csdata = new csdatabase();
        csistifadeci istifadeci = new csistifadeci();
        public Form1()
        {
            InitializeComponent();
        }
        Button btn;

        private void SecileneGore(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
            if (btn.BackColor == Color.IndianRed)
            {
                limitliStolAçmaİstəyiToolStripMenuItem.Visible = false;
                limitiszStolAçmaİstəyiToolStripMenuItem.Visible = false;
            }
            if (btn.BackColor == Color.LightGreen)
            {
                limitliStolAçmaİstəyiToolStripMenuItem.Visible = true;
                limitiszStolAçmaİstəyiToolStripMenuItem.Visible = true;
            }
        }
        RadioButton radio;
        private void RadioButtonSecimeGore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetkafeDataSet.tblsaatmeblegi' table. You can move, or remove it, as needed.
            this.tblsaatmeblegiTableAdapter.Fill(this.internetkafeDataSet.tblsaatmeblegi);
            radiolimitsiz.Checked = true;
            Yenile();
            combobosstollar.Text = "";
            timer1.Start();
        }
        public void Yenile()
        {
            csdatabase cs = new csdatabase();
            cs.Sebetlist(dataGridView1);
            cs.ListviewGoster(listView1);
            cs.ComboBosStolGetir(combobosstollar);
            //bg.Baslat();
            //SqlDataAdapter da = new SqlDataAdapter("select * from tblstol where veziyyet = 'Bos'", bg.baglanti);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //combobosstollar.DataSource = dt;
            //combobosstollar.DisplayMember = "Stollar";
            //combobosstollar.ValueMember = "Stolid";
            //bg.Bitir();
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    if (item.Name != btnstolac.Name)
                    {
                        bg.Baslat();
                        SqlCommand cmd = new SqlCommand("select * from tblstol", bg.baglanti);
                        SqlDataReader read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            if (read["veziyyet"].ToString() == "Bos" && read["Stollar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            if (read["veziyyet"].ToString() == "Dolu" && read["Stollar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.IndianRed;
                            }
                        }
                        bg.Bitir();
                    }
                }
            }
        }

        private void btnstolac_Click(object sender, EventArgs e)
        {
            if (istifadeci.istifadeciid == 0)
            {
                string sorgu = "insert into tblsebet(Stolid,Stol,AcilisTuru,Baslangic,Tarix) values('" + combobosstollar.Text.Substring(5) + "','" + combobosstollar.Text + "'" + ",'" + radio.Text + "',@baslangic,@tarix)";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@baslangic",DateTime.Parse(DateTime.Now.ToString()));
                cmd.Parameters.AddWithValue("@tarix", DateTime.Parse(DateTime.Now.ToString()));
                csdata.ESG(cmd, sorgu);
                MessageBox.Show(combobosstollar.Text.Substring(5) + "No-li Stol Acildi.", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
                radiolimitsiz.Checked = true;
               
            }
            else
            {
                MessageBox.Show("Bele Bir Vezifeniz Yoxdur.", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hesabla"].Index)
            {
                if (combosaatmeblegi.Text != "")
                {
                    DateTime bitistarixi = DateTime.Now;
                    DateTime baslangictarixi = DateTime.Parse(dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString());
                    TimeSpan ferq = bitistarixi - baslangictarixi;
                    double saatferqi = ferq.TotalHours;
                    double cem = saatferqi * double.Parse(combosaatmeblegi.Text);
                    dataGridView1.CurrentRow.Cells["Vaxt"].Value = saatferqi.ToString("0.0");                   
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = cem.ToString("0.0");
                    dataGridView1.CurrentRow.Cells["Bitis_saati"].Value = bitistarixi;
                }
                if (combosaatmeblegi.Text == "")
                {
                    MessageBox.Show("Evvelce Saat Meblegini Secin","Xeberdarliq",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["Stol_bagla"].Index)
            {
                if (dataGridView1.CurrentRow.Cells["Bitis_saati"].Value != null)
                {
                    frmStolBagla f = new frmStolBagla();
                    f.txtid.Text = dataGridView1.CurrentRow.Cells["İD"].Value.ToString();
                    f.txtstolid.Text = dataGridView1.CurrentRow.Cells["Stol_İD"].Value.ToString();
                    f.txtstol.Text = dataGridView1.CurrentRow.Cells["_Stol"].Value.ToString();
                    f.txtacilisturu.Text = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
                    f.txtbaslamasaati.Text = dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString();
                    f.txtbitissaati.Text = dataGridView1.CurrentRow.Cells["Bitis_saati"].Value.ToString();
                    f.txtsaatmebleg.Text = combosaatmeblegi.Text;
                    f.txtvaxt.Text = dataGridView1.CurrentRow.Cells["Vaxt"].Value.ToString();
                    f.txtcem.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    f.txttarix.Text = dataGridView1.CurrentRow.Cells["_Tarix"].Value.ToString();
                    f.ShowDialog();
                }
               else if (dataGridView1.CurrentRow.Cells["Bitis_saati"].Value == null)
                {
                    MessageBox.Show("Evvelce Hesablamani Yerine Yetirmelisiniz.","Xeberdarliq",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        string istek = "";
        csdatabase cs = new csdatabase();
        private void idarəçiÇağırınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Idarecini Cagirir.";
            Istekler();
        }
        public void Istekler()
        {
            string sorgu = "insert into hereketler(istifadeciid,stolid,stol,istekturu,aciqlama,tarix) values ('" + istifadeciid + "','" + btn.Text.Substring(5) + "','" + btn.Text + "','" + istek + "','Edilmeyib',@tarix)";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@tarix", DateTime.Parse(DateTime.Now.ToString()));
            cs.ESG(cmd, sorgu);
            cs.ListviewGoster(listView1);
        }

        private void limitiszStolAçmaİstəyiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Limitsiz Stol Acma Isteyi Gonderdi.";
            Istekler();
        }
        private void stolDəyişdirməİstəyiGöndərToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Stol Deyisdirme Isteyi Gonderdi.";
            Istekler();
        }

        ToolStripMenuItem item;
        private void LimitliSecmeIsteyi(object sender, EventArgs e)
        {
            item = sender as ToolStripMenuItem;
            istek = item.Text + " DK Vaxt Ile Stol Acma Isteyi Gonderdi.";
            Istekler();

        }

        int saygac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saygac++;
            if (saygac > 29)
            {
                if (combosaatmeblegi.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DateTime bitistarixi = DateTime.Now;
                        DateTime baslangictarixi = DateTime.Parse(dataGridView1.Rows[i].Cells["Baslangic"].Value.ToString());
                        TimeSpan ferq = bitistarixi - baslangictarixi;
                        double saatferqi = ferq.TotalHours;
                        double cem = saatferqi * double.Parse(combosaatmeblegi.Text);
                        dataGridView1.Rows[i].Cells["Vaxt"].Value = saatferqi.ToString("0.0");
                        dataGridView1.Rows[i].Cells["Tutar"].Value = cem.ToString("0.0");
                        dataGridView1.Rows[i].Cells["Bitis_saati"].Value = bitistarixi;
                    }
                }
                if (combosaatmeblegi.Text == "")
                {
                    MessageBox.Show("Evvelce Saat Meblegini Secin", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
