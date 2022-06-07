
namespace Projet
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.main_panel = new MetroFramework.Controls.MetroPanel();
            this.signupbutton = new System.Windows.Forms.Button();
            this.signinButton1 = new System.Windows.Forms.Button();
            this.passbox = new MetroFramework.Controls.MetroTextBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.maillabel = new System.Windows.Forms.Label();
            this.emailbox = new MetroFramework.Controls.MetroTextBox();
            this.titrelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_panel.Controls.Add(this.signupbutton);
            this.main_panel.Controls.Add(this.signinButton1);
            this.main_panel.Controls.Add(this.passbox);
            this.main_panel.Controls.Add(this.passlabel);
            this.main_panel.Controls.Add(this.maillabel);
            this.main_panel.Controls.Add(this.emailbox);
            this.main_panel.Controls.Add(this.titrelabel);
            this.main_panel.Controls.Add(this.pictureBox1);
            this.main_panel.CustomBackground = true;
            this.main_panel.HorizontalScrollbarBarColor = true;
            this.main_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.main_panel.HorizontalScrollbarSize = 10;
            this.main_panel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.main_panel.Location = new System.Drawing.Point(-4, 44);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1284, 759);
            this.main_panel.TabIndex = 0;
            this.main_panel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.main_panel.VerticalScrollbarBarColor = true;
            this.main_panel.VerticalScrollbarHighlightOnWheel = false;
            this.main_panel.VerticalScrollbarSize = 10;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // signupbutton
            // 
            this.signupbutton.BackColor = System.Drawing.Color.Transparent;
            this.signupbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.signupbutton.Image = ((System.Drawing.Image)(resources.GetObject("signupbutton.Image")));
            this.signupbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signupbutton.Location = new System.Drawing.Point(695, 602);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(509, 64);
            this.signupbutton.TabIndex = 13;
            this.signupbutton.Text = "Don\'t have an account Sign UP";
            this.signupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // signinButton1
            // 
            this.signinButton1.BackColor = System.Drawing.Color.Transparent;
            this.signinButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signinButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signinButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signinButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.signinButton1.Image = ((System.Drawing.Image)(resources.GetObject("signinButton1.Image")));
            this.signinButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signinButton1.Location = new System.Drawing.Point(196, 602);
            this.signinButton1.Name = "signinButton1";
            this.signinButton1.Size = new System.Drawing.Size(208, 64);
            this.signinButton1.TabIndex = 12;
            this.signinButton1.Text = "Sign IN";
            this.signinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signinButton1.UseVisualStyleBackColor = false;
            this.signinButton1.Click += new System.EventHandler(this.signinButton1_Click);
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.Beige;
            this.passbox.CustomBackground = true;
            this.passbox.CustomForeColor = true;
            this.passbox.Location = new System.Drawing.Point(296, 471);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.PromptText = "Entrer votre password";
            this.passbox.Size = new System.Drawing.Size(299, 48);
            this.passbox.TabIndex = 10;
            // 
            // passlabel
            // 
            this.passlabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.passlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.passlabel.Image = ((System.Drawing.Image)(resources.GetObject("passlabel.Image")));
            this.passlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passlabel.Location = new System.Drawing.Point(54, 471);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(223, 48);
            this.passlabel.TabIndex = 9;
            this.passlabel.Text = "Password : ";
            this.passlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maillabel
            // 
            this.maillabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.maillabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maillabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.maillabel.Image = ((System.Drawing.Image)(resources.GetObject("maillabel.Image")));
            this.maillabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maillabel.Location = new System.Drawing.Point(54, 376);
            this.maillabel.Name = "maillabel";
            this.maillabel.Size = new System.Drawing.Size(223, 48);
            this.maillabel.TabIndex = 8;
            this.maillabel.Text = "Email : ";
            this.maillabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.Color.Beige;
            this.emailbox.CustomBackground = true;
            this.emailbox.CustomForeColor = true;
            this.emailbox.Location = new System.Drawing.Point(296, 376);
            this.emailbox.Name = "emailbox";
            this.emailbox.PromptText = "Entrer votre email";
            this.emailbox.Size = new System.Drawing.Size(299, 48);
            this.emailbox.TabIndex = 7;
            // 
            // titrelabel
            // 
            this.titrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titrelabel.BackColor = System.Drawing.Color.Transparent;
            this.titrelabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titrelabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.titrelabel.Location = new System.Drawing.Point(423, 3);
            this.titrelabel.Name = "titrelabel";
            this.titrelabel.Size = new System.Drawing.Size(494, 109);
            this.titrelabel.TabIndex = 4;
            this.titrelabel.Text = "PARK ME";
            this.titrelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titrelabel.UseCompatibleTextRendering = true;
            this.titrelabel.Click += new System.EventHandler(this.titrelabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1279, 800);
            this.Controls.Add(this.main_panel);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel main_panel;
        private System.Windows.Forms.Label titrelabel;
        private MetroFramework.Controls.MetroTextBox emailbox;
        private System.Windows.Forms.Label maillabel;
        private System.Windows.Forms.Label passlabel;
        private MetroFramework.Controls.MetroTextBox passbox;
        private System.Windows.Forms.Button signinButton1;
        private System.Windows.Forms.Button signupbutton;
    }
}

