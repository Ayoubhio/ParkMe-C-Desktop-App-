
namespace Projet
{
    partial class Inscription
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
            this.phonebox = new MetroFramework.Controls.MetroTextBox();
            this.nombox = new MetroFramework.Controls.MetroTextBox();
            this.passbox = new MetroFramework.Controls.MetroTextBox();
            this.emailbox = new MetroFramework.Controls.MetroTextBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.maillabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.nomlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupbutton = new System.Windows.Forms.Button();
            this.precbutton = new System.Windows.Forms.Button();
            this.titrelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // phonebox
            // 
            this.phonebox.BackColor = System.Drawing.Color.Beige;
            this.phonebox.CustomBackground = true;
            this.phonebox.CustomForeColor = true;
            this.phonebox.Location = new System.Drawing.Point(636, 358);
            this.phonebox.Name = "phonebox";
            this.phonebox.PromptText = "Entrer votre numero";
            this.phonebox.Size = new System.Drawing.Size(299, 48);
            this.phonebox.TabIndex = 14;
            // 
            // nombox
            // 
            this.nombox.BackColor = System.Drawing.Color.Beige;
            this.nombox.CustomBackground = true;
            this.nombox.CustomForeColor = true;
            this.nombox.Location = new System.Drawing.Point(636, 281);
            this.nombox.Name = "nombox";
            this.nombox.PromptText = "Entrer votre nom";
            this.nombox.Size = new System.Drawing.Size(299, 48);
            this.nombox.TabIndex = 11;
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.Beige;
            this.passbox.CustomBackground = true;
            this.passbox.CustomForeColor = true;
            this.passbox.Location = new System.Drawing.Point(636, 495);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.PromptText = "Entrer votre password";
            this.passbox.Size = new System.Drawing.Size(299, 48);
            this.passbox.TabIndex = 18;
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.Color.Beige;
            this.emailbox.CustomBackground = true;
            this.emailbox.CustomForeColor = true;
            this.emailbox.Location = new System.Drawing.Point(636, 431);
            this.emailbox.Name = "emailbox";
            this.emailbox.PromptText = "Entrer votre email";
            this.emailbox.Size = new System.Drawing.Size(299, 48);
            this.emailbox.TabIndex = 15;
            // 
            // passlabel
            // 
            this.passlabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.passlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.passlabel.Image = global::Projet.Properties.Resources.padlock11;
            this.passlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passlabel.Location = new System.Drawing.Point(358, 447);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(223, 48);
            this.passlabel.TabIndex = 17;
            this.passlabel.Text = "Password : ";
            this.passlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maillabel
            // 
            this.maillabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.maillabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maillabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.maillabel.Image = global::Projet.Properties.Resources.email112;
            this.maillabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maillabel.Location = new System.Drawing.Point(358, 383);
            this.maillabel.Name = "maillabel";
            this.maillabel.Size = new System.Drawing.Size(223, 48);
            this.maillabel.TabIndex = 16;
            this.maillabel.Text = "Email : ";
            this.maillabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phonelabel
            // 
            this.phonelabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.phonelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.phonelabel.Image = global::Projet.Properties.Resources.icons8_iphone_16;
            this.phonelabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phonelabel.Location = new System.Drawing.Point(358, 310);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(223, 48);
            this.phonelabel.TabIndex = 13;
            this.phonelabel.Text = "Phone number";
            this.phonelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nomlabel
            // 
            this.nomlabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.nomlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nomlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomlabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.nomlabel.Image = global::Projet.Properties.Resources.utilisateur;
            this.nomlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nomlabel.Location = new System.Drawing.Point(358, 232);
            this.nomlabel.Name = "nomlabel";
            this.nomlabel.Size = new System.Drawing.Size(223, 48);
            this.nomlabel.TabIndex = 12;
            this.nomlabel.Text = "Nom : ";
            this.nomlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projet.Properties.Resources.image_0932339_20210430_ob_f4c67e_proteger_place_parking;
            this.pictureBox1.Image = global::Projet.Properties.Resources.image_0932339_20210430_ob_f4c67e_proteger_place_parking;
            this.pictureBox1.Location = new System.Drawing.Point(0, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.BackColor = System.Drawing.Color.Transparent;
            this.signupbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.Black;
            this.signupbutton.Image = global::Projet.Properties.Resources.log_in_1;
            this.signupbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signupbutton.Location = new System.Drawing.Point(358, 650);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(208, 64);
            this.signupbutton.TabIndex = 20;
            this.signupbutton.Text = "Sign UP";
            this.signupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
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
            this.precbutton.Location = new System.Drawing.Point(727, 650);
            this.precbutton.Name = "precbutton";
            this.precbutton.Size = new System.Drawing.Size(208, 64);
            this.precbutton.TabIndex = 21;
            this.precbutton.Text = "Quitter :";
            this.precbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.precbutton.UseVisualStyleBackColor = false;
            this.precbutton.Click += new System.EventHandler(this.precbutton_Click);
            // 
            // titrelabel
            // 
            this.titrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titrelabel.BackColor = System.Drawing.Color.Transparent;
            this.titrelabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titrelabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.titrelabel.Location = new System.Drawing.Point(418, 19);
            this.titrelabel.Name = "titrelabel";
            this.titrelabel.Size = new System.Drawing.Size(494, 71);
            this.titrelabel.TabIndex = 22;
            this.titrelabel.Text = "PARK ME";
            this.titrelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titrelabel.UseCompatibleTextRendering = true;
            this.titrelabel.Click += new System.EventHandler(this.titrelabel_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 800);
            this.Controls.Add(this.titrelabel);
            this.Controls.Add(this.precbutton);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.maillabel);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.nomlabel);
            this.Controls.Add(this.nombox);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox phonebox;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label nomlabel;
        private MetroFramework.Controls.MetroTextBox nombox;
        private MetroFramework.Controls.MetroTextBox passbox;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label maillabel;
        private MetroFramework.Controls.MetroTextBox emailbox;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button precbutton;
        private System.Windows.Forms.Label titrelabel;
    }
}