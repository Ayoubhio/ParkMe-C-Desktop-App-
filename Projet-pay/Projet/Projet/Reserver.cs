using MetroFramework.Forms;
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

namespace Projet
{
    public partial class Reserver : MetroForm
    {
        /* SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");*/
        SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THINKPAD\Downloads\Projet\Projet-pay\Projet\Projet\Database.mdf;Integrated Security=True");

        public Reserver()
        {
            InitializeComponent();
        }

        private void Reserver_Load(object sender, EventArgs e)
        {
            nomticketbox.Text = " Identifiant : " + Login.nom_ticket;
            // TODO: cette ligne de code charge les données dans la table 'databaseDataSet.Park'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parkTableAdapter1.Fill(this.databaseDataSet.Park);
            // TODO: cette ligne de code charge les données dans la table 'databaseDataSet.Ville'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villeTableAdapter.Fill(this.databaseDataSet.Ville);
            // TODO: cette ligne de code charge les données dans la table 'projetDBDataSet.Park'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parkTableAdapter.Fill(this.projetDBDataSet.Park);
            titrelabel.Parent = pictureBox1;
            titrelabel.BackColor = Color.Transparent;

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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            parklabel.Visible = true;
            parkbox.Visible = true;

        }

        private void parkbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void villeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void parklabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addresseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void n_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void parkbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            infolabel.Visible = true;

            //les textbox
            villeTextBox.Visible = true;
            nuit_heureTextBox.Visible = true;
            matin_heureTextBox.Visible = true;
            addresseTextBox.Visible = true;
            nomTextBox.Visible = true;
            n_TextBox.Visible = true;

            //les labels
            nlabel.Visible = true;
            nomlabel.Visible = true;
            matinlabel.Visible = true;
            addlabel.Visible = true;
            nuitlabel.Visible = true;
            villelabel.Visible = true;

            //les buttons
            

            heurelabel.Visible = true;
            heurebox.Visible = true;
            
            
        }

        private void infolabel_Click(object sender, EventArgs e)
        {

        }

        private void precbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Menu frm = new Menu())
            {
                frm.ShowDialog();
            }
        }

        private void resebutton_Click(object sender, EventArgs e)
        {
            string disp = "oui";
            
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select numero,ville,park from [Spot] where park like '" + nomTextBox.Text + "' and dispo like '"+disp+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string numero = "";
                string ville = "";
                string park = "";
                while (reader.Read())
                {
                    numero = reader.GetValue(0).ToString();
                    ville = reader.GetValue(1).ToString();
                    park = reader.GetValue(2).ToString();
                    break;
                }

                //remplir les sessions
                Login.nomPark_ticket = park;
                Login.ville_ticket = ville;
                Login.numSpot_ticket = numero;
                Login.adressePark_ticket = addresseTextBox.Text;
                Login.nombreHeure_ticket = Int16.Parse(heurebox.Text);
                cnx.Close();

                MessageBox.Show("Parfait maintenant vous allez effectuer votre paiment");
                this.Hide();
                using (Payer frm = new Payer())
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Desole mais tous les spot de ce parking sont pleins");
            }
            

        }

        private void heurebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            manulabel.Visible = true;
            manubox.Visible = true;
        }

        private void manubox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resebutton.Enabled = true;
            montantbbox.Visible = true;
            montantbox.Visible = true;

            double nbr_heure = Convert.ToDouble(heurebox.Text);
            string prix_matin1 = matin_heureTextBox.Text;
            string prix_nuit1 = nuit_heureTextBox.Text;
            double mnt = 0;


            if (manubox.Text == "Matin")
            {
                double prix = Convert.ToDouble(prix_matin1);
                mnt = Math.Round((prix * nbr_heure) + (prix*(float)0.2) , 2);
            }
            else if (manubox.Text == "Nuit")
            {
                double prix = Convert.ToDouble(prix_nuit1);
                mnt = Math.Round((prix * nbr_heure) + ( prix*(float)0.2) , 2);
            }
            //remplir une session

            Login.montantTotal_ticket = mnt;
            montantbox.Text = mnt.ToString() + " DH";

            //remplir les sessions


        }

        private void montantbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
