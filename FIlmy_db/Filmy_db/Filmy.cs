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

namespace Filmy_db_ukol
{
    public partial class Filmy : Form
    {
        public Filmy()
        {
            InitializeComponent();

            //inicializace spojení serverem
            sestavovac = new SqlConnectionStringBuilder();
            sestavovac.DataSource = @"(localdb)\Database";
            sestavovac.InitialCatalog = "Filmy";
            sestavovac.IntegratedSecurity = true;

            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            prikaz = new SqlCommand();

            //Načte do comboboxů všechny režiséry a žánry
            using (pripojeni)
            {

                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Reziser";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    comboBoxrziseri.Items.Add(ctecka[1] + " " + ctecka[2]);
                    comboBoxreziseruprava.Items.Add(ctecka[1] + " " + ctecka[2]);
                }

                pripojeni.Close();
                pripojeni.Open();

                prikaz.CommandText = "select * from Zanr";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    comboBoxZanr.Items.Add(ctecka[1]);
                    comboBoxupravzanr.Items.Add(ctecka[1]);
                }

                pripojeni.Close();

            }
            NactiList();
        }
        //Proměnné

        SqlConnectionStringBuilder sestavovac;
        SqlConnection pripojeni;

        SqlCommand prikaz;
        SqlDataReader ctecka;

        string nazev = "";
        string reziser = "";
        string zanr = "";
        int delka = 0;
        string popis = "";

        bool proslo = true;

        int idrezisera;
        int idzanru;

        int noveidr;

        string vnazev;
        string vreziser;
        string vzanr;
        int vdelka;
        string vpopis;

        int ovlivneno;
        private void buttonPridej_Click(object sender, EventArgs e)
        {
            //Načte si potřebné proměnné
            nazev = textBoxJmeno.Text;
            reziser = comboBoxrziseri.Text;
            delka = (int)numericUpDownDelka.Value;
            popis = richTextBoxPopis.Text;
            zanr = comboBoxZanr.Text;
            
            //Zjistí si správnost zadání
            if (nazev == "" || delka == 0 || popis == "" || zanr == "" || reziser == "")
            {
                proslo = false;
            }

            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            using (pripojeni)
            {

                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Film inner join Reziser ON Film.reziserid=Reziser.id join Zanr On Film.zanrid=Zanr.id";
                ctecka = prikaz.ExecuteReader();

                //Pojistka proti duplkátům
                while (ctecka.Read())
                {
                    if (ctecka[1].Equals(nazev) && (ctecka[7] + " " + ctecka[8]).Equals(reziser))
                    {
                        proslo = false;
                    }
                }

                pripojeni.Close();
                pripojeni.Open();                

                //Přidá film se zadanými parametry do databáze
                if (proslo)
                {
                    prikaz.CommandText = "select id from Reziser where concat([jmeno], ' ',[prijmeni]) = '" + reziser + "'";
                    ctecka = prikaz.ExecuteReader();
                    while (ctecka.Read())
                    {
                        idrezisera = (int)ctecka[0];
                    }
                    pripojeni.Close();
                    pripojeni.Open();

                    prikaz.CommandText = "select id from Zanr where nazev = '" + zanr + "'";
                    ctecka = prikaz.ExecuteReader();
                    while (ctecka.Read())
                    {
                        idzanru = (int)ctecka[0];
                    }
                    pripojeni.Close();
                    pripojeni.Open();

                    prikaz.CommandText = "insert into Film(nazev,reziserid,delkavmin,zanrid,popis) values (@nazev,@reziserid,@delkavmin,@zanrid,@popis)";
                    prikaz.Parameters.AddWithValue("@nazev", nazev);
                    prikaz.Parameters.AddWithValue("@reziserid", idrezisera);
                    prikaz.Parameters.AddWithValue("@delkavmin", delka);
                    prikaz.Parameters.AddWithValue("@zanrid", idzanru);
                    prikaz.Parameters.AddWithValue("@popis", popis);

                    int pocetrdku = prikaz.ExecuteNonQuery();
                    NactiList();

                    delka = 0;
                    idzanru = 0;
                    idrezisera = 0;
                    nazev = "";
                    popis = "";
                    pripojeni.Close();

                    textBoxJmeno.Text = "";
                    comboBoxrziseri.Text = "";
                    numericUpDownDelka.Value = 0;
                    comboBoxZanr.Text = "";
                    richTextBoxPopis.Text = "";
                }
                else
                {
                    proslo = true;
                }
            }
        }

        public void NactiList()
        {
            //Často volaná metoda pro refresh listu
            prikaz = new SqlCommand();
            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            using (pripojeni)
            {
                pripojeni.Open();
                listBox1.Items.Clear();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Film";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    listBox1.Items.Add(ctecka[1]);
                }
                pripojeni.Close();
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Načítá do potřebných proměnných dat podle toho, jaký film vybíráme v listu filmů
            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            using (pripojeni)
            {
                pripojeni.Open();
                prikaz.Connection = pripojeni;

                prikaz.CommandText = "select * from Film where nazev='" + listBox1.SelectedItem + "'";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    textBoxupravnazev.Text = ctecka[1].ToString();
                    numericUpDownupravadelky.Value = (int)ctecka[3];
                    richTextBoxupravpopis.Text = ctecka[5].ToString();
                    idrezisera = (int)ctecka[2];
                    idzanru = (int)ctecka[4];

                    vnazev = ctecka[1].ToString();
                    vdelka = (int)ctecka[3];
                    vpopis = ctecka[5].ToString();
                }

                pripojeni.Close();
                pripojeni.Open();

                prikaz.CommandText = "select nazev from Zanr where id=" + idzanru;
                ctecka = prikaz.ExecuteReader();
                while (ctecka.Read())
                {
                    comboBoxupravzanr.Text = ctecka[0].ToString();
                    vzanr = ctecka[0].ToString();
                }

                pripojeni.Close();
                pripojeni.Open();

                prikaz.CommandText = "select * from Reziser where id=" + idrezisera;
                ctecka = prikaz.ExecuteReader();
                while (ctecka.Read())
                {
                    comboBoxreziseruprava.Text = ctecka[1] + " " + ctecka[2];
                    vreziser = ctecka[1] + " " + ctecka[2];
                }

                idrezisera = 0;
                idzanru = 0;
                pripojeni.Close();
            }
        }

        private void buttonodstran_Click(object sender, EventArgs e)
        {
            //Odstraní vybraný film z listu
            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            using (pripojeni)
            {
                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "delete from Film where nazev='" + listBox1.SelectedItem + "'";
                ovlivneno = prikaz.ExecuteNonQuery();
                pripojeni.Close();
                NactiList();
            }
        }

        private void buttonUprav_Click(object sender, EventArgs e)
        {
            //Podle načtených proměnných si upraví vybraný film z listu
            if (!(vnazev.Equals(textBoxupravnazev.Text) && vreziser.Equals(comboBoxreziseruprava.Text) 
                && vdelka == numericUpDownupravadelky.Value && vzanr.Equals(comboBoxupravzanr.Text)
                && vpopis.Equals(richTextBoxupravpopis.Text)))
            {
                pripojeni = new SqlConnection(sestavovac.ConnectionString);

                using (pripojeni)
                {
                    pripojeni.Open();
                    prikaz.Connection = pripojeni;

                    prikaz.CommandText = "select id from Reziser where concat([jmeno], ' ',[prijmeni]) = '" + comboBoxreziseruprava.Text + "'";
                    ctecka = prikaz.ExecuteReader();
                    while (ctecka.Read())
                    {
                        idrezisera = (int)ctecka[0];
                    }

                    pripojeni.Close();
                    pripojeni.Open();

                    prikaz.CommandText = "select id from Zanr where nazev = '" + comboBoxupravzanr.Text + "'";
                    ctecka = prikaz.ExecuteReader();
                    while (ctecka.Read())
                    {
                        idzanru = (int)ctecka[0];
                    }

                    pripojeni.Close();
                    pripojeni.Open();

                    prikaz.CommandText = "select id from Reziser where concat([jmeno], ' ',[prijmeni])= '" + vreziser + "'";
                    ctecka = prikaz.ExecuteReader();
                    while (ctecka.Read())
                    {
                        noveidr = (int)ctecka[0];
                    }

                    pripojeni.Close();
                    pripojeni.Open();

                    prikaz.CommandText = "update Film set nazev='" + textBoxupravnazev.Text + "', reziserid=" + idrezisera
                        + ", delkavmin=" + numericUpDownupravadelky.Value + ", zanrid=" + idzanru + ", popis='" + richTextBoxupravpopis.Text 
                        + "' where nazev='" + vnazev + "'and reziserid='" + noveidr + "' and popis='" + vpopis + "';";
                    ovlivneno = prikaz.ExecuteNonQuery();
                    pripojeni.Close();
                    NactiList();

                    idrezisera = 0;
                    idzanru = 0;
                    textBoxupravnazev.Text = "";
                    richTextBoxupravpopis.Text = "";
                    comboBoxreziseruprava.Text = "";
                    comboBoxupravzanr.Text = "";
                    numericUpDownupravadelky.Value = 0;
                }
            }
        }
    }
}
