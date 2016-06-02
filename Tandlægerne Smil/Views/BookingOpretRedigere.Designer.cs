namespace Tandlægerne_Smil.Views
{
    partial class BookingOpretRedigere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingOpretRedigere));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLæge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBehandling = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLokale = new System.Windows.Forms.ComboBox();
            this.textBoxNoter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTilføj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewBehandling = new System.Windows.Forms.ListView();
            this.ColumnBeskrivelse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnslåetTid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeOnlyPicker = new System.Windows.Forms.DateTimePicker();
            this.buttonGemBooking = new System.Windows.Forms.Button();
            this.buttonSletBehandling = new System.Windows.Forms.Button();
            this.labelTandlægeSkræk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Location = new System.Drawing.Point(10, 30);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.ReadOnly = true;
            this.textBoxPatient.Size = new System.Drawing.Size(194, 20);
            this.textBoxPatient.TabIndex = 1;
            this.textBoxPatient.TextChanged += new System.EventHandler(this.textBoxPatient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tidspunkt";
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "dd/MM/yy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(10, 69);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(95, 20);
            this.datePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Læge";
            // 
            // comboBoxLæge
            // 
            this.comboBoxLæge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLæge.FormattingEnabled = true;
            this.comboBoxLæge.Location = new System.Drawing.Point(10, 148);
            this.comboBoxLæge.Name = "comboBoxLæge";
            this.comboBoxLæge.Size = new System.Drawing.Size(194, 21);
            this.comboBoxLæge.TabIndex = 5;
            this.comboBoxLæge.SelectedIndexChanged += new System.EventHandler(this.comboBoxLæge_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lokale";
            // 
            // comboBoxBehandling
            // 
            this.comboBoxBehandling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBehandling.FormattingEnabled = true;
            this.comboBoxBehandling.Location = new System.Drawing.Point(10, 188);
            this.comboBoxBehandling.Name = "comboBoxBehandling";
            this.comboBoxBehandling.Size = new System.Drawing.Size(194, 21);
            this.comboBoxBehandling.TabIndex = 7;
            this.comboBoxBehandling.SelectedIndexChanged += new System.EventHandler(this.comboBoxBehandling_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Behandling";
            // 
            // comboBoxLokale
            // 
            this.comboBoxLokale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLokale.FormattingEnabled = true;
            this.comboBoxLokale.Location = new System.Drawing.Point(10, 257);
            this.comboBoxLokale.Name = "comboBoxLokale";
            this.comboBoxLokale.Size = new System.Drawing.Size(194, 21);
            this.comboBoxLokale.TabIndex = 9;
            this.comboBoxLokale.SelectedIndexChanged += new System.EventHandler(this.comboBoxLokale_SelectedIndexChanged);
            // 
            // textBoxNoter
            // 
            this.textBoxNoter.Location = new System.Drawing.Point(210, 30);
            this.textBoxNoter.Multiline = true;
            this.textBoxNoter.Name = "textBoxNoter";
            this.textBoxNoter.ReadOnly = true;
            this.textBoxNoter.Size = new System.Drawing.Size(514, 99);
            this.textBoxNoter.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Patient Noter";
            // 
            // buttonTilføj
            // 
            this.buttonTilføj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTilføj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTilføj.Location = new System.Drawing.Point(10, 215);
            this.buttonTilføj.Name = "buttonTilføj";
            this.buttonTilføj.Size = new System.Drawing.Size(94, 23);
            this.buttonTilføj.TabIndex = 12;
            this.buttonTilføj.Text = "Tilføj behandling";
            this.buttonTilføj.UseVisualStyleBackColor = true;
            this.buttonTilføj.Click += new System.EventHandler(this.buttonTilføj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Behandlinger";
            // 
            // listViewBehandling
            // 
            this.listViewBehandling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnBeskrivelse,
            this.ColumnPris,
            this.columnAnslåetTid});
            this.listViewBehandling.Location = new System.Drawing.Point(210, 148);
            this.listViewBehandling.Name = "listViewBehandling";
            this.listViewBehandling.Size = new System.Drawing.Size(514, 182);
            this.listViewBehandling.TabIndex = 15;
            this.listViewBehandling.UseCompatibleStateImageBehavior = false;
            this.listViewBehandling.View = System.Windows.Forms.View.Details;
            this.listViewBehandling.SelectedIndexChanged += new System.EventHandler(this.listViewBehandling_SelectedIndexChanged);
            // 
            // ColumnBeskrivelse
            // 
            this.ColumnBeskrivelse.Text = "Beskrivelse";
            this.ColumnBeskrivelse.Width = 342;
            // 
            // ColumnPris
            // 
            this.ColumnPris.Text = "Pris";
            this.ColumnPris.Width = 70;
            // 
            // columnAnslåetTid
            // 
            this.columnAnslåetTid.Text = "Anslået Tid";
            this.columnAnslåetTid.Width = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dato";
            // 
            // dateTimeOnlyPicker
            // 
            this.dateTimeOnlyPicker.CustomFormat = "HH:mm";
            this.dateTimeOnlyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeOnlyPicker.Location = new System.Drawing.Point(10, 109);
            this.dateTimeOnlyPicker.Name = "dateTimeOnlyPicker";
            this.dateTimeOnlyPicker.ShowUpDown = true;
            this.dateTimeOnlyPicker.Size = new System.Drawing.Size(95, 20);
            this.dateTimeOnlyPicker.TabIndex = 17;
            this.dateTimeOnlyPicker.Value = new System.DateTime(2016, 5, 23, 12, 26, 0, 0);
            this.dateTimeOnlyPicker.ValueChanged += new System.EventHandler(this.dateTimeOnly_ValueChanged);
            // 
            // buttonGemBooking
            // 
            this.buttonGemBooking.Enabled = false;
            this.buttonGemBooking.Location = new System.Drawing.Point(10, 307);
            this.buttonGemBooking.Name = "buttonGemBooking";
            this.buttonGemBooking.Size = new System.Drawing.Size(194, 23);
            this.buttonGemBooking.TabIndex = 18;
            this.buttonGemBooking.Text = "Gem Booking";
            this.buttonGemBooking.UseVisualStyleBackColor = true;
            this.buttonGemBooking.Click += new System.EventHandler(this.buttonGemBooking_Click);
            // 
            // buttonSletBehandling
            // 
            this.buttonSletBehandling.Location = new System.Drawing.Point(110, 215);
            this.buttonSletBehandling.Name = "buttonSletBehandling";
            this.buttonSletBehandling.Size = new System.Drawing.Size(94, 23);
            this.buttonSletBehandling.TabIndex = 19;
            this.buttonSletBehandling.Text = "Slet behandling";
            this.buttonSletBehandling.UseVisualStyleBackColor = true;
            this.buttonSletBehandling.Click += new System.EventHandler(this.buttonSletBehandling_Click);
            // 
            // labelTandlægeSkræk
            // 
            this.labelTandlægeSkræk.AutoSize = true;
            this.labelTandlægeSkræk.Location = new System.Drawing.Point(60, 291);
            this.labelTandlægeSkræk.Name = "labelTandlægeSkræk";
            this.labelTandlægeSkræk.Size = new System.Drawing.Size(86, 13);
            this.labelTandlægeSkræk.TabIndex = 20;
            this.labelTandlægeSkræk.Text = "Tandlægeskræk";
            // 
            // BookingOpretRedigere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 342);
            this.Controls.Add(this.labelTandlægeSkræk);
            this.Controls.Add(this.buttonSletBehandling);
            this.Controls.Add(this.buttonGemBooking);
            this.Controls.Add(this.dateTimeOnlyPicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewBehandling);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonTilføj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNoter);
            this.Controls.Add(this.comboBoxLokale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBehandling);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLæge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPatient);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingOpretRedigere";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingOpretRedigere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox textBoxPatient;
		public System.Windows.Forms.DateTimePicker datePicker;
		public System.Windows.Forms.ComboBox comboBoxLæge;
		public System.Windows.Forms.ComboBox comboBoxBehandling;
		public System.Windows.Forms.ComboBox comboBoxLokale;
		public System.Windows.Forms.TextBox textBoxNoter;
		private System.Windows.Forms.Button buttonTilføj;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColumnHeader ColumnBeskrivelse;
		private System.Windows.Forms.ColumnHeader ColumnPris;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ColumnHeader columnAnslåetTid;
        private System.Windows.Forms.Button buttonGemBooking;
        public System.Windows.Forms.DateTimePicker dateTimeOnlyPicker;
        public System.Windows.Forms.ListView listViewBehandling;
		private System.Windows.Forms.Button buttonSletBehandling;
		private System.Windows.Forms.Label labelTandlægeSkræk;
	}
}