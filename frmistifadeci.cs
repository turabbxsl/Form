using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetKafe
{
    public partial class frmistifadeci : Form
    {
        public frmistifadeci()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmistifadeci_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            csistifadeci c = new csistifadeci();
            c.Istifadecigirisi(txtistifadecii,txtsifree);
            if (c.veziyyet == true)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else if(c.veziyyet == false)
            {
                MessageBox.Show("Istifadeci Adi Ve Ya Sifre Bir Daha Yoxlayin","Xeberdarliq",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
