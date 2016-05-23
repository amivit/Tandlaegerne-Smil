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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPatient = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerBooking = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxLæge = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxBehandling = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxLokale = new System.Windows.Forms.ComboBox();
			this.textBoxNoter = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Patient";
			// 
			// textBoxPatient
			// 
			this.textBoxPatient.Location = new System.Drawing.Point(12, 30);
			this.textBoxPatient.Name = "textBoxPatient";
			this.textBoxPatient.ReadOnly = true;
			this.textBoxPatient.Size = new System.Drawing.Size(194, 20);
			this.textBoxPatient.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tidspunkt";
			// 
			// dateTimePickerBooking
			// 
			this.dateTimePickerBooking.Checked = false;
			this.dateTimePickerBooking.CustomFormat = "dd/MM/yy HH:mm";
			this.dateTimePickerBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerBooking.Location = new System.Drawing.Point(12, 69);
			this.dateTimePickerBooking.Name = "dateTimePickerBooking";
			this.dateTimePickerBooking.Size = new System.Drawing.Size(97, 20);
			this.dateTimePickerBooking.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Læge";
			// 
			// comboBoxLæge
			// 
			this.comboBoxLæge.FormattingEnabled = true;
			this.comboBoxLæge.Location = new System.Drawing.Point(12, 108);
			this.comboBoxLæge.Name = "comboBoxLæge";
			this.comboBoxLæge.Size = new System.Drawing.Size(194, 21);
			this.comboBoxLæge.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Lokale";
			// 
			// comboBoxBehandling
			// 
			this.comboBoxBehandling.FormattingEnabled = true;
			this.comboBoxBehandling.Location = new System.Drawing.Point(12, 148);
			this.comboBoxBehandling.Name = "comboBoxBehandling";
			this.comboBoxBehandling.Size = new System.Drawing.Size(194, 21);
			this.comboBoxBehandling.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Behandling";
			// 
			// comboBoxLokale
			// 
			this.comboBoxLokale.FormattingEnabled = true;
			this.comboBoxLokale.Location = new System.Drawing.Point(12, 188);
			this.comboBoxLokale.Name = "comboBoxLokale";
			this.comboBoxLokale.Size = new System.Drawing.Size(194, 21);
			this.comboBoxLokale.TabIndex = 9;
			// 
			// textBoxNoter
			// 
			this.textBoxNoter.Location = new System.Drawing.Point(412, 19);
			this.textBoxNoter.Multiline = true;
			this.textBoxNoter.Name = "textBoxNoter";
			this.textBoxNoter.ReadOnly = true;
			this.textBoxNoter.Size = new System.Drawing.Size(272, 190);
			this.textBoxNoter.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(409, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Patient Noter";
			// 
			// BookingOpretRedigere
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 342);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxNoter);
			this.Controls.Add(this.comboBoxLokale);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxBehandling);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxLæge);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePickerBooking);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPatient);
			this.Controls.Add(this.label1);
			this.Name = "BookingOpretRedigere";
			this.Text = "BookingOpret";
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
		public System.Windows.Forms.DateTimePicker dateTimePickerBooking;
		public System.Windows.Forms.ComboBox comboBoxLæge;
		public System.Windows.Forms.ComboBox comboBoxBehandling;
		public System.Windows.Forms.ComboBox comboBoxLokale;
		public System.Windows.Forms.TextBox textBoxNoter;
	}
}