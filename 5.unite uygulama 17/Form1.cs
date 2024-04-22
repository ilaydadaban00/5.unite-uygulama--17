using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.unite_uygulama_17
{
    public partial class Form1 : Form
    {
       ErrorProvider ep=new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKAydet_Click(object sender, EventArgs e)
        {

        }

        private void txtNumara_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(txtNumara.Text,out int sonuc))
            {
                ep.SetError(txtNumara ,"");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtNumara, "numara hatalı");
            }
        }

        private void txtAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdSoyad.Text == "")
            {
                e.Cancel = true;
                ep.SetError(txtNumara, "ad ve soyad giriniz");
            }
            else
            {
                ep.SetError(txtAdSoyad ,"");
            }
        }

        private void txtDersNotu_Validating(object sender, CancelEventArgs e)
        {
            int dersnotu;
            if (int.TryParse(txtDersNotu.Text, out dersnotu))
            {
                if(dersnotu < 0 || dersnotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(txtNumara, " 0-100 arasında giriniz");
                }
                else
                {
                    ep.SetError(txtDersNotu, "");
                }

            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtDersNotu, " sayısal deger giriniz");
            }
        }
    }
}
