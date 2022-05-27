namespace Halı_Saha_Rezervasyonu
{
    partial class Arama
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
            this.label1 = new System.Windows.Forms.Label();
            this.SahaNoTextBox = new System.Windows.Forms.TextBox();
            this.AraButton = new System.Windows.Forms.Button();
            this.SıralaBtn = new System.Windows.Forms.Button();
            this.DegerlendirmeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FiyatsiralaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halısaha No:";
            // 
            // SahaNoTextBox
            // 
            this.SahaNoTextBox.Location = new System.Drawing.Point(158, 38);
            this.SahaNoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SahaNoTextBox.Multiline = true;
            this.SahaNoTextBox.Name = "SahaNoTextBox";
            this.SahaNoTextBox.Size = new System.Drawing.Size(92, 21);
            this.SahaNoTextBox.TabIndex = 2;
            this.SahaNoTextBox.TextChanged += new System.EventHandler(this.SahaNoTextBox_TextChanged);
            // 
            // AraButton
            // 
            this.AraButton.Location = new System.Drawing.Point(282, 39);
            this.AraButton.Margin = new System.Windows.Forms.Padding(2);
            this.AraButton.Name = "AraButton";
            this.AraButton.Size = new System.Drawing.Size(64, 20);
            this.AraButton.TabIndex = 3;
            this.AraButton.Text = "Ara";
            this.AraButton.UseVisualStyleBackColor = true;
            // 
            // SıralaBtn
            // 
            this.SıralaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SıralaBtn.Location = new System.Drawing.Point(747, 38);
            this.SıralaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SıralaBtn.Name = "SıralaBtn";
            this.SıralaBtn.Size = new System.Drawing.Size(123, 38);
            this.SıralaBtn.TabIndex = 4;
            this.SıralaBtn.Text = "Tüm Sahaları Sırala";
            this.SıralaBtn.UseVisualStyleBackColor = true;
            this.SıralaBtn.Click += new System.EventHandler(this.SıralaBtn_Click);
            // 
            // DegerlendirmeBtn
            // 
            this.DegerlendirmeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DegerlendirmeBtn.Location = new System.Drawing.Point(747, 110);
            this.DegerlendirmeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DegerlendirmeBtn.Name = "DegerlendirmeBtn";
            this.DegerlendirmeBtn.Size = new System.Drawing.Size(123, 38);
            this.DegerlendirmeBtn.TabIndex = 11;
            this.DegerlendirmeBtn.Text = "Değerlendirmeye göre sırala";
            this.DegerlendirmeBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(686, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlçe seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(807, 248);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(686, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat Aralığı Giriniz";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(834, 327);
            this.minTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(31, 20);
            this.minTextBox.TabIndex = 8;
            this.minTextBox.Text = "min";
            this.minTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minTextBox_MouseClick);
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(887, 327);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(31, 20);
            this.maxTextBox.TabIndex = 9;
            this.maxTextBox.Text = "max";
            this.maxTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maxTextBox_MouseClick);
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(868, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // FiyatsiralaBtn
            // 
            this.FiyatsiralaBtn.Location = new System.Drawing.Point(820, 357);
            this.FiyatsiralaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiyatsiralaBtn.Name = "FiyatsiralaBtn";
            this.FiyatsiralaBtn.Size = new System.Drawing.Size(98, 20);
            this.FiyatsiralaBtn.TabIndex = 12;
            this.FiyatsiralaBtn.Text = "Sırala";
            this.FiyatsiralaBtn.UseVisualStyleBackColor = true;
            this.FiyatsiralaBtn.Click += new System.EventHandler(this.FiyatsiralaBtn_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Rezervasyon Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 462);
            this.dataGridView1.TabIndex = 14;
            // 
            // Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FiyatsiralaBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DegerlendirmeBtn);
            this.Controls.Add(this.SıralaBtn);
            this.Controls.Add(this.AraButton);
            this.Controls.Add(this.SahaNoTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama";
            this.Load += new System.EventHandler(this.Arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SahaNoTextBox;
        private System.Windows.Forms.Button AraButton;
        private System.Windows.Forms.Button SıralaBtn;
        private System.Windows.Forms.Button DegerlendirmeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FiyatsiralaBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}