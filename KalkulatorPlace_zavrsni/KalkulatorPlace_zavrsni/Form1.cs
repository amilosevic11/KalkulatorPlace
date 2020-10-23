using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorPlace_zavrsni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_NoviRadnik_Click(object sender, EventArgs e)
        {
            Hide();

            NoviRadnik noviRadnik = new NoviRadnik();
            noviRadnik.Show();
        }

        private void btn_PostojeciRadnik_Click(object sender, EventArgs e)
        {
            Hide();

            PostojeciRadnik postojeciRadnik = new PostojeciRadnik();
            postojeciRadnik.Show();
        }

        private void btn_Izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
