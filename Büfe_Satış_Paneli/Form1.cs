using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Büfe_Satış_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int kek, su, yumurta, süt, toplam;
            kek = Convert.ToInt32(txtKek.Text);
            su = Convert.ToInt32(txtSu.Text);
            süt = Convert.ToInt32(txtSüt.Text);
            yumurta = Convert.ToInt32(txtYumurta.Text);

            toplam = kek * 5 + su * 1 + süt * 7 + yumurta * 10;
            lblToplam.Text = toplam.ToString() + " TL";

            kasa = kasa + toplam;
            lblKasa.Text = kasa.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKek.Text = "";
            txtSu.Text = "";
            txtSüt.Text = "";
            txtYumurta.Text = "";
            lblToplam.Text = "00 TL";
            txtKek.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKek.Text = "0";
            txtSu.Text = "0";
            txtSüt.Text = "0";
            txtYumurta.Text = "0";
        }

        private void txtKek_Click(object sender, EventArgs e)
        {
            txtKek.Text = "";
        }

        private void txtSüt_Click(object sender, EventArgs e)
        {
            txtSüt.Text = "";
        }

        private void txtSu_Click(object sender, EventArgs e)
        {
            txtSu.Text = "";
        }

        private void txtYumurta_Click(object sender, EventArgs e)
        {
            txtYumurta.Text = "";
        }
    }
}
