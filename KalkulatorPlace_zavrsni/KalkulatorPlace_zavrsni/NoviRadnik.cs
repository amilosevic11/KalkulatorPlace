using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorPlace_zavrsni
{
    public partial class NoviRadnik : Form
    {
        public NoviRadnik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Unesi_Click(object sender, EventArgs e)
        {
            LMSEntities context = new LMSEntities();
            Radnik radnik = new Radnik();
            try
            {
                radnik.Ime = Ime_textBox.Text;
                radnik.Prezime = Prezime_textBox.Text;
                radnik.Postanski_broj_i_grad = PostanskiBrojiGrad_textBox.Text;
                radnik.Adresa_prebivalista = AdresaPre_textBox.Text;
                radnik.Broj_djece = Convert.ToInt32(BrojDjece_textBox.Text);
                radnik.OIB = OIB_textBox.Text;
                radnik.Bankovni_racun = BankovniRacun_textBox.Text;

                context.Radniks.Add(radnik);
                context.SaveChanges();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void NoviRadnik_Load(object sender, EventArgs e)
        {

        }
    }
}
