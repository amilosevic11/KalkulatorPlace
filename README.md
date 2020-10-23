# KalkulatorPlace
Windows Form aplikacija za obračun plaće pisana u C# programskom jeziku i spojena na lokalnu bazu podataka.


Početni prozor nam prikazuje mogućnost odabira hoćemo li unositi novog radnika ili ćemo raditi obračun plaće postojećem radniku.

![PocetniProzor](https://i.ibb.co/dJckZP4/Prvi-Prozor.jpg)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

```c#
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
```

Pritiskom na "Novi radnik" nam se otvara sljedeći prozor:

![NoviRadnik](https://i.ibb.co/cN6rGCh/Novi-Radnik-Prozor.jpg)

"Nazad" nas vraća na početni zaslon i ako kliknemo "Postojeći radnik", otvara nam se sljedeći prozor:

![PostojeciRadnik](https://i.ibb.co/6P1hjqM/Prikazi-Sve.jpg)

Računanje obračuna plaće se radi tako da unesemo BRUTO iznos plaće, odaberemo radnika u "DataGridView" i pritisnemo "Izračunaj".

![PregledIspisa](https://i.ibb.co/T1VV2kP/Pregled-Ispisa.jpg)

Omogućen je i ispis platne liste.
