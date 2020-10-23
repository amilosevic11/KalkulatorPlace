# Kalkulator Plaće
Windows Form aplikacija za obračun plaće pisana u C# programskom jeziku i spojena na lokalnu bazu podataka.


Početni prozor nam prikazuje mogućnost odabira hoćemo li unositi novog radnika ili ćemo raditi obračun plaće postojećem radniku.

![PocetniProzor](https://i.ibb.co/dJckZP4/Prvi-Prozor.jpg)

```C#
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

```C#
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
```

"Nazad" nas vraća na početni zaslon i ako kliknemo "Postojeći radnik", otvara nam se sljedeći prozor:

![PostojeciRadnik](https://i.ibb.co/6P1hjqM/Prikazi-Sve.jpg)

```C#
namespace KalkulatorPlace_zavrsni
{
    public partial class PostojeciRadnik : Form
    {
        Tvrtka tvrtka = new Tvrtka();
        OdabraniRadnik odabraniRadnik = new OdabraniRadnik();
        ElementiPlace elementiPlace = new ElementiPlace();
        public PostojeciRadnik()
        {
            InitializeComponent();
        }

        public void UcitajTvrtku()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLOCALDB; Initial Catalog = LMS; Integrated Security = True; Pooling = False");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT OIB, NazivPoduzeca, Adresa, Grad, IBAN FROM Tvrtka;", connection);

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                tvrtka.OIB = dataReader.GetValue(0).ToString();
                tvrtka.NazivPoduzeca = dataReader.GetValue(1).ToString();
                tvrtka.Adresa = dataReader.GetValue(2).ToString();
                tvrtka.Grad = dataReader.GetValue(3).ToString();
                tvrtka.IBAN = dataReader.GetValue(4).ToString();
            }

            connection.Close();
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLOCALDB; Initial Catalog = LMS; Integrated Security = True; Pooling = False");
                connection.Open();

                string query = "SELECT * FROM Radnik WHERE Ime ='" + txtIme.Text + "' OR Prezime ='" + txtPrezime.Text + "' OR OIB ='" + txtOIB.Text + "';";
                SqlCommand cmd = new SqlCommand(query, connection);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DataGridViewPodaci.DataSource = dt;

                connection.Close();
                da.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLOCALDB; Initial Catalog = LMS; Integrated Security = True; Pooling = False");
            connection.Open();

            string statement = "SELECT * FROM Radnik;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(statement, connection);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DataGridViewPodaci.DataSource = dataTable;

            connection.Close();
            dataAdapter.Dispose();
        }

        private void DataGridViewPodaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = DataGridViewPodaci.GetCellCount(DataGridViewElementStates.Selected);
            if(selectedCellCount > 0)
            {
                if (DataGridViewPodaci.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Sve ćelije su odabrane", "Odabrane ćelije");
                }
                else
                {
                    odabraniRadnik.OIB = DataGridViewPodaci.SelectedCells[0].Value.ToString();
                    odabraniRadnik.Ime = DataGridViewPodaci.SelectedCells[1].Value.ToString();
                    odabraniRadnik.Prezime = DataGridViewPodaci.SelectedCells[2].Value.ToString();
                    odabraniRadnik.PostanskiBrojiGrad = DataGridViewPodaci.SelectedCells[3].Value.ToString();
                    odabraniRadnik.AdresaPrebivalista = DataGridViewPodaci.SelectedCells[4].Value.ToString();
                    odabraniRadnik.BrojDjece = Convert.ToInt32(DataGridViewPodaci.SelectedCells[5].Value);
                    odabraniRadnik.BankovniRacun = DataGridViewPodaci.SelectedCells[6].Value.ToString();
                }
            }
        }

        private void ButtonPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            UcitajTvrtku();

            try
            {
                e.Graphics.DrawString(tvrtka.NazivPoduzeca, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 0));
                e.Graphics.DrawString(tvrtka.Adresa + ",", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 20));
                e.Graphics.DrawString(tvrtka.Grad, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(130, 20));
                e.Graphics.DrawString("OIB: " + tvrtka.OIB, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 40));
                e.Graphics.DrawString("IBAN: " + tvrtka.IBAN, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 60));

                e.Graphics.DrawString("OBRAČUN PLAĆE", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(10, 100));
                e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(220, 100));
                e.Graphics.DrawString("______________________________________________", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(-5, 90));

                e.Graphics.DrawString(odabraniRadnik.Ime + " " + odabraniRadnik.Prezime, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 135));
                e.Graphics.DrawString(odabraniRadnik.AdresaPrebivalista, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 153));
                e.Graphics.DrawString(odabraniRadnik.PostanskiBrojiGrad, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 171));
                e.Graphics.DrawString("OIB: " + odabraniRadnik.OIB, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 189));
                e.Graphics.DrawString("IBAN: " + odabraniRadnik.BankovniRacun, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 207));
                e.Graphics.DrawString("Broj djece: " + odabraniRadnik.BrojDjece, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 225));
                e.Graphics.DrawString("______________________________________________", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(-5, 220));

                e.Graphics.DrawString("Ukupan trošak: " + (Convert.ToDouble(BrutoIznos_textBox.Text) + (Convert.ToDouble(BrutoIznos_textBox.Text) * elementiPlace.Zdravstveno)) + " KN", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(0, 265));
                e.Graphics.DrawString("Zdravstveno osiguranje (16.5%): " + (Convert.ToDouble(BrutoIznos_textBox.Text) * elementiPlace.Zdravstveno) + " KN", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 290));
                e.Graphics.DrawString("Bruto iznos: " + BrutoIznos_textBox.Text + " KN", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(0, 315));
                e.Graphics.DrawString("Doprinos za mirovinsko 1. stup (15%): " + elementiPlace.MIOstup1 + " KN", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 335));
                e.Graphics.DrawString("Doprinos za mirovinsko 2. stup (5%): " + elementiPlace.MIOstup2 + " KN", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 353));
                e.Graphics.DrawString("______________________________________________", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(-5, 345));

                e.Graphics.DrawString("Dohodak: " + elementiPlace.Dohodak + " KN", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(0, 393));
                e.Graphics.DrawString("______________________________________________", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(-5, 390));

                e.Graphics.DrawString("Osobni odbitak: " + elementiPlace.odbitakZaDjecu + " KN", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(0, 430));
                e.Graphics.DrawString("Porez (24%): " + elementiPlace.Porez1 + " KN", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 450));
                e.Graphics.DrawString("Porez (36%): " + elementiPlace.Porez2 + " KN", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 465));
                e.Graphics.DrawString("Prirez: " + elementiPlace.Prirez + " KN", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 480));
                e.Graphics.DrawString("______________________________________________", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(-5, 480));

                e.Graphics.DrawString("Neto iznos: " + elementiPlace.netoPlaca + " KN", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(5, 535));
                e.Graphics.DrawString("Primio: ___________________              Dana: ___________________", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(10, 1100));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLOCALDB; Initial Catalog = LMS; Integrated Security = True; Pooling = False");
                connection.Open();

                string query = "DELETE FROM Radnik WHERE Ime ='" + odabraniRadnik.Ime + "';";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                string statement = "SELECT * FROM Radnik;";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(statement, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DataGridViewPodaci.DataSource = dataTable;

                connection.Close();
                dataAdapter.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonIspis_Click(object sender, EventArgs e)
        {
            PrintDocument.Print();
        }

        public void IzracunajOdbitakZaDjecu()
        {
            if(odabraniRadnik.BrojDjece == 1)
            {
                elementiPlace.odbitakZaDjecu = 5750;
            }
            else if(odabraniRadnik.BrojDjece == 2)
            {
                elementiPlace.odbitakZaDjecu = 8250;
            }
            else if(odabraniRadnik.BrojDjece == 3)
            {
                elementiPlace.odbitakZaDjecu = 11750;
            }
            else if(odabraniRadnik.BrojDjece == 4)
            {
                elementiPlace.odbitakZaDjecu = 16500;
            }
            else if(odabraniRadnik.BrojDjece == 5)
            {
                elementiPlace.odbitakZaDjecu = 22750;
            }
            else if(odabraniRadnik.BrojDjece == 6)
            {
                elementiPlace.odbitakZaDjecu = 30749.99999;
            }
            else if (odabraniRadnik.BrojDjece == 0)
            {
                elementiPlace.odbitakZaDjecu = 4000;
            }
        }

        public void DohvatiPrirez()
        {
            if (odabraniRadnik.PostanskiBrojiGrad.Contains("Zagreb"))
            {
                elementiPlace.Prirez = 0.18;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Osijek"))
            {
                elementiPlace.Prirez = 0.13;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Slavonski Brod"))
            {
                elementiPlace.Prirez = 0.12;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Valpovo"))
            {
                elementiPlace.Prirez = 0.08;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Našice"))
            {
                elementiPlace.Prirez = 0.08;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Donji Miholjac"))
            {
                elementiPlace.Prirez = 0.05;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Beli Manastir"))
            {
                elementiPlace.Prirez = 0.05;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Belišće"))
            {
                elementiPlace.Prirez = 0.07;
            }
            else if (odabraniRadnik.PostanskiBrojiGrad.Contains("Požega"))
            {
                elementiPlace.Prirez = 0.07;
            }
        }

        public void RacunajPorez2()
        {
            double osnovica = elementiPlace.Dohodak - elementiPlace.odbitakZaDjecu;

            elementiPlace.Porez1 = 30000 * 0.24;
            elementiPlace.Porez2 = (osnovica - 30000) * 0.36;
        }

        private void Btn_IzracunajPlacu_Click(object sender, EventArgs e)
        {
            try
            {
                elementiPlace.MIOstup1 = Convert.ToDouble(BrutoIznos_textBox.Text) * 0.15;
                elementiPlace.MIOstup2 = Convert.ToDouble(BrutoIznos_textBox.Text) * 0.05;
                elementiPlace.Dohodak = Convert.ToDouble(BrutoIznos_textBox.Text) - (elementiPlace.MIOstup1 + elementiPlace.MIOstup2);
                IzracunajOdbitakZaDjecu();
                DohvatiPrirez();

                if (elementiPlace.odbitakZaDjecu > elementiPlace.Dohodak)
                {
                    elementiPlace.Porez1 = 0;
                    elementiPlace.Porez2 = 0;
                    elementiPlace.Prirez = 0;
                }
                else if ((elementiPlace.Dohodak - elementiPlace.odbitakZaDjecu) <= 30000)
                {
                    elementiPlace.Porez1 = (elementiPlace.Dohodak - elementiPlace.odbitakZaDjecu) * 0.24;
                    elementiPlace.Porez2 = 0;
                }
                else if ((elementiPlace.Dohodak - elementiPlace.odbitakZaDjecu) > 30000)
                {
                    RacunajPorez2();
                }

                elementiPlace.Prirez = (elementiPlace.Porez1 + elementiPlace.Porez2) * elementiPlace.Prirez;

                elementiPlace.PrirezPorez = elementiPlace.Prirez + elementiPlace.Porez1 + elementiPlace.Porez2;

                elementiPlace.netoPlaca = elementiPlace.Dohodak - elementiPlace.PrirezPorez; 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
```

Računanje obračuna plaće se radi tako da unesemo BRUTO iznos plaće, odaberemo radnika u "DataGridView" i pritisnemo "Izračunaj".

![PregledIspisa](https://i.ibb.co/T1VV2kP/Pregled-Ispisa.jpg)

Omogućen je i ispis platne liste.
