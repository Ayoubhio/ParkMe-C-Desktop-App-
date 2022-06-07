using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Projet
{
    public partial class Payer : MetroForm
    {
        /*SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");*/
        SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THINKPAD\Downloads\Projet\Projet-pay\Projet\Projet\Database.mdf;Integrated Security=True");
        public Payer()
        {
            InitializeComponent();
        }

        private void Payer_Load(object sender, EventArgs e)
        {
            nomticketbox.Text = " Identifiant : " + Login.nom_ticket;
            //la boutton
            resebutton.Parent = pictureBox1;
            resebutton.BackColor = Color.Transparent;
            resebutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            resebutton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            precbutton.Parent = pictureBox1;
            precbutton.BackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseOverBackColor = Color.Transparent;


        }

        private void parklabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
        }
        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Leave(object sender, EventArgs e)
        {
            
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            resebutton.Enabled = true;
        }

        private void resebutton_Click(object sender, EventArgs e)
        {
            string disp = "non";
            string park = Login.nomPark_ticket;
            string num = Login.numSpot_ticket;
            Regex rgx = new Regex(@"^[a-zA-Z ]+$");
            Regex rgx1 = new Regex(@"^[0-9]{16}");
            Regex rgx2 = new Regex(@"^[0-9]{3}");

            if (nombox.Text != "" && cartebox.Text != "" && verifibox.Text != "") //tester si tous est nrempli
            {
                if (rgx.IsMatch(nombox.Text) && rgx1.IsMatch(cartebox.Text) && rgx2.IsMatch(verifibox.Text))
                {
                    try
                    {
                        cnx.Open();
                        SqlCommand cmd1 = cnx.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = " update [Spot] set dispo ='" + disp + "' where numero ='" + num + "' and park = '" + park + "'";
                        cmd1.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cnx.Close();
                    }
                    /* MessageBox.Show("voila les infos de votre reservation :le nom du parking : " + park+" le numero de votre place : "+num);*/
                    MessageBox.Show("Votre ticket est pret !!");


                    try
                    {
                        //Remplissage de la base de donnee
                        int id_user =Login.idUser_ticket;
                        string nom_user =Login.nom_ticket;
                        string email_user = Login.email_ticket;
                        int phone_user = Login.phone_ticket;
                        string nom_park =Login.nomPark_ticket ;
                        string addresse_park = Login.adressePark_ticket;
                        string numero_spot = Login.numSpot_ticket;
                        string ville = Login.ville_ticket;
                        int nombre_heure = Login.nombreHeure_ticket;
                        double montant = Login.montantTotal_ticket;

                     cnx.Open();
                     SqlCommand cmd1 = cnx.CreateCommand();
                     cmd1.CommandType = CommandType.Text;
                     cmd1.CommandText =
                    "insert into [Ticket] (id_user,nom_user,email_user,phone_user,nom_park,addresse_park,numero_spot,ville,nombre_heure,montant) values ('" + id_user + "','" + nom_user + "','" + email_user + "','" + phone_user + "' , '"+nom_park+"' , '"+addresse_park+"' , '"+numero_spot+"' ,'"+ville+"' , '"+nombre_heure+"' , '"+montant+"')";
                     cmd1.ExecuteNonQuery();

                     /*MessageBox.Show("succeded insert");*/
                     cnx.Close();
                       this.Hide();
                       using (Facture frm = new Facture())
                        {
                            frm.ShowDialog();
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("qlq chose qui ne marche pas");
                    }

                }
                else if (!rgx.IsMatch(nombox.Text))
                {
                    MessageBox.Show("le nom doit contenir que des caracters");
                }
                else if (!rgx1.IsMatch(cartebox.Text))
                {
                    MessageBox.Show("Un numéro de catre est de 14 chiffres, EX : 18xxxxxxxxxxxx");
                }
                else if (!rgx2.IsMatch(verifibox.Text))
                {
                    MessageBox.Show("Un code de verification est de 3 chiffres, EX : XXX");
                }
            }
            else
            {
                MessageBox.Show("Veuiillez remplir toutes les cases ");
            }
            




        }

        private void precbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Menu frm = new Menu())
            {
                frm.ShowDialog();
            }
        }
    }
}
