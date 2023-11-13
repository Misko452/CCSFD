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
    public partial class Reziseri : Form
    {
        public Reziseri()
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

        string jmeno = "";
        string prijmeni = "";

        bool proslo = true;
        int id;
        int ovlivneno;

        string vjmeno;
        string vprijmeni;

        private void buttonPridej_Click(object sender, EventArgs e)
        {
            //Načte proměnné pro přdání nového režiséra
            jmeno = textBoxJmeno.Text;
            prijmeni = textBoxPrijmeni.Text;

            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            //Ověří správnost zadaných dat
            if (jmeno == "" || prijmeni == "")
            {
                proslo = false;
            }

            using (pripojeni)
            {
                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Reziser";
                ctecka = prikaz.ExecuteReader();

                //Pojistka proti duplikátům
                while (ctecka.Read())
                {
                    if (ctecka[1] + " " + ctecka[2] == jmeno + " " + prijmeni)
                    {
                        proslo = false;
                    }
                }

                pripojeni.Close();
                pripojeni.Open();

                //přidá režiséra
                if (proslo)
                {
                    prikaz.CommandText = "insert into Reziser(jmeno,prijmeni) values (@jmeno, @prijmeni)";

                    prikaz.Parameters.AddWithValue("@jmeno", jmeno);
                    prikaz.Parameters.AddWithValue("@prijmeni", prijmeni);

                    ovlivneno = prikaz.ExecuteNonQuery();
                    
                }
                else
                {
                    proslo = true;
                }

                pripojeni.Close();

                textBoxJmeno.Text = "";
                textBoxPrijmeni.Text = "";

                NactiList();
            }
        }

        public void NactiList()
        {
            //Často volaná metoda pro refresh listu režisérů
            listBox1.Items.Clear();
            using (pripojeni)
            {

                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Reziser";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    listBox1.Items.Add(ctecka[1] + " " + ctecka[2]);
                }

                pripojeni.Close();
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Načte potřebné proměnné podle toho, jakého režiséra si z listu zvolíme
            pripojeni = new SqlConnection(sestavovac.ConnectionString);

            using (pripojeni)
            {
                pripojeni.Open();
                prikaz.Connection = pripojeni;
                prikaz.CommandText = "select * from Reziser where concat([jmeno], ' ',[prijmeni]) ='" + listBox1.SelectedItem + "'";
                ctecka = prikaz.ExecuteReader();

                while (ctecka.Read())
                {
                    textBoxupravjmeno.Text = ctecka[1].ToString();
                    textBoxupravprijmeni.Text = ctecka[2].ToString();
                    id = id = (int)ctecka[0];
                    vprijmeni = ctecka[2].ToString();
                    vjmeno = ctecka[1].ToString();
                }
                pripojeni.Close();
            }
        }

        private void buttonodstran_Click(object sender, EventArgs e)
        {
            //Podle parametrů vybraných z listu odstraní režiséra z databáze
            DialogResult moznost = MessageBox.Show("Chystáte se odstranit z databáze Režiséra, je třeba odstranit i filmy, které natočil. Chcete i tak pokračovat? "
                , "POZOR!", MessageBoxButtons.OKCancel);
            if (moznost == DialogResult.OK)
            {
                pripojeni = new SqlConnection(sestavovac.ConnectionString);

                using (pripojeni)
                {
                    pripojeni.Open();
                    prikaz.Connection = pripojeni;
                    prikaz.CommandText = "delete from Film where reziserid=" + id;
                    ovlivneno = prikaz.ExecuteNonQuery();

                    pripojeni.Close();
                    pripojeni.Open();

                    prikaz.CommandText = "delete from Reziser where concat([jmeno], ' ',[prijmeni]) ='" + listBox1.SelectedItem + "'";

                    textBoxupravjmeno.Text = "";
                    textBoxupravprijmeni.Text = "";

                    ovlivneno = prikaz.ExecuteNonQuery();
                    pripojeni.Close();
                    NactiList();
                }
            }

        }

        private void buttonuloz_Click(object sender, EventArgs e)
        {
            //Podle proměnných upraví záznam v databázi režisérů
            if (!((vjmeno + " " + vprijmeni).Equals(textBoxupravjmeno.Text + " " + textBoxupravprijmeni.Text)) && 
                !(textBoxupravjmeno.Text.Equals("")) && !(textBoxupravprijmeni.Text.Equals("")))
            {
                pripojeni = new SqlConnection(sestavovac.ConnectionString);

                using (pripojeni)
                {
                    pripojeni.Open();
                    prikaz.Connection = pripojeni;
                    prikaz.CommandText = "update Reziser set jmeno='" + textBoxupravjmeno.Text + "', prijmeni= '" + textBoxupravprijmeni.Text
                        + "' where concat([jmeno], ' ',[prijmeni]) = '" + vjmeno + " " + vprijmeni + "'";
                    ovlivneno = prikaz.ExecuteNonQuery();

                    pripojeni.Close();
                    textBoxupravjmeno.Text = "";
                    textBoxupravprijmeni.Text = "";
                    NactiList();
                }
            }
        }
    }
}
