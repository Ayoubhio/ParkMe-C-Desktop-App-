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
    public partial class Login : MetroForm
    {
        public static int idUser_ticket = 0;
        public static string nom_ticket = "";
        public static string email_ticket = "";
        public static int phone_ticket = 0;
        public static string nomPark_ticket = "";
        public static string adressePark_ticket = "";
        public static string numSpot_ticket = "";
        public static string ville_ticket = "";
        public static int nombreHeure_ticket = 0;
        public static double montantTotal_ticket = 0.0;


        public static string SetValueForText1 = "";
        /*SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");*/
        SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THINKPAD\Downloads\Projet\Projet-pay\Projet\Projet\Database.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            titrelabel.Parent = pictureBox1;
            titrelabel.BackColor = Color.Transparent;

            signinButton1.Parent = pictureBox1;
            signinButton1.BackColor = Color.Transparent;
            signinButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            signinButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            signupbutton.Parent = pictureBox1;
            signupbutton.BackColor = Color.Transparent;
            signupbutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            signupbutton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            maillabel.Parent = pictureBox1;
            maillabel.BackColor = System.Drawing.Color.Transparent;

            passlabel.Parent = pictureBox1;
            passlabel.BackColor = System.Drawing.Color.Transparent;

        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Inscription frm = new Inscription())
            {
                frm.ShowDialog();
            }
        }

        private void signinButton1_Click(object sender, EventArgs e)
        {
            if (emailbox.Text != "" && passbox.Text != "") //tester si tous est nrempli
            {
                try
                {
                    string nom = "";
                    //la connexion
                    cnx.Open();
                    SqlCommand cmd = cnx.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT id,name,phone FROM [User] where email ='" + emailbox.Text + "' AND password ='" + passbox.Text + "'";
                    SqlDataReader srd = cmd.ExecuteReader();
                    
                    if (srd.Read())
                    {
                        nom = srd.GetValue(1).ToString();
                        MessageBox.Show("Login sucess Welcome "+nom );

                        //remplir les essions 
                        idUser_ticket = Int16.Parse(srd.GetValue(0).ToString());
                        phone_ticket = Int32.Parse(srd.GetValue(2).ToString());
                        nom_ticket = nom;
                        email_ticket = emailbox.Text;
                        this.Hide();
                        using (Menu frm = new Menu())
                        {
                            frm.ShowDialog();
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login please check username and password");
                    }

                    cnx.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("qlq chose qui ne marche pas");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir svp les champs");
            }
        }

        private void titrelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
