namespace Tandlægerne_Smil.Views
{
    partial class BehandlingAfslut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BehandlingAfslut));
            this.listView_BehandlingsList = new System.Windows.Forms.ListView();
            this.Behandling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_FjernBehandling = new System.Windows.Forms.Button();
            this.comboBox_Behandlinger = new System.Windows.Forms.ComboBox();
            this.button_TiljøjBehandling = new System.Windows.Forms.Button();
            this.textBox_PatientNr = new System.Windows.Forms.TextBox();
            this.textBox_Fornavn = new System.Windows.Forms.TextBox();
            this.textBox_Efternanv = new System.Windows.Forms.TextBox();
            this.textBox_Cpr = new System.Windows.Forms.TextBox();
            this.textBox_Adresse = new System.Windows.Forms.TextBox();
            this.textBox_Postnr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Tlfnr = new System.Windows.Forms.TextBox();
            this.textBox_Læge = new System.Windows.Forms.TextBox();
            this.textBox_Lokale = new System.Windows.Forms.TextBox();
            this.textBox_dato = new System.Windows.Forms.TextBox();
            this.lage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_GemOgFaktur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_BehandlingsList
            // 
            this.listView_BehandlingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Behandling,
            this.Pris});
            this.listView_BehandlingsList.Location = new System.Drawing.Point(12, 249);
            this.listView_BehandlingsList.Name = "listView_BehandlingsList";
            this.listView_BehandlingsList.Size = new System.Drawing.Size(407, 174);
            this.listView_BehandlingsList.TabIndex = 0;
            this.listView_BehandlingsList.UseCompatibleStateImageBehavior = false;
            this.listView_BehandlingsList.View = System.Windows.Forms.View.Details;
            // 
            // Behandling
            // 
            this.Behandling.Text = "Behandling";
            this.Behandling.Width = 329;
            // 
            // Pris
            // 
            this.Pris.Text = "Pris";
            // 
            // button_FjernBehandling
            // 
            this.button_FjernBehandling.Location = new System.Drawing.Point(12, 220);
            this.button_FjernBehandling.Name = "button_FjernBehandling";
            this.button_FjernBehandling.Size = new System.Drawing.Size(95, 23);
            this.button_FjernBehandling.TabIndex = 1;
            this.button_FjernBehandling.Text = "Fjern Behandling";
            this.button_FjernBehandling.UseVisualStyleBackColor = true;
            this.button_FjernBehandling.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Behandlinger
            // 
            this.comboBox_Behandlinger.FormattingEnabled = true;
            this.comboBox_Behandlinger.Location = new System.Drawing.Point(113, 220);
            this.comboBox_Behandlinger.Name = "comboBox_Behandlinger";
            this.comboBox_Behandlinger.Size = new System.Drawing.Size(225, 21);
            this.comboBox_Behandlinger.TabIndex = 2;
            // 
            // button_TiljøjBehandling
            // 
            this.button_TiljøjBehandling.Location = new System.Drawing.Point(344, 220);
            this.button_TiljøjBehandling.Name = "button_TiljøjBehandling";
            this.button_TiljøjBehandling.Size = new System.Drawing.Size(75, 23);
            this.button_TiljøjBehandling.TabIndex = 3;
            this.button_TiljøjBehandling.Text = "Tiljøj";
            this.button_TiljøjBehandling.UseVisualStyleBackColor = true;
            this.button_TiljøjBehandling.Click += new System.EventHandler(this.button_TiljøjBehandling_Click);
            // 
            // textBox_PatientNr
            // 
            this.textBox_PatientNr.Location = new System.Drawing.Point(69, 12);
            this.textBox_PatientNr.Name = "textBox_PatientNr";
            this.textBox_PatientNr.ReadOnly = true;
            this.textBox_PatientNr.Size = new System.Drawing.Size(143, 20);
            this.textBox_PatientNr.TabIndex = 4;
            // 
            // textBox_Fornavn
            // 
            this.textBox_Fornavn.Location = new System.Drawing.Point(69, 38);
            this.textBox_Fornavn.Name = "textBox_Fornavn";
            this.textBox_Fornavn.ReadOnly = true;
            this.textBox_Fornavn.Size = new System.Drawing.Size(143, 20);
            this.textBox_Fornavn.TabIndex = 5;
            // 
            // textBox_Efternanv
            // 
            this.textBox_Efternanv.Location = new System.Drawing.Point(69, 64);
            this.textBox_Efternanv.Name = "textBox_Efternanv";
            this.textBox_Efternanv.ReadOnly = true;
            this.textBox_Efternanv.Size = new System.Drawing.Size(143, 20);
            this.textBox_Efternanv.TabIndex = 6;
            this.textBox_Efternanv.TextChanged += new System.EventHandler(this.textBox_Efternanv_TextChanged);
            // 
            // textBox_Cpr
            // 
            this.textBox_Cpr.Location = new System.Drawing.Point(69, 90);
            this.textBox_Cpr.Name = "textBox_Cpr";
            this.textBox_Cpr.ReadOnly = true;
            this.textBox_Cpr.Size = new System.Drawing.Size(143, 20);
            this.textBox_Cpr.TabIndex = 7;
            // 
            // textBox_Adresse
            // 
            this.textBox_Adresse.Location = new System.Drawing.Point(69, 116);
            this.textBox_Adresse.Name = "textBox_Adresse";
            this.textBox_Adresse.ReadOnly = true;
            this.textBox_Adresse.Size = new System.Drawing.Size(143, 20);
            this.textBox_Adresse.TabIndex = 8;
            // 
            // textBox_Postnr
            // 
            this.textBox_Postnr.Location = new System.Drawing.Point(69, 142);
            this.textBox_Postnr.Name = "textBox_Postnr";
            this.textBox_Postnr.ReadOnly = true;
            this.textBox_Postnr.Size = new System.Drawing.Size(143, 20);
            this.textBox_Postnr.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient Nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Efternavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CPR-nr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Postnr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Telefonnr";
            // 
            // textBox_Tlfnr
            // 
            this.textBox_Tlfnr.Location = new System.Drawing.Point(69, 168);
            this.textBox_Tlfnr.Name = "textBox_Tlfnr";
            this.textBox_Tlfnr.ReadOnly = true;
            this.textBox_Tlfnr.Size = new System.Drawing.Size(143, 20);
            this.textBox_Tlfnr.TabIndex = 17;
            // 
            // textBox_Læge
            // 
            this.textBox_Læge.Location = new System.Drawing.Point(303, 12);
            this.textBox_Læge.Name = "textBox_Læge";
            this.textBox_Læge.Size = new System.Drawing.Size(116, 20);
            this.textBox_Læge.TabIndex = 18;
            // 
            // textBox_Lokale
            // 
            this.textBox_Lokale.Location = new System.Drawing.Point(303, 38);
            this.textBox_Lokale.Name = "textBox_Lokale";
            this.textBox_Lokale.Size = new System.Drawing.Size(116, 20);
            this.textBox_Lokale.TabIndex = 19;
            // 
            // textBox_dato
            // 
            this.textBox_dato.Location = new System.Drawing.Point(303, 64);
            this.textBox_dato.Name = "textBox_dato";
            this.textBox_dato.Size = new System.Drawing.Size(116, 20);
            this.textBox_dato.TabIndex = 20;
            // 
            // lage
            // 
            this.lage.AutoSize = true;
            this.lage.Location = new System.Drawing.Point(266, 15);
            this.lage.Name = "lage";
            this.lage.Size = new System.Drawing.Size(31, 13);
            this.lage.TabIndex = 21;
            this.lage.Text = "læge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "lokale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "dato";
            // 
            // button_GemOgFaktur
            // 
            this.button_GemOgFaktur.Location = new System.Drawing.Point(319, 191);
            this.button_GemOgFaktur.Name = "button_GemOgFaktur";
            this.button_GemOgFaktur.Size = new System.Drawing.Size(100, 23);
            this.button_GemOgFaktur.TabIndex = 24;
            this.button_GemOgFaktur.Text = "Gem og afslut";
            this.button_GemOgFaktur.UseVisualStyleBackColor = true;
            this.button_GemOgFaktur.Click += new System.EventHandler(this.button_GemOgFaktur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tandlægerne_Smil.Properties.Resources.Tandlægerne_smil_Logo_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(238, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 81);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // BehandlingAfslut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_GemOgFaktur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lage);
            this.Controls.Add(this.textBox_dato);
            this.Controls.Add(this.textBox_Lokale);
            this.Controls.Add(this.textBox_Læge);
            this.Controls.Add(this.textBox_Tlfnr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Postnr);
            this.Controls.Add(this.textBox_Adresse);
            this.Controls.Add(this.textBox_Cpr);
            this.Controls.Add(this.textBox_Efternanv);
            this.Controls.Add(this.textBox_Fornavn);
            this.Controls.Add(this.textBox_PatientNr);
            this.Controls.Add(this.button_TiljøjBehandling);
            this.Controls.Add(this.comboBox_Behandlinger);
            this.Controls.Add(this.button_FjernBehandling);
            this.Controls.Add(this.listView_BehandlingsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BehandlingAfslut";
            this.Text = "BehandlingAfslut";
            this.Load += new System.EventHandler(this.BehandlingAfslut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_BehandlingsList;
        private System.Windows.Forms.Button button_FjernBehandling;
        private System.Windows.Forms.ComboBox comboBox_Behandlinger;
        private System.Windows.Forms.Button button_TiljøjBehandling;
        private System.Windows.Forms.TextBox textBox_PatientNr;
        private System.Windows.Forms.TextBox textBox_Fornavn;
        private System.Windows.Forms.TextBox textBox_Efternanv;
        private System.Windows.Forms.TextBox textBox_Cpr;
        private System.Windows.Forms.TextBox textBox_Adresse;
        private System.Windows.Forms.TextBox textBox_Postnr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Tlfnr;
        private System.Windows.Forms.TextBox textBox_Læge;
        private System.Windows.Forms.TextBox textBox_Lokale;
        private System.Windows.Forms.TextBox textBox_dato;
        private System.Windows.Forms.Label lage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader Behandling;
        private System.Windows.Forms.ColumnHeader Pris;
        private System.Windows.Forms.Button button_GemOgFaktur;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}