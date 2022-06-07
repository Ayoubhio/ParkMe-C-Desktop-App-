
namespace Projet
{
    partial class Historique
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
            this.titrelabel = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nomticketbox = new MetroFramework.Controls.MetroLabel();
            this.precbutton = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.databaseDataSet1 = new Projet.DatabaseDataSet1();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Projet.DatabaseDataSet1TableAdapters.TicketTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomparkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerospotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresseparkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreheureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet.Properties.Resources.image_0932339_20210430_ob_f4c67e_proteger_place_parking;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 770);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // titrelabel
            // 
            this.titrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titrelabel.BackColor = System.Drawing.Color.Transparent;
            this.titrelabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titrelabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.titrelabel.Location = new System.Drawing.Point(386, 6);
            this.titrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titrelabel.Name = "titrelabel";
            this.titrelabel.Size = new System.Drawing.Size(493, 79);
            this.titrelabel.TabIndex = 24;
            this.titrelabel.Text = "PARK ME";
            this.titrelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titrelabel.UseCompatibleTextRendering = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(24, 104);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(257, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Voici l\'historique de vos reservation :";
            // 
            // nomticketbox
            // 
            this.nomticketbox.AutoSize = true;
            this.nomticketbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nomticketbox.CustomBackground = true;
            this.nomticketbox.CustomForeColor = true;
            this.nomticketbox.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nomticketbox.Location = new System.Drawing.Point(880, 69);
            this.nomticketbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomticketbox.Name = "nomticketbox";
            this.nomticketbox.Size = new System.Drawing.Size(63, 19);
            this.nomticketbox.TabIndex = 57;
            this.nomticketbox.Text = "*********";
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
            this.precbutton.Location = new System.Drawing.Point(488, 692);
            this.precbutton.Name = "precbutton";
            this.precbutton.Size = new System.Drawing.Size(208, 64);
            this.precbutton.TabIndex = 58;
            this.precbutton.Text = "Menu :";
            this.precbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.precbutton.UseVisualStyleBackColor = false;
            this.precbutton.Click += new System.EventHandler(this.precbutton_Click);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AutoGenerateColumns = false;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrid.ColumnHeadersHeight = 40;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.nomparkDataGridViewTextBoxColumn,
            this.numerospotDataGridViewTextBoxColumn,
            this.addresseparkDataGridViewTextBoxColumn,
            this.nombreheureDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn});
            this.datagrid.DataSource = this.ticketBindingSource;
            this.datagrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrid.Location = new System.Drawing.Point(83, 276);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.RowHeadersWidth = 72;
            this.datagrid.RowTemplate.Height = 31;
            this.datagrid.Size = new System.Drawing.Size(1000, 265);
            this.datagrid.TabIndex = 59;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.databaseDataSet1;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomparkDataGridViewTextBoxColumn
            // 
            this.nomparkDataGridViewTextBoxColumn.DataPropertyName = "nom_park";
            this.nomparkDataGridViewTextBoxColumn.HeaderText = "Parking";
            this.nomparkDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nomparkDataGridViewTextBoxColumn.Name = "nomparkDataGridViewTextBoxColumn";
            this.nomparkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerospotDataGridViewTextBoxColumn
            // 
            this.numerospotDataGridViewTextBoxColumn.DataPropertyName = "numero_spot";
            this.numerospotDataGridViewTextBoxColumn.HeaderText = "Place";
            this.numerospotDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.numerospotDataGridViewTextBoxColumn.Name = "numerospotDataGridViewTextBoxColumn";
            this.numerospotDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerospotDataGridViewTextBoxColumn.Width = 50;
            // 
            // addresseparkDataGridViewTextBoxColumn
            // 
            this.addresseparkDataGridViewTextBoxColumn.DataPropertyName = "addresse_park";
            this.addresseparkDataGridViewTextBoxColumn.HeaderText = "Addresse";
            this.addresseparkDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.addresseparkDataGridViewTextBoxColumn.Name = "addresseparkDataGridViewTextBoxColumn";
            this.addresseparkDataGridViewTextBoxColumn.ReadOnly = true;
            this.addresseparkDataGridViewTextBoxColumn.Width = 175;
            // 
            // nombreheureDataGridViewTextBoxColumn
            // 
            this.nombreheureDataGridViewTextBoxColumn.DataPropertyName = "nombre_heure";
            this.nombreheureDataGridViewTextBoxColumn.HeaderText = "Nombre d\'heure";
            this.nombreheureDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nombreheureDataGridViewTextBoxColumn.Name = "nombreheureDataGridViewTextBoxColumn";
            this.nombreheureDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreheureDataGridViewTextBoxColumn.Width = 50;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            this.montantDataGridViewTextBoxColumn.Width = 50;
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 813);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.precbutton);
            this.Controls.Add(this.nomticketbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.titrelabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Historique";
            this.Load += new System.EventHandler(this.Historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titrelabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel nomticketbox;
        private System.Windows.Forms.Button precbutton;
        private System.Windows.Forms.DataGridView datagrid;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private DatabaseDataSet1TableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomparkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerospotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresseparkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreheureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
    }
}