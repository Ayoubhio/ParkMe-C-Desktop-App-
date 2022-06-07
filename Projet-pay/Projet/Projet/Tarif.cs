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
    public partial class Tarif : MetroForm
    {
        /* SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");*/
        SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THINKPAD\Downloads\Projet\Projet-pay\Projet\Projet\Database.mdf;Integrated Security=True");
        public Tarif()
        {
            InitializeComponent();
        }

        private void Tarif_Load(object sender, EventArgs e)
        {
            nomticketbox.Text = " Identifiant : " + Login.nom_ticket;
            // TODO: This line of code loads data into the 'projetDBDataSet.Park' table. You can move, or remove it, as needed.
            this.parkTableAdapter.Fill(this.projetDBDataSet.Park);
            titrelabel.Parent = pictureBox1;
            titrelabel.BackColor = Color.Transparent;

            precbutton.Parent = pictureBox1;
            precbutton.BackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            precbutton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            resebutton.Parent = pictureBox1;
            resebutton.BackColor = Color.Transparent;
            resebutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            resebutton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            this.Hide();
            using (Reserver frm = new Reserver())
            {
                frm.ShowDialog();
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Park] where ville like '" + villebox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dba = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, cnx);
            dataAdapter.Fill(dba);
            metrogrid1.DataSource = dba;
            cnx.Close();
            metrogrid1.Visible = true;
        }

        private void metrogrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
