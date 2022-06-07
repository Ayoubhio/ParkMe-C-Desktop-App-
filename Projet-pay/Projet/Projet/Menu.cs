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

namespace Projet
{
    public partial class Menu : MetroForm
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            nomticketbox.Text = " Identifiant : " + Login.nom_ticket;
            titrelabel.Parent = pictureBox1;
            titrelabel.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void precbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using ( Tarif frm = new Tarif())
            { 
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Reserver frm = new Reserver())
            {
                frm.ShowDialog();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void histbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Historique frm = new Historique())
            {
                frm.ShowDialog();
            }
        }
    }
}
