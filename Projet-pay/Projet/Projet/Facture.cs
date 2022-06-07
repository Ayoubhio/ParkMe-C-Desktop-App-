using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Projet
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            /*SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");*/
            SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THINKPAD\Downloads\Projet\Projet-pay\Projet\Projet\Database.mdf;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ticket where nom_park = '" +Login.nomPark_ticket +"' and numero_spot = '" + Login.numSpot_ticket+"' ", cnx);
            DataSet1 ds1 = new DataSet1();
            CrystalReport1 cr = new CrystalReport1();
            da.Fill(ds1, "Ticket");
            cr.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }

        private void Facture_Load(object sender, EventArgs e)
        {

        }
    }
}
