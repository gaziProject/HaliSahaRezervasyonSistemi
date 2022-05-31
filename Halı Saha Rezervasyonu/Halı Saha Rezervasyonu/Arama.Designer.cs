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
            this.SıralaBtn = new System.Windows.Forms.Button();
            this.DegerlendirmeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FiyatsiralaBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SıralaBtn
            // 
            this.SıralaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SıralaBtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SıralaBtn.Location = new System.Drawing.Point(391, 40);
            this.SıralaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SıralaBtn.Name = "SıralaBtn";
            this.SıralaBtn.Size = new System.Drawing.Size(126, 38);
            this.SıralaBtn.TabIndex = 4;
            this.SıralaBtn.Text = "Tüm Sahaları Sırala";
            this.SıralaBtn.UseVisualStyleBackColor = true;
            this.SıralaBtn.Click += new System.EventHandler(this.SıralaBtn_Click);
            // 
            // DegerlendirmeBtn
            // 
            this.DegerlendirmeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DegerlendirmeBtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DegerlendirmeBtn.Location = new System.Drawing.Point(391, 90);
            this.DegerlendirmeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DegerlendirmeBtn.Name = "DegerlendirmeBtn";
            this.DegerlendirmeBtn.Size = new System.Drawing.Size(126, 38);
            this.DegerlendirmeBtn.TabIndex = 11;
            this.DegerlendirmeBtn.Text = "Değerlendirmeye göre sırala";
            this.DegerlendirmeBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(391, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlçe seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Altındağ",
            "Çankaya",
            "Çubuk",
            "Elmadağ",
            "Etimesgut",
            "Gölbaşı",
            "Keçiören",
            "Kızılcahamam",
            "Mamak",
            "Polatlı ",
            "Sincan",
            "Yenimahalle"});
            this.comboBox1.Location = new System.Drawing.Point(391, 195);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(388, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat Aralığı Giriniz";
            // 
            // minTextBox
            // 
            this.minTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minTextBox.Location = new System.Drawing.Point(391, 265);
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
            this.maxTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxTextBox.Location = new System.Drawing.Point(452, 265);
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
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(430, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // FiyatsiralaBtn
            // 
            this.FiyatsiralaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FiyatsiralaBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FiyatsiralaBtn.Location = new System.Drawing.Point(391, 302);
            this.FiyatsiralaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiyatsiralaBtn.Name = "FiyatsiralaBtn";
            this.FiyatsiralaBtn.Size = new System.Drawing.Size(92, 20);
            this.FiyatsiralaBtn.TabIndex = 12;
            this.FiyatsiralaBtn.Text = "Sırala";
            this.FiyatsiralaBtn.UseVisualStyleBackColor = true;
            this.FiyatsiralaBtn.Click += new System.EventHandler(this.FiyatsiralaBtn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(316, 480);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(638, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FiyatsiralaBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DegerlendirmeBtn);
            this.Controls.Add(this.SıralaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button SıralaBtn;
        private System.Windows.Forms.Button DegerlendirmeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FiyatsiralaBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}