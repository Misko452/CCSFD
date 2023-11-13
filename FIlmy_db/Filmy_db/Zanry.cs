using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Filmy_db_ukol
{
    public partial class Zanry : Form
    {
        public Zanry()
        {
            InitializeComponent();
            //Inicializace připojení k serveru
            sestavovac = new SqlConnectionStringBuilder();
            sestavovac.DataSource = @"(localdb)\Database";
            sestavovac.InitialCatalog = "Filmy";
            sestavovac.IntegratedSecurity = true;

            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            prikaz = new SqlCommand();

            NactiList();
        }
        //Proměnné

        SqlConnectionStringBuilder sestavovac;
        SqlConnection pripojeni;
        SqlCommand prikaz;
        SqlDataReader ctecka;

        string nazev = "";

        bool proslo = true;
        int id;
        int ovlivneno;

        string vybrany;

        private void buttonPridej_Click(object sender, EventArgs e)
        {
            //Načte proměnné a přidá žánr do databáze
            nazev = textBoxnazev.Text;

            pripojeni = new SqlConnection(sestavovac.ConnectionString);
            
            //Ověří správnost zadání 
            if (nazev == "")
            {
                proslo = false;
            }

            using (pripojeni)
            {

                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Zanr";
                ctecka = prikaz.ExecuteReader();

                //Pojistka proti duplikátům
                while (ctecka.Read())
                {
                    if (ctecka[1].Equals(nazev))
                    {
                        proslo = false;
                    }
                }

                pripojeni.Close();
                pripojeni.Open();

                if (proslo)
                {
                    prikaz.CommandText = "insert into Zanr(nazev) values (@nazev)";

                    prikaz.Parameters.AddWithValue("@nazev", nazev);

                    ovlivneno = prikaz.ExecuteNonQuery();

                }
                else
                {
                    proslo = true;
                }

                pripojeni.Close();

                textBoxnazev.Text = "";

                NactiList();
            }
        }

        public void NactiList()
        {
            //Často volaná metoda pro refresh listu
            listBox1.Items.Clear();
            using (pripojeni)
            {

                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Zanr";
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
            //Načte potřebné proměnné podle toho, jaký žánr si z listu zvolíme
            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            using (pripojeni)
            {
                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Zanr where nazev='" + listBox1.SelectedItem + "'";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    textBoxupravzanr.Text = ctecka[1].ToString();
                    id = (int)ctecka[0];
                    vybrany = ctecka[1].ToString();
                }
                pripojeni.Close();
            }
        }

        private void buttonodstran_Click(object sender, EventArgs e)
        {
            //Podle parametrů vybraných z listu odstraní žánr z databáze
            DialogResult moznost = MessageBox.Show("Chystáte se odstranit z databáze žánr, musíte spolu s ním odstranit i všechny filmy z této kategorie. Chcete i tak pokračovat? ",
                "POZOR", MessageBoxButtons.OKCancel);
            if (moznost == DialogResult.OK)
            {
                pripojeni = new SqlConnection(sestavovac.ConnectionString);

                using (pripojeni)
                {
                    pripojeni.Open();
                    prikaz.Connection = pripojeni;
                    prikaz.CommandText = "delete from Film where zanrid=" + id;
                    ovlivneno = prikaz.ExecuteNonQuery();

                    pripojeni.Close();
                    pripojeni.Open();

                    prikaz.CommandText = "delete from Zanr where nazev='" + listBox1.SelectedItem + "'";

                    textBoxupravzanr.Text = "";

                    ovlivneno = prikaz.ExecuteNonQuery();
                    pripojeni.Close();
                    NactiList();
                }
            }
            
        }

        private void buttonulozupravu_Click(object sender, EventArgs e)
        {
            // Podle proměnných upraví záznam v databázi žánrů
            if (!vybrany.Equals(textBoxupravzanr.Text) && !textBoxupravzanr.Text.Equals(""))
            {
                pripojeni = new SqlConnection(sestavovac.ConnectionString);

                using (pripojeni)
                {
                    pripojeni.Open();
                    prikaz.Connection = pripojeni;
                    prikaz.CommandText = "update Zanr set nazev='" + textBoxupravzanr.Text + "' where nazev='" + vybrany + "'";
                    ovlivneno = prikaz.ExecuteNonQuery();

                    pripojeni.Close();                   
                    textBoxupravzanr.Text = "";
                    NactiList();
                }
            }
        }
    }
}
