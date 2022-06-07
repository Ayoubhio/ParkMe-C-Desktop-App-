
namespace Projet
{
    partial class Tarif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarif));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titrelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.precbutton = new System.Windows.Forms.Button();
            this.resebutton = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.villebox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metrogrid1 = new System.Windows.Forms.DataGridView();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matinheureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuitheureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetDBDataSet = new Projet.ProjetDBDataSet();
            this.parkTableAdapter = new Projet.ProjetDBDataSetTableAdapters.ParkTableAdapter();
            this.nomticketbox = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metrogrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // titrelabel
            // 
            this.titrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titrelabel.BackColor = System.Drawing.Color.Transparent;
            this.titrelabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titrelabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.titrelabel.Location = new System.Drawing.Point(358, 8);
            this.titrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titrelabel.Name = "titrelabel";
            this.titrelabel.Size = new System.Drawing.Size(510, 83);
            this.titrelabel.TabIndex = 23;
            this.titrelabel.Text = "PARK ME";
            this.titrelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titrelabel.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 706);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.precbutton.Location = new System.Drawing.Point(997, 639);
            this.precbutton.Name = "precbutton";
            this.precbutton.Size = new System.Drawing.Size(208, 64);
            this.precbutton.TabIndex = 25;
            this.precbutton.Text = "Precedent :";
            this.precbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.precbutton.UseVisualStyleBackColor = false;
            this.precbutton.Click += new System.EventHandler(this.precbutton_Click);
            // 
            // resebutton
            // 
            this.resebutton.BackColor = System.Drawing.Color.Transparent;
            this.resebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resebutton.ForeColor = System.Drawing.Color.Black;
            this.resebutton.Image = global::Projet.Properties.Resources.log_in_1;
            this.resebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resebutton.Location = new System.Drawing.Point(702, 639);
            this.resebutton.Name = "resebutton";
            this.resebutton.Size = new System.Drawing.Size(208, 64);
            this.resebutton.TabIndex = 26;
            this.resebutton.Text = "Reserver :";
            this.resebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resebutton.UseVisualStyleBackColor = false;
            this.resebutton.Click += new System.EventHandler(this.resebutton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroLabel1.Location = new System.Drawing.Point(24, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(391, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Les tarifs varie selon les villes et les locales des parkings :";
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // villebox
            // 
            this.villebox.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.villebox.FormattingEnabled = true;
            this.villebox.ItemHeight = 23;
            this.villebox.Items.AddRange(new object[] {
            "Casa Blanca",
            "Marrakech",
            "Tanger"});
            this.villebox.Location = new System.Drawing.Point(314, 245);
            this.villebox.Name = "villebox";
            this.villebox.Size = new System.Drawing.Size(253, 29);
            this.villebox.TabIndex = 28;
            this.villebox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(16, 255);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Chosiir votre ville :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroLabel3.Location = new System.Drawing.Point(24, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(191, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Tarif jour de 08h00 a 19h59";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroLabel4.Location = new System.Drawing.Point(24, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(189, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Tarif nuit de 20h00 a 07h59";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metrogrid1
            // 
            this.metrogrid1.AllowUserToAddRows = false;
            this.metrogrid1.AllowUserToDeleteRows = false;
            this.metrogrid1.AutoGenerateColumns = false;
            this.metrogrid1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.metrogrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metrogrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.matinheureDataGridViewTextBoxColumn,
            this.nuitheureDataGridViewTextBoxColumn,
            this.addresseDataGridViewTextBoxColumn,
            this.Ville,
            this.Column1});
            this.metrogrid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metrogrid1.DataSource = this.parkBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metrogrid1.DefaultCellStyle = dataGridViewCellStyle1;
            this.metrogrid1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.metrogrid1.Location = new System.Drawing.Point(0, 414);
            this.metrogrid1.Name = "metrogrid1";
            this.metrogrid1.ReadOnly = true;
            this.metrogrid1.RowHeadersVisible = false;
            this.metrogrid1.RowHeadersWidth = 72;
            this.metrogrid1.RowTemplate.Height = 31;
            this.metrogrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metrogrid1.Size = new System.Drawing.Size(1222, 219);
            this.metrogrid1.TabIndex = 34;
            this.metrogrid1.Visible = false;
            this.metrogrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metrogrid1_CellContentClick);
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N*";
            this.nDataGridViewTextBoxColumn.HeaderText = "N*";
            this.nDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            this.nDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 150;
            // 
            // matinheureDataGridViewTextBoxColumn
            // 
            this.matinheureDataGridViewTextBoxColumn.DataPropertyName = "matin/heure";
            this.matinheureDataGridViewTextBoxColumn.HeaderText = "matin/heure";
            this.matinheureDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.matinheureDataGridViewTextBoxColumn.Name = "matinheureDataGridViewTextBoxColumn";
            this.matinheureDataGridViewTextBoxColumn.ReadOnly = true;
            this.matinheureDataGridViewTextBoxColumn.Width = 90;
            // 
            // nuitheureDataGridViewTextBoxColumn
            // 
            this.nuitheureDataGridViewTextBoxColumn.DataPropertyName = "nuit/heure";
            this.nuitheureDataGridViewTextBoxColumn.HeaderText = "nuit/heure";
            this.nuitheureDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nuitheureDataGridViewTextBoxColumn.Name = "nuitheureDataGridViewTextBoxColumn";
            this.nuitheureDataGridViewTextBoxColumn.ReadOnly = true;
            this.nuitheureDataGridViewTextBoxColumn.Width = 90;
            // 
            // addresseDataGridViewTextBoxColumn
            // 
            this.addresseDataGridViewTextBoxColumn.DataPropertyName = "addresse";
            this.addresseDataGridViewTextBoxColumn.HeaderText = "addresse";
            this.addresseDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.addresseDataGridViewTextBoxColumn.Name = "addresseDataGridViewTextBoxColumn";
            this.addresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.addresseDataGridViewTextBoxColumn.Width = 280;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 9;
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            this.Ville.Visible = false;
            this.Ville.Width = 175;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 175;
            // 
            // parkBindingSource
            // 
            this.parkBindingSource.DataMember = "Park";
            this.parkBindingSource.DataSource = this.projetDBDataSet;
            // 
            // projetDBDataSet
            // 
            this.projetDBDataSet.DataSetName = "ProjetDBDataSet";
            this.projetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkTableAdapter
            // 
            this.parkTableAdapter.ClearBeforeFill = true;
            // 
            // nomticketbox
            // 
            this.nomticketbox.AutoSize = true;
            this.nomticketbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nomticketbox.CustomBackground = true;
            this.nomticketbox.CustomForeColor = true;
            this.nomticketbox.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nomticketbox.Location = new System.Drawing.Point(937, 72);
            this.nomticketbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomticketbox.Name = "nomticketbox";
            this.nomticketbox.Size = new System.Drawing.Size(63, 19);
            this.nomticketbox.TabIndex = 56;
            this.nomticketbox.Text = "*********";
            // 
            // Tarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 753);
            this.Controls.Add(this.nomticketbox);
            this.Controls.Add(this.metrogrid1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.villebox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.resebutton);
            this.Controls.Add(this.precbutton);
            this.Controls.Add(this.titrelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tarif";
            this.Padding = new System.Windows.Forms.Padding(37, 111, 37, 37);
            this.Load += new System.EventHandler(this.Tarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metrogrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titrelabel;
        private System.Windows.Forms.Button precbutton;
        private System.Windows.Forms.Button resebutton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox villebox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView metrogrid1;
        private ProjetDBDataSet projetDBDataSet;
        private System.Windows.Forms.BindingSource parkBindingSource;
        private ProjetDBDataSetTableAdapters.ParkTableAdapter parkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinheureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuitheureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroLabel nomticketbox;
    }
}