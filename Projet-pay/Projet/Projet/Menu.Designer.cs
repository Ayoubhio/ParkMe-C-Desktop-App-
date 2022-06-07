
namespace Projet
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.parkbutton = new System.Windows.Forms.Button();
            this.reserverbutton = new System.Windows.Forms.Button();
            this.histbutton = new System.Windows.Forms.Button();
            this.titrelabel = new System.Windows.Forms.Label();
            this.nomticketbox = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // parkbutton
            // 
            this.parkbutton.BackColor = System.Drawing.Color.Transparent;
            this.parkbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.parkbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.parkbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkbutton.ForeColor = System.Drawing.Color.Black;
            this.parkbutton.Image = global::Projet.Properties.Resources.log_in_1;
            this.parkbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parkbutton.Location = new System.Drawing.Point(471, 207);
            this.parkbutton.Margin = new System.Windows.Forms.Padding(4);
            this.parkbutton.Name = "parkbutton";
            this.parkbutton.Size = new System.Drawing.Size(317, 146);
            this.parkbutton.TabIndex = 22;
            this.parkbutton.Text = "Tarifs De Parking";
            this.parkbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkbutton.UseVisualStyleBackColor = false;
            this.parkbutton.Click += new System.EventHandler(this.precbutton_Click);
            // 
            // reserverbutton
            // 
            this.reserverbutton.BackColor = System.Drawing.Color.Transparent;
            this.reserverbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reserverbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reserverbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reserverbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserverbutton.ForeColor = System.Drawing.Color.Black;
            this.reserverbutton.Image = global::Projet.Properties.Resources.log_in_1;
            this.reserverbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reserverbutton.Location = new System.Drawing.Point(471, 399);
            this.reserverbutton.Margin = new System.Windows.Forms.Padding(4);
            this.reserverbutton.Name = "reserverbutton";
            this.reserverbutton.Size = new System.Drawing.Size(317, 146);
            this.reserverbutton.TabIndex = 23;
            this.reserverbutton.Text = "Réserver";
            this.reserverbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserverbutton.UseVisualStyleBackColor = false;
            this.reserverbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // histbutton
            // 
            this.histbutton.BackColor = System.Drawing.Color.Transparent;
            this.histbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.histbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.histbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.histbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histbutton.ForeColor = System.Drawing.Color.Black;
            this.histbutton.Image = global::Projet.Properties.Resources.log_in_1;
            this.histbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.histbutton.Location = new System.Drawing.Point(471, 583);
            this.histbutton.Margin = new System.Windows.Forms.Padding(4);
            this.histbutton.Name = "histbutton";
            this.histbutton.Size = new System.Drawing.Size(317, 146);
            this.histbutton.TabIndex = 24;
            this.histbutton.Text = "Historique De Réservation";
            this.histbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.histbutton.UseVisualStyleBackColor = false;
            this.histbutton.Click += new System.EventHandler(this.histbutton_Click);
            // 
            // titrelabel
            // 
            this.titrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titrelabel.BackColor = System.Drawing.Color.Transparent;
            this.titrelabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titrelabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.titrelabel.Location = new System.Drawing.Point(369, 7);
            this.titrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titrelabel.Name = "titrelabel";
            this.titrelabel.Size = new System.Drawing.Size(493, 70);
            this.titrelabel.TabIndex = 25;
            this.titrelabel.Text = "PARK ME";
            this.titrelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titrelabel.UseCompatibleTextRendering = true;
            // 
            // nomticketbox
            // 
            this.nomticketbox.AutoSize = true;
            this.nomticketbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.nomticketbox.CustomBackground = true;
            this.nomticketbox.CustomForeColor = true;
            this.nomticketbox.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nomticketbox.Location = new System.Drawing.Point(864, 58);
            this.nomticketbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomticketbox.Name = "nomticketbox";
            this.nomticketbox.Size = new System.Drawing.Size(63, 19);
            this.nomticketbox.TabIndex = 55;
            this.nomticketbox.Text = "*********";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 753);
            this.Controls.Add(this.nomticketbox);
            this.Controls.Add(this.titrelabel);
            this.Controls.Add(this.histbutton);
            this.Controls.Add(this.reserverbutton);
            this.Controls.Add(this.parkbutton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(20, 111, 20, 20);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button parkbutton;
        private System.Windows.Forms.Button reserverbutton;
        private System.Windows.Forms.Button histbutton;
        private System.Windows.Forms.Label titrelabel;
        private MetroFramework.Controls.MetroLabel nomticketbox;
    }
}