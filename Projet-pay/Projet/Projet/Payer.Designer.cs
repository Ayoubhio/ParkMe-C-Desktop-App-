
namespace Projet
{
    partial class Payer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payer));
            this.titrelabel = new System.Windows.Forms.Label();
            this.carteradio = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cartebox = new System.Windows.Forms.TextBox();
            this.nombox = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.verifibox = new System.Windows.Forms.TextBox();
            this.resebutton = new System.Windows.Forms.Button();
            this.precbutton = new System.Windows.Forms.Button();
            this.nomticketbox = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.titrelabel.Location = new System.Drawing.Point(369, 26);
            this.titrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titrelabel.Name = "titrelabel";
            this.titrelabel.Size = new System.Drawing.Size(493, 108);
            this.titrelabel.TabIndex = 26;
            this.titrelabel.Text = "PARK ME";
            this.titrelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titrelabel.UseCompatibleTextRendering = true;
            // 
            // carteradio
            // 
            this.carteradio.AutoSize = true;
            this.carteradio.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.carteradio.Checked = true;
            this.carteradio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.carteradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteradio.Location = new System.Drawing.Point(24, 151);
            this.carteradio.Margin = new System.Windows.Forms.Padding(6);
            this.carteradio.Name = "carteradio";
            this.carteradio.Size = new System.Drawing.Size(228, 34);
            this.carteradio.TabIndex = 41;
            this.carteradio.TabStop = true;
            this.carteradio.Text = "Carte Bancaire";
            this.carteradio.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(24, 557);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(417, 33);
            this.radioButton2.TabIndex = 46;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Je Suis Sûr De Mes Informations";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.metroComboBox1.Location = new System.Drawing.Point(24, 383);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(219, 29);
            this.metroComboBox1.TabIndex = 47;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.metroComboBox2.Location = new System.Drawing.Point(267, 383);
            this.metroComboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(219, 29);
            this.metroComboBox2.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projet.Properties.Resources.logo_cmi_visa_mastercard_maroc_lcdmaroc;
            this.pictureBox2.Location = new System.Drawing.Point(947, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 767);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(24, 73);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Details de paiment";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(24, 276);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(189, 19);
            this.metroLabel5.TabIndex = 55;
            this.metroLabel5.Text = "Code de la carte bancaire :";
            // 
            // cartebox
            // 
            this.cartebox.BackColor = System.Drawing.Color.Wheat;
            this.cartebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartebox.Location = new System.Drawing.Point(433, 273);
            this.cartebox.Margin = new System.Windows.Forms.Padding(6);
            this.cartebox.Name = "cartebox";
            this.cartebox.Size = new System.Drawing.Size(371, 34);
            this.cartebox.TabIndex = 56;
            // 
            // nombox
            // 
            this.nombox.BackColor = System.Drawing.Color.Wheat;
            this.nombox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombox.Location = new System.Drawing.Point(433, 207);
            this.nombox.Margin = new System.Windows.Forms.Padding(6);
            this.nombox.Name = "nombox";
            this.nombox.Size = new System.Drawing.Size(371, 34);
            this.nombox.TabIndex = 58;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(26, 211);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(201, 19);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "Nom de porteur de la carte :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(23, 337);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(220, 19);
            this.metroLabel6.TabIndex = 59;
            this.metroLabel6.Text = "Date D\'expiration De La Carte : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(24, 446);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(153, 19);
            this.metroLabel4.TabIndex = 60;
            this.metroLabel4.Text = "Code de verification :";
            // 
            // verifibox
            // 
            this.verifibox.BackColor = System.Drawing.Color.Wheat;
            this.verifibox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifibox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifibox.Location = new System.Drawing.Point(22, 493);
            this.verifibox.Margin = new System.Windows.Forms.Padding(6);
            this.verifibox.Name = "verifibox";
            this.verifibox.Size = new System.Drawing.Size(182, 34);
            this.verifibox.TabIndex = 61;
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
            this.resebutton.Location = new System.Drawing.Point(801, 636);
            this.resebutton.Name = "resebutton";
            this.resebutton.Size = new System.Drawing.Size(400, 64);
            this.resebutton.TabIndex = 62;
            this.resebutton.Text = "Effectuer le paiment ";
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
            this.precbutton.Location = new System.Drawing.Point(546, 636);
            this.precbutton.Name = "precbutton";
            this.precbutton.Size = new System.Drawing.Size(208, 64);
            this.precbutton.TabIndex = 63;
            this.precbutton.Text = "Precedent :";
            this.precbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.precbutton.UseVisualStyleBackColor = false;
            this.precbutton.Click += new System.EventHandler(this.precbutton_Click);
            // 
            // nomticketbox
            // 
            this.nomticketbox.AutoSize = true;
            this.nomticketbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nomticketbox.CustomBackground = true;
            this.nomticketbox.CustomForeColor = true;
            this.nomticketbox.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nomticketbox.Location = new System.Drawing.Point(863, 73);
            this.nomticketbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomticketbox.Name = "nomticketbox";
            this.nomticketbox.Size = new System.Drawing.Size(63, 19);
            this.nomticketbox.TabIndex = 64;
            this.nomticketbox.Text = "*********";
            // 
            // Payer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 813);
            this.Controls.Add(this.nomticketbox);
            this.Controls.Add(this.precbutton);
            this.Controls.Add(this.resebutton);
            this.Controls.Add(this.verifibox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.nombox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cartebox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.carteradio);
            this.Controls.Add(this.titrelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payer";
            this.Padding = new System.Windows.Forms.Padding(20, 111, 20, 20);
            this.Load += new System.EventHandler(this.Payer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titrelabel;
        private System.Windows.Forms.RadioButton carteradio;
        private System.Windows.Forms.RadioButton radioButton2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox cartebox;
        private System.Windows.Forms.TextBox nombox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox verifibox;
        private System.Windows.Forms.Button resebutton;
        private System.Windows.Forms.Button precbutton;
        private MetroFramework.Controls.MetroLabel nomticketbox;
    }
}