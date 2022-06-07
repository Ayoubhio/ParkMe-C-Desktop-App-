
namespace Projet
{
    partial class Reserver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.villebox = new MetroFramework.Controls.MetroComboBox();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Projet.DatabaseDataSet();
            this.projetDBDataSet = new Projet.ProjetDBDataSet();
            this.parkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkTableAdapter = new Projet.ProjetDBDataSetTableAdapters.ParkTableAdapter();
            this.villeTableAdapter = new Projet.DatabaseDataSetTableAdapters.VilleTableAdapter();
            this.villeParkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkTableAdapter1 = new Projet.DatabaseDataSetTableAdapters.ParkTableAdapter();
            this.parklabel = new MetroFramework.Controls.MetroLabel();
            this.n_TextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.addresseTextBox = new System.Windows.Forms.TextBox();
            this.matin_heureTextBox = new System.Windows.Forms.TextBox();
            this.nuit_heureTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Projet.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.titrelabel = new System.Windows.Forms.Label();
            this.parkbox = new MetroFramework.Controls.MetroComboBox();
            this.infolabel = new MetroFramework.Controls.MetroLabel();
            this.nlabel = new MetroFramework.Controls.MetroLabel();
            this.nomlabel = new MetroFramework.Controls.MetroLabel();
            this.addlabel = new MetroFramework.Controls.MetroLabel();
            this.matinlabel = new MetroFramework.Controls.MetroLabel();
            this.nuitlabel = new MetroFramework.Controls.MetroLabel();
            this.villelabel = new MetroFramework.Controls.MetroLabel();
            this.resebutton = new System.Windows.Forms.Button();
            this.precbutton = new System.Windows.Forms.Button();
            this.heurelabel = new MetroFramework.Controls.MetroLabel();
            this.heurebox = new MetroFramework.Controls.MetroComboBox();
            this.manulabel = new MetroFramework.Controls.MetroLabel();
            this.manubox = new MetroFramework.Controls.MetroComboBox();
            this.nomticketbox = new MetroFramework.Controls.MetroLabel();
            this.montantbbox = new MetroFramework.Controls.MetroLabel();
            this.montantbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeParkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet.Properties.Resources.image_0932339_20210430_ob_f4c67e_proteger_place_parking;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 770);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(24, 147);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(157, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Chosissez  Votre Ville :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // villebox
            // 
            this.villebox.DataSource = this.villeBindingSource;
            this.villebox.DisplayMember = "nom";
            this.villebox.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.villebox.FormattingEnabled = true;
            this.villebox.ItemHeight = 23;
            this.villebox.Location = new System.Drawing.Point(400, 140);
            this.villebox.Margin = new System.Windows.Forms.Padding(4);
            this.villebox.Name = "villebox";
            this.villebox.Size = new System.Drawing.Size(416, 29);
            this.villebox.TabIndex = 32;
            this.villebox.ValueMember = "Id";
            this.villebox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "Ville";
            this.villeBindingSource.DataSource = this.databaseDataSet;
            this.villeBindingSource.CurrentChanged += new System.EventHandler(this.villeBindingSource_CurrentChanged);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetDBDataSet
            // 
            this.projetDBDataSet.DataSetName = "ProjetDBDataSet";
            this.projetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkBindingSource
            // 
            this.parkBindingSource.DataMember = "Park";
            this.parkBindingSource.DataSource = this.projetDBDataSet;
            // 
            // parkTableAdapter
            // 
            this.parkTableAdapter.ClearBeforeFill = true;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // villeParkBindingSource
            // 
            this.villeParkBindingSource.DataMember = "Ville_Park";
            this.villeParkBindingSource.DataSource = this.villeBindingSource;
            // 
            // parkTableAdapter1
            // 
            this.parkTableAdapter1.ClearBeforeFill = true;
            // 
            // parklabel
            // 
            this.parklabel.AutoSize = true;
            this.parklabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.parklabel.CustomBackground = true;
            this.parklabel.CustomForeColor = true;
            this.parklabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.parklabel.Location = new System.Drawing.Point(24, 214);
            this.parklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parklabel.Name = "parklabel";
            this.parklabel.Size = new System.Drawing.Size(180, 19);
            this.parklabel.TabIndex = 37;
            this.parklabel.Text = "Choisissez Votre Parking :";
            this.parklabel.Visible = false;
            // 
            // n_TextBox
            // 
            this.n_TextBox.BackColor = System.Drawing.Color.Wheat;
            this.n_TextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villeParkBindingSource, "N*", true));
            this.n_TextBox.Enabled = false;
            this.n_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_TextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.n_TextBox.Location = new System.Drawing.Point(357, 342);
            this.n_TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.n_TextBox.Name = "n_TextBox";
            this.n_TextBox.ReadOnly = true;
            this.n_TextBox.Size = new System.Drawing.Size(371, 34);
            this.n_TextBox.TabIndex = 3;
            this.n_TextBox.Visible = false;
            this.n_TextBox.TextChanged += new System.EventHandler(this.n_TextBox_TextChanged);
            // 
            // nomTextBox
            // 
            this.nomTextBox.BackColor = System.Drawing.Color.Wheat;
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villeParkBindingSource, "nom", true));
            this.nomTextBox.Enabled = false;
            this.nomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTextBox.Location = new System.Drawing.Point(357, 399);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.ReadOnly = true;
            this.nomTextBox.Size = new System.Drawing.Size(371, 34);
            this.nomTextBox.TabIndex = 5;
            this.nomTextBox.Visible = false;
            // 
            // addresseTextBox
            // 
            this.addresseTextBox.BackColor = System.Drawing.Color.Wheat;
            this.addresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villeParkBindingSource, "addresse", true));
            this.addresseTextBox.Enabled = false;
            this.addresseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresseTextBox.Location = new System.Drawing.Point(357, 457);
            this.addresseTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addresseTextBox.Name = "addresseTextBox";
            this.addresseTextBox.ReadOnly = true;
            this.addresseTextBox.Size = new System.Drawing.Size(371, 34);
            this.addresseTextBox.TabIndex = 7;
            this.addresseTextBox.Visible = false;
            // 
            // matin_heureTextBox
            // 
            this.matin_heureTextBox.BackColor = System.Drawing.Color.Wheat;
            this.matin_heureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villeParkBindingSource, "matin/heure", true));
            this.matin_heureTextBox.Enabled = false;
            this.matin_heureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matin_heureTextBox.Location = new System.Drawing.Point(357, 517);
            this.matin_heureTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.matin_heureTextBox.Name = "matin_heureTextBox";
            this.matin_heureTextBox.ReadOnly = true;
            this.matin_heureTextBox.Size = new System.Drawing.Size(371, 34);
            this.matin_heureTextBox.TabIndex = 9;
            this.matin_heureTextBox.Visible = false;
            // 
            // nuit_heureTextBox
            // 
            this.nuit_heureTextBox.BackColor = System.Drawing.Color.Wheat;
            this.nuit_heureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villeParkBindingSource, "nuit/heure", true));
            this.nuit_heureTextBox.Enabled = false;
            this.nuit_heureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuit_heureTextBox.Location = new System.Drawing.Point(357, 578);
            this.nuit_heureTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nuit_heureTextBox.Name = "nuit_heureTextBox";
            this.nuit_heureTextBox.ReadOnly = true;
            this.nuit_heureTextBox.Size = new System.Drawing.Size(371, 34);
            this.nuit_heureTextBox.TabIndex = 11;
            this.nuit_heureTextBox.Visible = false;
            // 
            // villeTextBox
            // 
            this.villeTextBox.BackColor = System.Drawing.Color.Wheat;
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villeParkBindingSource, "ville", true));
            this.villeTextBox.Enabled = false;
            this.villeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeTextBox.Location = new System.Drawing.Point(357, 631);
            this.villeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.ReadOnly = true;
            this.villeTextBox.Size = new System.Drawing.Size(371, 34);
            this.villeTextBox.TabIndex = 13;
            this.villeTextBox.Visible = false;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ParkTableAdapter = null;
            this.tableAdapterManager.SpotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VilleTableAdapter = null;
            // 
            // titrelabel
            // 
            this.titrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titrelabel.BackColor = System.Drawing.Color.Transparent;
            this.titrelabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titrelabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.titrelabel.Location = new System.Drawing.Point(385, 6);
            this.titrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titrelabel.Name = "titrelabel";
            this.titrelabel.Size = new System.Drawing.Size(493, 79);
            this.titrelabel.TabIndex = 23;
            this.titrelabel.Text = "PARK ME";
            this.titrelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titrelabel.UseCompatibleTextRendering = true;
            // 
            // parkbox
            // 
            this.parkbox.DataSource = this.villeParkBindingSource;
            this.parkbox.DisplayMember = "nom";
            this.parkbox.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.parkbox.FormattingEnabled = true;
            this.parkbox.ItemHeight = 23;
            this.parkbox.Location = new System.Drawing.Point(400, 210);
            this.parkbox.Margin = new System.Windows.Forms.Padding(4);
            this.parkbox.Name = "parkbox";
            this.parkbox.Size = new System.Drawing.Size(410, 29);
            this.parkbox.TabIndex = 37;
            this.parkbox.ValueMember = "Id";
            this.parkbox.Visible = false;
            this.parkbox.SelectedIndexChanged += new System.EventHandler(this.parkbox_SelectedIndexChanged_1);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.infolabel.CustomBackground = true;
            this.infolabel.CustomForeColor = true;
            this.infolabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.infolabel.Location = new System.Drawing.Point(24, 289);
            this.infolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(234, 19);
            this.infolabel.TabIndex = 41;
            this.infolabel.Text = "Informations Sur Parking Choisis :";
            this.infolabel.Visible = false;
            this.infolabel.Click += new System.EventHandler(this.infolabel_Click);
            // 
            // nlabel
            // 
            this.nlabel.AutoSize = true;
            this.nlabel.BackColor = System.Drawing.Color.LightGray;
            this.nlabel.CustomBackground = true;
            this.nlabel.CustomForeColor = true;
            this.nlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nlabel.Location = new System.Drawing.Point(66, 342);
            this.nlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nlabel.Name = "nlabel";
            this.nlabel.Size = new System.Drawing.Size(34, 19);
            this.nlabel.TabIndex = 42;
            this.nlabel.Text = "N* :";
            this.nlabel.Visible = false;
            // 
            // nomlabel
            // 
            this.nomlabel.AutoSize = true;
            this.nomlabel.BackColor = System.Drawing.Color.LightGray;
            this.nomlabel.CustomBackground = true;
            this.nomlabel.CustomForeColor = true;
            this.nomlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nomlabel.Location = new System.Drawing.Point(66, 399);
            this.nomlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomlabel.Name = "nomlabel";
            this.nomlabel.Size = new System.Drawing.Size(50, 19);
            this.nomlabel.TabIndex = 43;
            this.nomlabel.Text = "Nom :";
            this.nomlabel.Visible = false;
            // 
            // addlabel
            // 
            this.addlabel.AutoSize = true;
            this.addlabel.BackColor = System.Drawing.Color.LightGray;
            this.addlabel.CustomBackground = true;
            this.addlabel.CustomForeColor = true;
            this.addlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.addlabel.Location = new System.Drawing.Point(66, 458);
            this.addlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(79, 19);
            this.addlabel.TabIndex = 44;
            this.addlabel.Text = "Addresse :";
            this.addlabel.Visible = false;
            // 
            // matinlabel
            // 
            this.matinlabel.AutoSize = true;
            this.matinlabel.BackColor = System.Drawing.Color.LightGray;
            this.matinlabel.CustomBackground = true;
            this.matinlabel.CustomForeColor = true;
            this.matinlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.matinlabel.Location = new System.Drawing.Point(66, 516);
            this.matinlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matinlabel.Name = "matinlabel";
            this.matinlabel.Size = new System.Drawing.Size(130, 19);
            this.matinlabel.TabIndex = 45;
            this.matinlabel.Text = "Prix : matin/heure";
            this.matinlabel.Visible = false;
            // 
            // nuitlabel
            // 
            this.nuitlabel.AutoSize = true;
            this.nuitlabel.BackColor = System.Drawing.Color.LightGray;
            this.nuitlabel.CustomBackground = true;
            this.nuitlabel.CustomForeColor = true;
            this.nuitlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nuitlabel.Location = new System.Drawing.Point(66, 582);
            this.nuitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nuitlabel.Name = "nuitlabel";
            this.nuitlabel.Size = new System.Drawing.Size(117, 19);
            this.nuitlabel.TabIndex = 46;
            this.nuitlabel.Text = "Prix : nuit/heure";
            this.nuitlabel.Visible = false;
            // 
            // villelabel
            // 
            this.villelabel.AutoSize = true;
            this.villelabel.BackColor = System.Drawing.Color.LightGray;
            this.villelabel.CustomBackground = true;
            this.villelabel.CustomForeColor = true;
            this.villelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.villelabel.Location = new System.Drawing.Point(64, 630);
            this.villelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.villelabel.Name = "villelabel";
            this.villelabel.Size = new System.Drawing.Size(46, 19);
            this.villelabel.TabIndex = 47;
            this.villelabel.Text = "Ville :";
            this.villelabel.Visible = false;
            // 
            // resebutton
            // 
            this.resebutton.BackColor = System.Drawing.Color.Transparent;
            this.resebutton.Enabled = false;
            this.resebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resebutton.ForeColor = System.Drawing.Color.Black;
            this.resebutton.Image = global::Projet.Properties.Resources.log_in_1;
            this.resebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resebutton.Location = new System.Drawing.Point(792, 686);
            this.resebutton.Name = "resebutton";
            this.resebutton.Size = new System.Drawing.Size(208, 64);
            this.resebutton.TabIndex = 48;
            this.resebutton.Text = "Reserver :";
            this.resebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resebutton.UseVisualStyleBackColor = false;
            this.resebutton.Click += new System.EventHandler(this.resebutton_Click);
            // 
            // precbutton
            // 
            this.precbutton.BackColor = System.Drawing.Color.Transparent;
            this.precbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.precbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.precbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.precbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precbutton.ForeColor = System.Drawing.Color.Black;
            this.precbutton.Image = global::Projet.Properties.Resources.log_in_1;
            this.precbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.precbutton.Location = new System.Drawing.Point(336, 686);
            this.precbutton.Name = "precbutton";
            this.precbutton.Size = new System.Drawing.Size(208, 64);
            this.precbutton.TabIndex = 49;
            this.precbutton.Text = "Menu :";
            this.precbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.precbutton.UseVisualStyleBackColor = false;
            this.precbutton.Click += new System.EventHandler(this.precbutton_Click);
            // 
            // heurelabel
            // 
            this.heurelabel.AutoSize = true;
            this.heurelabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.heurelabel.CustomBackground = true;
            this.heurelabel.CustomForeColor = true;
            this.heurelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.heurelabel.Location = new System.Drawing.Point(878, 280);
            this.heurelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heurelabel.Name = "heurelabel";
            this.heurelabel.Size = new System.Drawing.Size(191, 19);
            this.heurelabel.TabIndex = 50;
            this.heurelabel.Text = "Choisir le nombre d\'heure :";
            this.heurelabel.Visible = false;
            // 
            // heurebox
            // 
            this.heurebox.FormattingEnabled = true;
            this.heurebox.ItemHeight = 23;
            this.heurebox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.heurebox.Location = new System.Drawing.Point(948, 320);
            this.heurebox.Name = "heurebox";
            this.heurebox.Size = new System.Drawing.Size(218, 29);
            this.heurebox.TabIndex = 51;
            this.heurebox.Visible = false;
            this.heurebox.SelectedIndexChanged += new System.EventHandler(this.heurebox_SelectedIndexChanged);
            // 
            // manulabel
            // 
            this.manulabel.AutoSize = true;
            this.manulabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.manulabel.CustomBackground = true;
            this.manulabel.CustomForeColor = true;
            this.manulabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.manulabel.Location = new System.Drawing.Point(878, 376);
            this.manulabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manulabel.Name = "manulabel";
            this.manulabel.Size = new System.Drawing.Size(121, 19);
            this.manulabel.TabIndex = 52;
            this.manulabel.Text = "Matin ou la nuit :";
            this.manulabel.Visible = false;
            // 
            // manubox
            // 
            this.manubox.FormattingEnabled = true;
            this.manubox.ItemHeight = 23;
            this.manubox.Items.AddRange(new object[] {
            "Matin",
            "Nuit"});
            this.manubox.Location = new System.Drawing.Point(948, 413);
            this.manubox.Name = "manubox";
            this.manubox.Size = new System.Drawing.Size(218, 29);
            this.manubox.TabIndex = 53;
            this.manubox.Visible = false;
            this.manubox.SelectedIndexChanged += new System.EventHandler(this.manubox_SelectedIndexChanged);
            // 
            // nomticketbox
            // 
            this.nomticketbox.AutoSize = true;
            this.nomticketbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nomticketbox.CustomBackground = true;
            this.nomticketbox.CustomForeColor = true;
            this.nomticketbox.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nomticketbox.Location = new System.Drawing.Point(878, 66);
            this.nomticketbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomticketbox.Name = "nomticketbox";
            this.nomticketbox.Size = new System.Drawing.Size(63, 19);
            this.nomticketbox.TabIndex = 56;
            this.nomticketbox.Text = "*********";
            // 
            // montantbbox
            // 
            this.montantbbox.AutoSize = true;
            this.montantbbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.montantbbox.CustomBackground = true;
            this.montantbbox.CustomForeColor = true;
            this.montantbbox.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.montantbbox.Location = new System.Drawing.Point(882, 474);
            this.montantbbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.montantbbox.Name = "montantbbox";
            this.montantbbox.Size = new System.Drawing.Size(185, 19);
            this.montantbbox.TabIndex = 57;
            this.montantbbox.Text = "Montant total (TVA inclus):";
            this.montantbbox.Visible = false;
            // 
            // montantbox
            // 
            this.montantbox.BackColor = System.Drawing.Color.Khaki;
            this.montantbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.montantbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villeParkBindingSource, "N*", true));
            this.montantbox.Enabled = false;
            this.montantbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.montantbox.Location = new System.Drawing.Point(942, 517);
            this.montantbox.Margin = new System.Windows.Forms.Padding(6);
            this.montantbox.Name = "montantbox";
            this.montantbox.ReadOnly = true;
            this.montantbox.Size = new System.Drawing.Size(224, 34);
            this.montantbox.TabIndex = 58;
            this.montantbox.Visible = false;
            this.montantbox.TextChanged += new System.EventHandler(this.montantbox_TextChanged);
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 813);
            this.Controls.Add(this.montantbox);
            this.Controls.Add(this.montantbbox);
            this.Controls.Add(this.nomticketbox);
            this.Controls.Add(this.manubox);
            this.Controls.Add(this.manulabel);
            this.Controls.Add(this.heurebox);
            this.Controls.Add(this.heurelabel);
            this.Controls.Add(this.precbutton);
            this.Controls.Add(this.resebutton);
            this.Controls.Add(this.villelabel);
            this.Controls.Add(this.nuitlabel);
            this.Controls.Add(this.matinlabel);
            this.Controls.Add(this.addlabel);
            this.Controls.Add(this.nomlabel);
            this.Controls.Add(this.nlabel);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.parkbox);
            this.Controls.Add(this.villeTextBox);
            this.Controls.Add(this.nuit_heureTextBox);
            this.Controls.Add(this.matin_heureTextBox);
            this.Controls.Add(this.n_TextBox);
            this.Controls.Add(this.titrelabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.parklabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.addresseTextBox);
            this.Controls.Add(this.villebox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Reserver";
            this.Padding = new System.Windows.Forms.Padding(20, 111, 20, 20);
            this.Load += new System.EventHandler(this.Reserver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeParkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox villebox;
        private ProjetDBDataSet projetDBDataSet;
        private System.Windows.Forms.BindingSource parkBindingSource;
        private ProjetDBDataSetTableAdapters.ParkTableAdapter parkTableAdapter;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private DatabaseDataSetTableAdapters.VilleTableAdapter villeTableAdapter;
        private System.Windows.Forms.BindingSource villeParkBindingSource;
        private DatabaseDataSetTableAdapters.ParkTableAdapter parkTableAdapter1;
        private MetroFramework.Controls.MetroLabel parklabel;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label titrelabel;
        private System.Windows.Forms.TextBox n_TextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox addresseTextBox;
        private System.Windows.Forms.TextBox matin_heureTextBox;
        private System.Windows.Forms.TextBox nuit_heureTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private MetroFramework.Controls.MetroComboBox parkbox;
        private MetroFramework.Controls.MetroLabel infolabel;
        private MetroFramework.Controls.MetroLabel nlabel;
        private MetroFramework.Controls.MetroLabel nomlabel;
        private MetroFramework.Controls.MetroLabel addlabel;
        private MetroFramework.Controls.MetroLabel matinlabel;
        private MetroFramework.Controls.MetroLabel nuitlabel;
        private MetroFramework.Controls.MetroLabel villelabel;
        private System.Windows.Forms.Button resebutton;
        private System.Windows.Forms.Button precbutton;
        private MetroFramework.Controls.MetroLabel heurelabel;
        private MetroFramework.Controls.MetroComboBox heurebox;
        private MetroFramework.Controls.MetroLabel manulabel;
        private MetroFramework.Controls.MetroComboBox manubox;
        private MetroFramework.Controls.MetroLabel nomticketbox;
        private MetroFramework.Controls.MetroLabel montantbbox;
        private System.Windows.Forms.TextBox montantbox;
    }
}