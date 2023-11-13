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

namespace Filmy_db_ukol
{
    public partial class Hlavni : Form
    {
        public Hlavni()
        {
            InitializeComponent();
            //Inicializace připojení k serveru
            sestavovac = new SqlConnectionStringBuilder();
            sestavovac.DataSource = @"(localdb)\Database";
            sestavovac.InitialCatalog = "Filmy";
            sestavovac.IntegratedSecurity = true;

            pripojeni = new SqlConnection(sestavovac.ConnectionString);
            prikaz = new SqlCommand();

        }

        //Proměnné

        SqlConnectionStringBuilder sestavovac;
        SqlCommand prikaz;
        SqlDataReader ctecka;

        string nazev = "";

        SqlConnection pripojeni;

        private void buttonZobraz_Click(object sender, EventArgs e)
        {
            //Vypíše všechny názvy filmů v databázi 
            pripojeni = new SqlConnection(sestavovac.ConnectionString);
            listBox1.Items.Clear();
            using (pripojeni)
            {
                pripojeni.Open();
                prikaz = new SqlCommand();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Film";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    listBox1.Items.Add("ID: " + ctecka[0] + ", " + ctecka[1]);
                }
                pripojeni.Close();
            }
        }

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            //vypíše všechny filmy i s jejich parametry
            pripojeni = new SqlConnection(sestavovac.ConnectionString);
            listBox1.Items.Clear();
            using (pripojeni)
            {
                pripojeni.Open();
                prikaz = new SqlCommand();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Film inner join Reziser ON Film.reziserid=Reziser.id join Zanr On Film.zanrid=Zanr.id";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    listBox1.Items.Add("ID: " + ctecka[0] + ", Název: " + ctecka[1] + ", Režisér: " + ctecka[7] + " " + ctecka[8] + "\n, Délka: " + ctecka[3] + " min, \nŽánr: " + ctecka[10] + ",\n Popis: " + ctecka[5]);
                }
                pripojeni.Close();
            }
        }

        private void buttonsprava_filmy_Click(object sender, EventArgs e)
        {
            //Otevře menu pro spravování filmů
            Filmy filmy = new Filmy();
            this.Hide();
            filmy.ShowDialog();
            this.Show();

        }

        private void buttonSpravaZanru_Click(object sender, EventArgs e)
        {
            //Otevře menu pro spravování žůnrů
            Zanry zanry = new Zanry();
            this.Hide();
            zanry.ShowDialog();
            this.Show();
        }

        private void buttonSpravaReziseru_Click(object sender, EventArgs e)
        {
            //Otevře menu pro spravování režisérů
            Reziseri reziser = new Reziseri();
            this.Hide();
            reziser.ShowDialog();
            this.Show();
        }

        private void buttonHledej_Click(object sender, EventArgs e)
        {
            //Vypíše to názvy všech filmů, které hledáme podle jména
            nazev = textBoxNazev.Text;
            if (!nazev.Equals(""))
            {
                pripojeni = new SqlConnection(sestavovac.ConnectionString);
                prikaz.Connection = pripojeni;
                listBox1.Items.Clear();
                using (pripojeni)
                {
                    pripojeni.Open();
                    prikaz.CommandText = "select * from Film inner join Reziser ON Film.reziserid=Reziser.id join Zanr On Film.zanrid=Zanr.id where Film.nazev='" + nazev + "'";
                    ctecka = prikaz.ExecuteReader();

                    while (ctecka.Read())
                    {
                        listBox1.Items.Add("Název: " + ctecka[1] + ", Režisér: " + ctecka[7] + " " + ctecka[8] + "\n, Délka: " + ctecka[3] + " min, \nŽánr: " + ctecka[10] + ",\n Popis: " + ctecka[5]);
                    }

                }
            }
        }
    }
}
