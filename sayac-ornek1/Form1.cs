using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayac_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = "0";
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (sayac > -10)
            {
                sayac--;
            }
            lblSayac.Text = sayac.ToString();

        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            if (sayac < 10)
            {
                sayac++;
            }
            lblSayac.Text=sayac.ToString();
        }
    }
}
