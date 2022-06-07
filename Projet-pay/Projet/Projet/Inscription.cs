using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Inscription : MetroForm
    {

        /* SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");*/
        SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THINKPAD\Downloads\Projet\Projet-pay\Projet\Projet\Database.mdf;Integrated Security=True");
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            titrelabel.Parent = pictureBox1;
            titrelabel.BackColor = Color.Transparent;

            maillabel.Parent = pictureBox1;
            maillabel.BackColor = System.Drawing.Color.Transparent;

            passlabel.Parent = pictureBox1;
            passlabel.BackColor = System.Drawing.Color.Transparent;

            nomlabel.Parent = pictureBox1;
            nomlabel.BackColor = System.Drawing.Color.Transparent;

            phonelabel.Parent = pictureBox1;
            phonelabel.BackColor = System.Drawing.Color.Transparent;

            signupbutton.Parent = pictureBox1;
            signupbutton.BackColor = Color.Transparent;
            signupbutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            signupbutton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            precbutton.Parent = pictureBox1;
            precbutton.BackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void precbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login frm = new Login())
            {
                frm.ShowDialog();
            }
        }

        private void titrelabel_Click(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            if (nombox.Text != "" && emailbox.Text != "" && passbox.Text != "" && phonebox.Text !="") //tester si tous est numeric
            {
                //l'email
                Regex rgx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Regex rgx1 = new Regex(@"^[a-zA-Z ]+$");


                try
                {
                    if (rgx.IsMatch(emailbox.Text) && rgx1.IsMatch(nombox.Text))
                    {
                        //la connexion
                        cnx.Open();
                        SqlCommand cmd = cnx.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText =
                            "insert into [User] (name,email,phone,password) values ('" +nombox.Text + "','" + emailbox.Text + "','" + phonebox.Text + "','" + passbox.Text +"')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("succeded insert");
                        cnx.Close();

                        this.Hide();
                        using (Login frm = new Login())
                        {
                            frm.ShowDialog();
                        }

                    }
                    else if (!rgx.IsMatch(emailbox.Text))
                    {
                        MessageBox.Show("L'email entree ne respecte pas la forme mentionne voila un exemple :nom@gmail.com");
                    }
                    else if (!phonebox.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Le numero de telephone doit etre numeric");
                    }
                    else if (!rgx1.IsMatch(nombox.Text))
                    {
                        MessageBox.Show("Le nom doit etre compose que du lettres");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("qlq chose qui ne marche pas");
                }
            }
            else
            {
                MessageBox.Show("Veuiillez remplir svp les champs");

            }
        }

        
    }
}
