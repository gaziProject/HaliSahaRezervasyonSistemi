using System;
using System.Collections;
using System.Reflection.Emit;

namespace Halı_Saha_Rezervasyonu
{
    partial class Rezervasyon_Görüntüleme
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
        /// 



        private void InitializeComponent()
        {
            this.lblpzt = new System.Windows.Forms.Label();
            this.lblsali = new System.Windows.Forms.Label();
            this.Carsamba = new System.Windows.Forms.Label();
            this.lblpers = new System.Windows.Forms.Label();
            this.lblcuma = new System.Windows.Forms.Label();
            this.lblcmt = new System.Windows.Forms.Label();
            this.lblpaz = new System.Windows.Forms.Label();
            this.Pazartesi16 = new System.Windows.Forms.Label();
            this.Pazartesi17 = new System.Windows.Forms.Label();
            this.Pazartesi18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Pazartesi20 = new System.Windows.Forms.Label();
            this.Pazartesi21 = new System.Windows.Forms.Label();
            this.Pazartesi22 = new System.Windows.Forms.Label();
            this.Pazartesi23 = new System.Windows.Forms.Label();
            this.Pazartesi19 = new System.Windows.Forms.Label();
            this.Sali16 = new System.Windows.Forms.Label();
            this.Cumartesi16 = new System.Windows.Forms.Label();
            this.Cuma16 = new System.Windows.Forms.Label();
            this.Persembe16 = new System.Windows.Forms.Label();
            this.Carsamba16 = new System.Windows.Forms.Label();
            this.Pazar16 = new System.Windows.Forms.Label();
            this.Pazar17 = new System.Windows.Forms.Label();
            this.Cumartesi17 = new System.Windows.Forms.Label();
            this.Cuma17 = new System.Windows.Forms.Label();
            this.Persembe17 = new System.Windows.Forms.Label();
            this.Carsamba17 = new System.Windows.Forms.Label();
            this.Sali17 = new System.Windows.Forms.Label();
            this.Cumartesi18 = new System.Windows.Forms.Label();
            this.Cuma18 = new System.Windows.Forms.Label();
            this.Persembe18 = new System.Windows.Forms.Label();
            this.Carsamba18 = new System.Windows.Forms.Label();
            this.Sali18 = new System.Windows.Forms.Label();
            this.Pazar18 = new System.Windows.Forms.Label();
            this.Persembe19 = new System.Windows.Forms.Label();
            this.Pazar19 = new System.Windows.Forms.Label();
            this.Cumartesi19 = new System.Windows.Forms.Label();
            this.Cuma19 = new System.Windows.Forms.Label();
            this.Carsamba19 = new System.Windows.Forms.Label();
            this.Sali19 = new System.Windows.Forms.Label();
            this.Sali20 = new System.Windows.Forms.Label();
            this.Cumartesi20 = new System.Windows.Forms.Label();
            this.Cuma20 = new System.Windows.Forms.Label();
            this.Persembe20 = new System.Windows.Forms.Label();
            this.Carsamba20 = new System.Windows.Forms.Label();
            this.Pazar20 = new System.Windows.Forms.Label();
            this.Pazar21 = new System.Windows.Forms.Label();
            this.Cumartesi21 = new System.Windows.Forms.Label();
            this.Cuma21 = new System.Windows.Forms.Label();
            this.Persembe21 = new System.Windows.Forms.Label();
            this.Carsamba21 = new System.Windows.Forms.Label();
            this.Sali21 = new System.Windows.Forms.Label();
            this.Cumartesi22 = new System.Windows.Forms.Label();
            this.Cuma22 = new System.Windows.Forms.Label();
            this.Persembe22 = new System.Windows.Forms.Label();
            this.Carsamba22 = new System.Windows.Forms.Label();
            this.Sali22 = new System.Windows.Forms.Label();
            this.Pazar22 = new System.Windows.Forms.Label();
            this.Cumartesi23 = new System.Windows.Forms.Label();
            this.Cuma23 = new System.Windows.Forms.Label();
            this.Persembe23 = new System.Windows.Forms.Label();
            this.Carsamba23 = new System.Windows.Forms.Label();
            this.Sali23 = new System.Windows.Forms.Label();
            this.Pazar23 = new System.Windows.Forms.Label();
            this.btnrzrv = new System.Windows.Forms.Button();
            this.lblgun = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbgun = new System.Windows.Forms.ComboBox();
            this.cmbsaat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblpzt
            // 
            this.lblpzt.AutoSize = true;
            this.lblpzt.Location = new System.Drawing.Point(16, 78);
            this.lblpzt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpzt.Name = "lblpzt";
            this.lblpzt.Size = new System.Drawing.Size(63, 16);
            this.lblpzt.TabIndex = 0;
            this.lblpzt.Text = "Pazartesi";
            // 
            // lblsali
            // 
            this.lblsali.AutoSize = true;
            this.lblsali.Location = new System.Drawing.Point(16, 135);
            this.lblsali.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsali.Name = "lblsali";
            this.lblsali.Size = new System.Drawing.Size(30, 16);
            this.lblsali.TabIndex = 1;
            this.lblsali.Text = "Salı";
            // 
            // Carsamba
            // 
            this.Carsamba.AutoSize = true;
            this.Carsamba.Location = new System.Drawing.Point(16, 194);
            this.Carsamba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba.Name = "Carsamba";
            this.Carsamba.Size = new System.Drawing.Size(70, 16);
            this.Carsamba.TabIndex = 2;
            this.Carsamba.Text = "Çarşamba";
            // 
            // lblpers
            // 
            this.lblpers.AutoSize = true;
            this.lblpers.Location = new System.Drawing.Point(16, 254);
            this.lblpers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpers.Name = "lblpers";
            this.lblpers.Size = new System.Drawing.Size(70, 16);
            this.lblpers.TabIndex = 3;
            this.lblpers.Text = "Perşembe";
            // 
            // lblcuma
            // 
            this.lblcuma.AutoSize = true;
            this.lblcuma.Location = new System.Drawing.Point(16, 316);
            this.lblcuma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcuma.Name = "lblcuma";
            this.lblcuma.Size = new System.Drawing.Size(42, 16);
            this.lblcuma.TabIndex = 4;
            this.lblcuma.Text = "Cuma";
            // 
            // lblcmt
            // 
            this.lblcmt.AutoSize = true;
            this.lblcmt.Location = new System.Drawing.Point(16, 384);
            this.lblcmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcmt.Name = "lblcmt";
            this.lblcmt.Size = new System.Drawing.Size(67, 16);
            this.lblcmt.TabIndex = 5;
            this.lblcmt.Text = "Cumartesi";
            // 
            // lblpaz
            // 
            this.lblpaz.AutoSize = true;
            this.lblpaz.Location = new System.Drawing.Point(16, 462);
            this.lblpaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaz.Name = "lblpaz";
            this.lblpaz.Size = new System.Drawing.Size(42, 16);
            this.lblpaz.TabIndex = 6;
            this.lblpaz.Text = "Pazar";
            // 
            // Pazartesi16
            // 
            this.Pazartesi16.AutoSize = true;
            this.Pazartesi16.Location = new System.Drawing.Point(121, 78);
            this.Pazartesi16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi16.Name = "Pazartesi16";
            this.Pazartesi16.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi16.TabIndex = 7;
            this.Pazartesi16.Text = "16.00-17.00";
            // 
            // Pazartesi17
            // 
            this.Pazartesi17.AutoSize = true;
            this.Pazartesi17.Location = new System.Drawing.Point(261, 78);
            this.Pazartesi17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi17.Name = "Pazartesi17";
            this.Pazartesi17.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi17.TabIndex = 8;
            this.Pazartesi17.Text = "17.00-18.00";
            // 
            // Pazartesi18
            // 
            this.Pazartesi18.AutoSize = true;
            this.Pazartesi18.Location = new System.Drawing.Point(391, 78);
            this.Pazartesi18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi18.Name = "Pazartesi18";
            this.Pazartesi18.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi18.TabIndex = 9;
            this.Pazartesi18.Text = "18.00-19.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 10;
            // 
            // Pazartesi20
            // 
            this.Pazartesi20.AutoSize = true;
            this.Pazartesi20.Location = new System.Drawing.Point(629, 78);
            this.Pazartesi20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi20.Name = "Pazartesi20";
            this.Pazartesi20.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi20.TabIndex = 11;
            this.Pazartesi20.Text = "20.00-21.00";
            // 
            // Pazartesi21
            // 
            this.Pazartesi21.AutoSize = true;
            this.Pazartesi21.Location = new System.Drawing.Point(751, 78);
            this.Pazartesi21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi21.Name = "Pazartesi21";
            this.Pazartesi21.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi21.TabIndex = 12;
            this.Pazartesi21.Text = "21.00-22.00";
            // 
            // Pazartesi22
            // 
            this.Pazartesi22.AutoSize = true;
            this.Pazartesi22.Location = new System.Drawing.Point(869, 78);
            this.Pazartesi22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi22.Name = "Pazartesi22";
            this.Pazartesi22.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi22.TabIndex = 13;
            this.Pazartesi22.Text = "22.00-23.00";
            // 
            // Pazartesi23
            // 
            this.Pazartesi23.AutoSize = true;
            this.Pazartesi23.Location = new System.Drawing.Point(979, 78);
            this.Pazartesi23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi23.Name = "Pazartesi23";
            this.Pazartesi23.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi23.TabIndex = 14;
            this.Pazartesi23.Text = "23.00-00.00";
            // 
            // Pazartesi19
            // 
            this.Pazartesi19.AutoSize = true;
            this.Pazartesi19.Location = new System.Drawing.Point(512, 78);
            this.Pazartesi19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazartesi19.Name = "Pazartesi19";
            this.Pazartesi19.Size = new System.Drawing.Size(73, 16);
            this.Pazartesi19.TabIndex = 15;
            this.Pazartesi19.Text = "19.00-20.00";
            // 
            // Sali16
            // 
            this.Sali16.AutoSize = true;
            this.Sali16.Location = new System.Drawing.Point(121, 135);
            this.Sali16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali16.Name = "Sali16";
            this.Sali16.Size = new System.Drawing.Size(73, 16);
            this.Sali16.TabIndex = 16;
            this.Sali16.Text = "16.00-17.00";
            // 
            // Cumartesi16
            // 
            this.Cumartesi16.AutoSize = true;
            this.Cumartesi16.Location = new System.Drawing.Point(121, 384);
            this.Cumartesi16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi16.Name = "Cumartesi16";
            this.Cumartesi16.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi16.TabIndex = 17;
            this.Cumartesi16.Text = "16.00-17.00";
            // 
            // Cuma16
            // 
            this.Cuma16.AutoSize = true;
            this.Cuma16.Location = new System.Drawing.Point(121, 316);
            this.Cuma16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma16.Name = "Cuma16";
            this.Cuma16.Size = new System.Drawing.Size(73, 16);
            this.Cuma16.TabIndex = 18;
            this.Cuma16.Text = "16.00-17.00";
            // 
            // Persembe16
            // 
            this.Persembe16.AutoSize = true;
            this.Persembe16.Location = new System.Drawing.Point(121, 254);
            this.Persembe16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe16.Name = "Persembe16";
            this.Persembe16.Size = new System.Drawing.Size(73, 16);
            this.Persembe16.TabIndex = 19;
            this.Persembe16.Text = "16.00-17.00";
            // 
            // Carsamba16
            // 
            this.Carsamba16.AutoSize = true;
            this.Carsamba16.Location = new System.Drawing.Point(121, 194);
            this.Carsamba16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba16.Name = "Carsamba16";
            this.Carsamba16.Size = new System.Drawing.Size(73, 16);
            this.Carsamba16.TabIndex = 20;
            this.Carsamba16.Text = "16.00-17.00";
            // 
            // Pazar16
            // 
            this.Pazar16.AutoSize = true;
            this.Pazar16.Location = new System.Drawing.Point(121, 462);
            this.Pazar16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar16.Name = "Pazar16";
            this.Pazar16.Size = new System.Drawing.Size(73, 16);
            this.Pazar16.TabIndex = 21;
            this.Pazar16.Text = "16.00-17.00";
            // 
            // Pazar17
            // 
            this.Pazar17.AutoSize = true;
            this.Pazar17.Location = new System.Drawing.Point(261, 462);
            this.Pazar17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar17.Name = "Pazar17";
            this.Pazar17.Size = new System.Drawing.Size(73, 16);
            this.Pazar17.TabIndex = 22;
            this.Pazar17.Text = "17.00-18.00";
            // 
            // Cumartesi17
            // 
            this.Cumartesi17.AutoSize = true;
            this.Cumartesi17.Location = new System.Drawing.Point(261, 384);
            this.Cumartesi17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi17.Name = "Cumartesi17";
            this.Cumartesi17.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi17.TabIndex = 23;
            this.Cumartesi17.Text = "17.00-18.00";
            // 
            // Cuma17
            // 
            this.Cuma17.AutoSize = true;
            this.Cuma17.Location = new System.Drawing.Point(261, 316);
            this.Cuma17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma17.Name = "Cuma17";
            this.Cuma17.Size = new System.Drawing.Size(73, 16);
            this.Cuma17.TabIndex = 24;
            this.Cuma17.Text = "17.00-18.00";
            // 
            // Persembe17
            // 
            this.Persembe17.AutoSize = true;
            this.Persembe17.Location = new System.Drawing.Point(261, 254);
            this.Persembe17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe17.Name = "Persembe17";
            this.Persembe17.Size = new System.Drawing.Size(73, 16);
            this.Persembe17.TabIndex = 25;
            this.Persembe17.Text = "17.00-18.00";
            // 
            // Carsamba17
            // 
            this.Carsamba17.AutoSize = true;
            this.Carsamba17.Location = new System.Drawing.Point(261, 194);
            this.Carsamba17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba17.Name = "Carsamba17";
            this.Carsamba17.Size = new System.Drawing.Size(73, 16);
            this.Carsamba17.TabIndex = 26;
            this.Carsamba17.Text = "17.00-18.00";
            // 
            // Sali17
            // 
            this.Sali17.AutoSize = true;
            this.Sali17.Location = new System.Drawing.Point(261, 135);
            this.Sali17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali17.Name = "Sali17";
            this.Sali17.Size = new System.Drawing.Size(73, 16);
            this.Sali17.TabIndex = 27;
            this.Sali17.Text = "17.00-18.00";
            // 
            // Cumartesi18
            // 
            this.Cumartesi18.AutoSize = true;
            this.Cumartesi18.Location = new System.Drawing.Point(391, 384);
            this.Cumartesi18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi18.Name = "Cumartesi18";
            this.Cumartesi18.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi18.TabIndex = 28;
            this.Cumartesi18.Text = "18.00-19.00";
            // 
            // Cuma18
            // 
            this.Cuma18.AutoSize = true;
            this.Cuma18.Location = new System.Drawing.Point(391, 316);
            this.Cuma18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma18.Name = "Cuma18";
            this.Cuma18.Size = new System.Drawing.Size(73, 16);
            this.Cuma18.TabIndex = 29;
            this.Cuma18.Text = "18.00-19.00";
            // 
            // Persembe18
            // 
            this.Persembe18.AutoSize = true;
            this.Persembe18.Location = new System.Drawing.Point(391, 254);
            this.Persembe18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe18.Name = "Persembe18";
            this.Persembe18.Size = new System.Drawing.Size(73, 16);
            this.Persembe18.TabIndex = 30;
            this.Persembe18.Text = "18.00-19.00";
            // 
            // Carsamba18
            // 
            this.Carsamba18.AutoSize = true;
            this.Carsamba18.Location = new System.Drawing.Point(391, 194);
            this.Carsamba18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba18.Name = "Carsamba18";
            this.Carsamba18.Size = new System.Drawing.Size(73, 16);
            this.Carsamba18.TabIndex = 31;
            this.Carsamba18.Text = "18.00-19.00";
            // 
            // Sali18
            // 
            this.Sali18.AutoSize = true;
            this.Sali18.Location = new System.Drawing.Point(391, 135);
            this.Sali18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali18.Name = "Sali18";
            this.Sali18.Size = new System.Drawing.Size(73, 16);
            this.Sali18.TabIndex = 32;
            this.Sali18.Text = "18.00-19.00";
            // 
            // Pazar18
            // 
            this.Pazar18.AutoSize = true;
            this.Pazar18.Location = new System.Drawing.Point(391, 462);
            this.Pazar18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar18.Name = "Pazar18";
            this.Pazar18.Size = new System.Drawing.Size(73, 16);
            this.Pazar18.TabIndex = 33;
            this.Pazar18.Text = "18.00-19.00";
            // 
            // Persembe19
            // 
            this.Persembe19.AutoSize = true;
            this.Persembe19.Location = new System.Drawing.Point(512, 254);
            this.Persembe19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe19.Name = "Persembe19";
            this.Persembe19.Size = new System.Drawing.Size(73, 16);
            this.Persembe19.TabIndex = 34;
            this.Persembe19.Text = "19.00-20.00";
            // 
            // Pazar19
            // 
            this.Pazar19.AutoSize = true;
            this.Pazar19.Location = new System.Drawing.Point(512, 462);
            this.Pazar19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar19.Name = "Pazar19";
            this.Pazar19.Size = new System.Drawing.Size(73, 16);
            this.Pazar19.TabIndex = 35;
            this.Pazar19.Text = "19.00-20.00";
            // 
            // Cumartesi19
            // 
            this.Cumartesi19.AutoSize = true;
            this.Cumartesi19.Location = new System.Drawing.Point(512, 384);
            this.Cumartesi19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi19.Name = "Cumartesi19";
            this.Cumartesi19.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi19.TabIndex = 36;
            this.Cumartesi19.Text = "19.00-20.00";
            // 
            // Cuma19
            // 
            this.Cuma19.AutoSize = true;
            this.Cuma19.Location = new System.Drawing.Point(512, 316);
            this.Cuma19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma19.Name = "Cuma19";
            this.Cuma19.Size = new System.Drawing.Size(73, 16);
            this.Cuma19.TabIndex = 37;
            this.Cuma19.Text = "19.00-20.00";
            // 
            // Carsamba19
            // 
            this.Carsamba19.AutoSize = true;
            this.Carsamba19.Location = new System.Drawing.Point(512, 194);
            this.Carsamba19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba19.Name = "Carsamba19";
            this.Carsamba19.Size = new System.Drawing.Size(73, 16);
            this.Carsamba19.TabIndex = 38;
            this.Carsamba19.Text = "19.00-20.00";
            // 
            // Sali19
            // 
            this.Sali19.AutoSize = true;
            this.Sali19.Location = new System.Drawing.Point(512, 135);
            this.Sali19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali19.Name = "Sali19";
            this.Sali19.Size = new System.Drawing.Size(73, 16);
            this.Sali19.TabIndex = 39;
            this.Sali19.Text = "19.00-20.00";
            // 
            // Sali20
            // 
            this.Sali20.AutoSize = true;
            this.Sali20.Location = new System.Drawing.Point(629, 135);
            this.Sali20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali20.Name = "Sali20";
            this.Sali20.Size = new System.Drawing.Size(73, 16);
            this.Sali20.TabIndex = 40;
            this.Sali20.Text = "20.00-21.00";
            // 
            // Cumartesi20
            // 
            this.Cumartesi20.AutoSize = true;
            this.Cumartesi20.Location = new System.Drawing.Point(629, 384);
            this.Cumartesi20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi20.Name = "Cumartesi20";
            this.Cumartesi20.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi20.TabIndex = 41;
            this.Cumartesi20.Text = "20.00-21.00";
            // 
            // Cuma20
            // 
            this.Cuma20.AutoSize = true;
            this.Cuma20.Location = new System.Drawing.Point(629, 316);
            this.Cuma20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma20.Name = "Cuma20";
            this.Cuma20.Size = new System.Drawing.Size(73, 16);
            this.Cuma20.TabIndex = 42;
            this.Cuma20.Text = "20.00-21.00";
            // 
            // Persembe20
            // 
            this.Persembe20.AutoSize = true;
            this.Persembe20.Location = new System.Drawing.Point(629, 254);
            this.Persembe20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe20.Name = "Persembe20";
            this.Persembe20.Size = new System.Drawing.Size(73, 16);
            this.Persembe20.TabIndex = 43;
            this.Persembe20.Text = "20.00-21.00";
            // 
            // Carsamba20
            // 
            this.Carsamba20.AutoSize = true;
            this.Carsamba20.Location = new System.Drawing.Point(629, 194);
            this.Carsamba20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba20.Name = "Carsamba20";
            this.Carsamba20.Size = new System.Drawing.Size(73, 16);
            this.Carsamba20.TabIndex = 44;
            this.Carsamba20.Text = "20.00-21.00";
            // 
            // Pazar20
            // 
            this.Pazar20.AutoSize = true;
            this.Pazar20.Location = new System.Drawing.Point(629, 462);
            this.Pazar20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar20.Name = "Pazar20";
            this.Pazar20.Size = new System.Drawing.Size(73, 16);
            this.Pazar20.TabIndex = 45;
            this.Pazar20.Text = "20.00-21.00";
            // 
            // Pazar21
            // 
            this.Pazar21.AutoSize = true;
            this.Pazar21.Location = new System.Drawing.Point(751, 462);
            this.Pazar21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar21.Name = "Pazar21";
            this.Pazar21.Size = new System.Drawing.Size(73, 16);
            this.Pazar21.TabIndex = 46;
            this.Pazar21.Text = "21.00-22.00";
            // 
            // Cumartesi21
            // 
            this.Cumartesi21.AutoSize = true;
            this.Cumartesi21.Location = new System.Drawing.Point(751, 384);
            this.Cumartesi21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi21.Name = "Cumartesi21";
            this.Cumartesi21.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi21.TabIndex = 47;
            this.Cumartesi21.Text = "21.00-22.00";
            // 
            // Cuma21
            // 
            this.Cuma21.AutoSize = true;
            this.Cuma21.Location = new System.Drawing.Point(751, 316);
            this.Cuma21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma21.Name = "Cuma21";
            this.Cuma21.Size = new System.Drawing.Size(73, 16);
            this.Cuma21.TabIndex = 48;
            this.Cuma21.Text = "21.00-22.00";
            // 
            // Persembe21
            // 
            this.Persembe21.AutoSize = true;
            this.Persembe21.Location = new System.Drawing.Point(751, 254);
            this.Persembe21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe21.Name = "Persembe21";
            this.Persembe21.Size = new System.Drawing.Size(73, 16);
            this.Persembe21.TabIndex = 49;
            this.Persembe21.Text = "21.00-22.00";
            // 
            // Carsamba21
            // 
            this.Carsamba21.AutoSize = true;
            this.Carsamba21.Location = new System.Drawing.Point(751, 194);
            this.Carsamba21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba21.Name = "Carsamba21";
            this.Carsamba21.Size = new System.Drawing.Size(73, 16);
            this.Carsamba21.TabIndex = 50;
            this.Carsamba21.Text = "21.00-22.00";
            // 
            // Sali21
            // 
            this.Sali21.AutoSize = true;
            this.Sali21.Location = new System.Drawing.Point(751, 135);
            this.Sali21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali21.Name = "Sali21";
            this.Sali21.Size = new System.Drawing.Size(73, 16);
            this.Sali21.TabIndex = 51;
            this.Sali21.Text = "21.00-22.00";
            // 
            // Cumartesi22
            // 
            this.Cumartesi22.AutoSize = true;
            this.Cumartesi22.Location = new System.Drawing.Point(869, 384);
            this.Cumartesi22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi22.Name = "Cumartesi22";
            this.Cumartesi22.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi22.TabIndex = 52;
            this.Cumartesi22.Text = "22.00-23.00";
            // 
            // Cuma22
            // 
            this.Cuma22.AutoSize = true;
            this.Cuma22.Location = new System.Drawing.Point(869, 316);
            this.Cuma22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma22.Name = "Cuma22";
            this.Cuma22.Size = new System.Drawing.Size(73, 16);
            this.Cuma22.TabIndex = 53;
            this.Cuma22.Text = "22.00-23.00";
            // 
            // Persembe22
            // 
            this.Persembe22.AutoSize = true;
            this.Persembe22.Location = new System.Drawing.Point(869, 254);
            this.Persembe22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe22.Name = "Persembe22";
            this.Persembe22.Size = new System.Drawing.Size(73, 16);
            this.Persembe22.TabIndex = 54;
            this.Persembe22.Text = "22.00-23.00";
            // 
            // Carsamba22
            // 
            this.Carsamba22.AutoSize = true;
            this.Carsamba22.Location = new System.Drawing.Point(869, 194);
            this.Carsamba22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba22.Name = "Carsamba22";
            this.Carsamba22.Size = new System.Drawing.Size(73, 16);
            this.Carsamba22.TabIndex = 55;
            this.Carsamba22.Text = "22.00-23.00";
            // 
            // Sali22
            // 
            this.Sali22.AutoSize = true;
            this.Sali22.Location = new System.Drawing.Point(869, 135);
            this.Sali22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali22.Name = "Sali22";
            this.Sali22.Size = new System.Drawing.Size(73, 16);
            this.Sali22.TabIndex = 56;
            this.Sali22.Text = "22.00-23.00";
            // 
            // Pazar22
            // 
            this.Pazar22.AutoSize = true;
            this.Pazar22.Location = new System.Drawing.Point(869, 462);
            this.Pazar22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar22.Name = "Pazar22";
            this.Pazar22.Size = new System.Drawing.Size(73, 16);
            this.Pazar22.TabIndex = 57;
            this.Pazar22.Text = "22.00-23.00";
            // 
            // Cumartesi23
            // 
            this.Cumartesi23.AutoSize = true;
            this.Cumartesi23.Location = new System.Drawing.Point(979, 384);
            this.Cumartesi23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cumartesi23.Name = "Cumartesi23";
            this.Cumartesi23.Size = new System.Drawing.Size(73, 16);
            this.Cumartesi23.TabIndex = 58;
            this.Cumartesi23.Text = "23.00-00.00";
            // 
            // Cuma23
            // 
            this.Cuma23.AutoSize = true;
            this.Cuma23.Location = new System.Drawing.Point(979, 316);
            this.Cuma23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cuma23.Name = "Cuma23";
            this.Cuma23.Size = new System.Drawing.Size(73, 16);
            this.Cuma23.TabIndex = 59;
            this.Cuma23.Text = "23.00-00.00";
            // 
            // Persembe23
            // 
            this.Persembe23.AutoSize = true;
            this.Persembe23.Location = new System.Drawing.Point(979, 254);
            this.Persembe23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Persembe23.Name = "Persembe23";
            this.Persembe23.Size = new System.Drawing.Size(73, 16);
            this.Persembe23.TabIndex = 60;
            this.Persembe23.Text = "23.00-00.00";
            // 
            // Carsamba23
            // 
            this.Carsamba23.AutoSize = true;
            this.Carsamba23.Location = new System.Drawing.Point(979, 194);
            this.Carsamba23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Carsamba23.Name = "Carsamba23";
            this.Carsamba23.Size = new System.Drawing.Size(73, 16);
            this.Carsamba23.TabIndex = 61;
            this.Carsamba23.Text = "23.00-00.00";
            // 
            // Sali23
            // 
            this.Sali23.AutoSize = true;
            this.Sali23.Location = new System.Drawing.Point(979, 135);
            this.Sali23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sali23.Name = "Sali23";
            this.Sali23.Size = new System.Drawing.Size(73, 16);
            this.Sali23.TabIndex = 62;
            this.Sali23.Text = "23.00-00.00";
            // 
            // Pazar23
            // 
            this.Pazar23.AutoSize = true;
            this.Pazar23.Location = new System.Drawing.Point(979, 462);
            this.Pazar23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pazar23.Name = "Pazar23";
            this.Pazar23.Size = new System.Drawing.Size(73, 16);
            this.Pazar23.TabIndex = 63;
            this.Pazar23.Text = "23.00-00.00";
            // 
            // btnrzrv
            // 
            this.btnrzrv.Location = new System.Drawing.Point(964, 512);
            this.btnrzrv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrzrv.Name = "btnrzrv";
            this.btnrzrv.Size = new System.Drawing.Size(100, 28);
            this.btnrzrv.TabIndex = 64;
            this.btnrzrv.Text = "Rezerve Et";
            this.btnrzrv.UseVisualStyleBackColor = true;
            this.btnrzrv.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblgun
            // 
            this.lblgun.AutoSize = true;
            this.lblgun.Location = new System.Drawing.Point(16, 512);
            this.lblgun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(31, 16);
            this.lblgun.TabIndex = 65;
            this.lblgun.Text = "Gün";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(16, 548);
            this.lblsaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(35, 16);
            this.lblsaat.TabIndex = 66;
            this.lblsaat.Text = "Saat";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 502);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 67;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 544);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 68;
            // 
            // cmbgun
            // 
            this.cmbgun.FormattingEnabled = true;
            this.cmbgun.Items.AddRange(new object[] {
            "Pazartesi",
            "Sali",
            "Carsamba",
            "Persembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.cmbgun.Location = new System.Drawing.Point(125, 502);
            this.cmbgun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbgun.Name = "cmbgun";
            this.cmbgun.Size = new System.Drawing.Size(160, 24);
            this.cmbgun.TabIndex = 67;
            // 
            // cmbsaat
            // 
            this.cmbsaat.FormattingEnabled = true;
            this.cmbsaat.Items.AddRange(new object[] {
            "16.00-17.00",
            "17.00-18.00",
            "18.00-19.00",
            "19.00-20.00",
            "20.00-21.00",
            "21.00-22.00",
            "22.00-23.00",
            "23.00-00.00"});
            this.cmbsaat.Location = new System.Drawing.Point(125, 538);
            this.cmbsaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbsaat.Name = "cmbsaat";
            this.cmbsaat.Size = new System.Drawing.Size(160, 24);
            this.cmbsaat.TabIndex = 68;
            // 
            // Rezervasyon_Görüntüleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 575);
            this.Controls.Add(this.cmbsaat);
            this.Controls.Add(this.cmbgun);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.lblgun);
            this.Controls.Add(this.btnrzrv);
            this.Controls.Add(this.Pazar23);
            this.Controls.Add(this.Sali23);
            this.Controls.Add(this.Carsamba23);
            this.Controls.Add(this.Persembe23);
            this.Controls.Add(this.Cuma23);
            this.Controls.Add(this.Cumartesi23);
            this.Controls.Add(this.Pazar22);
            this.Controls.Add(this.Sali22);
            this.Controls.Add(this.Carsamba22);
            this.Controls.Add(this.Persembe22);
            this.Controls.Add(this.Cuma22);
            this.Controls.Add(this.Cumartesi22);
            this.Controls.Add(this.Sali21);
            this.Controls.Add(this.Carsamba21);
            this.Controls.Add(this.Persembe21);
            this.Controls.Add(this.Cuma21);
            this.Controls.Add(this.Cumartesi21);
            this.Controls.Add(this.Pazar21);
            this.Controls.Add(this.Pazar20);
            this.Controls.Add(this.Carsamba20);
            this.Controls.Add(this.Persembe20);
            this.Controls.Add(this.Cuma20);
            this.Controls.Add(this.Cumartesi20);
            this.Controls.Add(this.Sali20);
            this.Controls.Add(this.Sali19);
            this.Controls.Add(this.Carsamba19);
            this.Controls.Add(this.Cuma19);
            this.Controls.Add(this.Cumartesi19);
            this.Controls.Add(this.Pazar19);
            this.Controls.Add(this.Persembe19);
            this.Controls.Add(this.Pazar18);
            this.Controls.Add(this.Sali18);
            this.Controls.Add(this.Carsamba18);
            this.Controls.Add(this.Persembe18);
            this.Controls.Add(this.Cuma18);
            this.Controls.Add(this.Cumartesi18);
            this.Controls.Add(this.Sali17);
            this.Controls.Add(this.Carsamba17);
            this.Controls.Add(this.Persembe17);
            this.Controls.Add(this.Cuma17);
            this.Controls.Add(this.Cumartesi17);
            this.Controls.Add(this.Pazar17);
            this.Controls.Add(this.Pazar16);
            this.Controls.Add(this.Carsamba16);
            this.Controls.Add(this.Persembe16);
            this.Controls.Add(this.Cuma16);
            this.Controls.Add(this.Cumartesi16);
            this.Controls.Add(this.Sali16);
            this.Controls.Add(this.Pazartesi19);
            this.Controls.Add(this.Pazartesi23);
            this.Controls.Add(this.Pazartesi22);
            this.Controls.Add(this.Pazartesi21);
            this.Controls.Add(this.Pazartesi20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Pazartesi18);
            this.Controls.Add(this.Pazartesi17);
            this.Controls.Add(this.Pazartesi16);
            this.Controls.Add(this.lblpaz);
            this.Controls.Add(this.lblcmt);
            this.Controls.Add(this.lblcuma);
            this.Controls.Add(this.lblpers);
            this.Controls.Add(this.Carsamba);
            this.Controls.Add(this.lblsali);
            this.Controls.Add(this.lblpzt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rezervasyon_Görüntüleme";
            this.Text = "Rezervasyon_Görüntüleme";
            this.Load += new System.EventHandler(this.Rezervasyon_Görüntüleme_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Labels(ArrayList labels)
        {
            labels.Add(Carsamba);
            labels.Add(Pazartesi16);
            labels.Add(Pazartesi17);
            labels.Add(Pazartesi18);
            labels.Add(Pazartesi19);
            labels.Add(Pazartesi20);
            labels.Add(Pazartesi21);
            labels.Add(Pazartesi22);
            labels.Add(Pazartesi23);
            labels.Add(Sali16);
            labels.Add(Sali17);
            labels.Add(Sali18);
            labels.Add(Sali19);
            labels.Add(Sali20);
            labels.Add(Sali21);
            labels.Add(Sali22);
            labels.Add(Sali23);
            labels.Add(Carsamba16);
            labels.Add(Carsamba17);
            labels.Add(Carsamba18);
            labels.Add(Carsamba19);
            labels.Add(Carsamba20);
            labels.Add(Carsamba21);
            labels.Add(Carsamba22);
            labels.Add(Carsamba23);
            labels.Add(Persembe16);
            labels.Add(Persembe17);
            labels.Add(Persembe18);
            labels.Add(Persembe19);
            labels.Add(Persembe20);
            labels.Add(Persembe21);
            labels.Add(Persembe22);
            labels.Add(Persembe23);
            labels.Add(Cuma16);
            labels.Add(Cuma17);
            labels.Add(Cuma18);
            labels.Add(Cuma19);
            labels.Add(Cuma20);
            labels.Add(Cuma21);
            labels.Add(Cuma22);
            labels.Add(Cuma23);
            labels.Add(Cumartesi16);
            labels.Add(Cumartesi17);
            labels.Add(Cumartesi18);
            labels.Add(Cumartesi19);
            labels.Add(Cumartesi20);
            labels.Add(Cumartesi21);
            labels.Add(Cumartesi22);
            labels.Add(Cumartesi23);
            labels.Add(Pazar16);
            labels.Add(Pazar17);
            labels.Add(Pazar18);
            labels.Add(Pazar19);
            labels.Add(Pazar20);
            labels.Add(Pazar21);
            labels.Add(Pazar22);
            labels.Add(Pazar23);
        }


        #endregion

        private System.Windows.Forms.Label lblpzt;
        private System.Windows.Forms.Label lblsali;
        private System.Windows.Forms.Label Carsamba;
        private System.Windows.Forms.Label lblpers;
        private System.Windows.Forms.Label lblcuma;
        private System.Windows.Forms.Label lblcmt;
        private System.Windows.Forms.Label lblpaz;
        private System.Windows.Forms.Label Pazartesi16;
        private System.Windows.Forms.Label Pazartesi17;
        private System.Windows.Forms.Label Pazartesi18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Pazartesi20;
        private System.Windows.Forms.Label Pazartesi21;
        private System.Windows.Forms.Label Pazartesi22;
        private System.Windows.Forms.Label Pazartesi23;
        private System.Windows.Forms.Label Pazartesi19;
        private System.Windows.Forms.Label Sali16;
        private System.Windows.Forms.Label Cumartesi16;
        private System.Windows.Forms.Label Cuma16;
        private System.Windows.Forms.Label Persembe16;
        private System.Windows.Forms.Label Carsamba16;
        private System.Windows.Forms.Label Pazar16;
        private System.Windows.Forms.Label Pazar17;
        private System.Windows.Forms.Label Cumartesi17;
        private System.Windows.Forms.Label Cuma17;
        private System.Windows.Forms.Label Persembe17;
        private System.Windows.Forms.Label Carsamba17;
        private System.Windows.Forms.Label Sali17;
        private System.Windows.Forms.Label Cumartesi18;
        private System.Windows.Forms.Label Cuma18;
        private System.Windows.Forms.Label Persembe18;
        private System.Windows.Forms.Label Carsamba18;
        private System.Windows.Forms.Label Sali18;
        private System.Windows.Forms.Label Pazar18;
        private System.Windows.Forms.Label Persembe19;
        private System.Windows.Forms.Label Pazar19;
        private System.Windows.Forms.Label Cumartesi19;
        private System.Windows.Forms.Label Cuma19;
        private System.Windows.Forms.Label Carsamba19;
        private System.Windows.Forms.Label Sali19;
        private System.Windows.Forms.Label Sali20;
        private System.Windows.Forms.Label Cumartesi20;
        private System.Windows.Forms.Label Cuma20;
        private System.Windows.Forms.Label Persembe20;
        private System.Windows.Forms.Label Carsamba20;
        private System.Windows.Forms.Label Pazar20;
        private System.Windows.Forms.Label Pazar21;
        private System.Windows.Forms.Label Cumartesi21;
        private System.Windows.Forms.Label Cuma21;
        private System.Windows.Forms.Label Persembe21;
        private System.Windows.Forms.Label Carsamba21;
        private System.Windows.Forms.Label Sali21;
        private System.Windows.Forms.Label Cumartesi22;
        private System.Windows.Forms.Label Cuma22;
        private System.Windows.Forms.Label Persembe22;
        private System.Windows.Forms.Label Carsamba22;
        private System.Windows.Forms.Label Sali22;
        private System.Windows.Forms.Label Pazar22;
        private System.Windows.Forms.Label Cumartesi23;
        private System.Windows.Forms.Label Cuma23;
        private System.Windows.Forms.Label Persembe23;
        private System.Windows.Forms.Label Carsamba23;
        private System.Windows.Forms.Label Sali23;
        private System.Windows.Forms.Label Pazar23;
        private System.Windows.Forms.Button btnrzrv;
        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbgun;
        private System.Windows.Forms.ComboBox cmbsaat;
    }
}