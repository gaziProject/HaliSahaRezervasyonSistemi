namespace Halı_Saha_Rezervasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelYanMenu = new System.Windows.Forms.Panel();
            this.buttonYardım = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonKayıtOl = new System.Windows.Forms.Button();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelAltMenu = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelYanMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelYanMenu
            // 
            this.panelYanMenu.AutoScroll = true;
            this.panelYanMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.panelYanMenu.Controls.Add(this.buttonYardım);
            this.panelYanMenu.Controls.Add(this.buttonCikis);
            this.panelYanMenu.Controls.Add(this.buttonKayıtOl);
            this.panelYanMenu.Controls.Add(this.buttonGiris);
            this.panelYanMenu.Controls.Add(this.panelLogo);
            this.panelYanMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelYanMenu.Location = new System.Drawing.Point(0, 0);
            this.panelYanMenu.Name = "panelYanMenu";
            this.panelYanMenu.Size = new System.Drawing.Size(200, 600);
            this.panelYanMenu.TabIndex = 0;
            // 
            // buttonYardım
            // 
            this.buttonYardım.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonYardım.FlatAppearance.BorderSize = 0;
            this.buttonYardım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYardım.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonYardım.Location = new System.Drawing.Point(0, 214);
            this.buttonYardım.Name = "buttonYardım";
            this.buttonYardım.Size = new System.Drawing.Size(200, 40);
            this.buttonYardım.TabIndex = 4;
            this.buttonYardım.Text = "Yardım ?";
            this.buttonYardım.UseVisualStyleBackColor = true;
            this.buttonYardım.Click += new System.EventHandler(this.buttonYardım_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCikis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCikis.Location = new System.Drawing.Point(0, 560);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(200, 40);
            this.buttonCikis.TabIndex = 3;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonKayıtOl
            // 
            this.buttonKayıtOl.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKayıtOl.FlatAppearance.BorderSize = 0;
            this.buttonKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayıtOl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKayıtOl.Location = new System.Drawing.Point(0, 174);
            this.buttonKayıtOl.Name = "buttonKayıtOl";
            this.buttonKayıtOl.Size = new System.Drawing.Size(200, 40);
            this.buttonKayıtOl.TabIndex = 2;
            this.buttonKayıtOl.Text = "Kayıt Ol";
            this.buttonKayıtOl.UseVisualStyleBackColor = true;
            this.buttonKayıtOl.Click += new System.EventHandler(this.buttonKayıtOl_Click);
            // 
            // buttonGiris
            // 
            this.buttonGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGiris.FlatAppearance.BorderSize = 0;
            this.buttonGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGiris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGiris.Location = new System.Drawing.Point(0, 134);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(200, 40);
            this.buttonGiris.TabIndex = 1;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 134);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 134);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelAltMenu
            // 
            this.panelAltMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.panelAltMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltMenu.Location = new System.Drawing.Point(200, 560);
            this.panelAltMenu.Name = "panelAltMenu";
            this.panelAltMenu.Size = new System.Drawing.Size(600, 40);
            this.panelAltMenu.TabIndex = 1;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(600, 560);
            this.panelForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelAltMenu);
            this.Controls.Add(this.panelYanMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelYanMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelYanMenu;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonKayıtOl;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelAltMenu;
        private System.Windows.Forms.Button buttonYardım;
        private System.Windows.Forms.Panel panelForm;
    }
}