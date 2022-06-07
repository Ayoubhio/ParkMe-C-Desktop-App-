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
    public partial class Historique : MetroForm
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THINKPAD\Downloads\Projet\Projet-pay\Projet\Projet\Database.mdf;Integrated Security=True");
        public Historique()
        {
            InitializeComponent();
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.databaseDataSet1.Ticket);
            nomticketbox.Text = " Identifiant : " + Login.nom_ticket;

            precbutton.Parent = pictureBox1;
            precbutton.BackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //remplissage du grid

            try
            {
                int id = Login.idUser_ticket;
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Ticket] where id_user = '"+ id+"' ";
                cmd.ExecuteNonQuery();
                DataTable dba = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, cnx);
                dataAdapter.Fill(dba);
                datagrid.DataSource = dba;
                cnx.Close();
            }
            catch
            {

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
