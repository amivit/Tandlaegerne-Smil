namespace Tandlægerne_Smil.Views
{
    partial class AkutPatient
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Patienter", System.Windows.Forms.HorizontalAlignment.Left);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkutPatient));
			this.listViewPatient = new System.Windows.Forms.ListView();
			this.column_Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.comboBoxTidspunkt = new System.Windows.Forms.ComboBox();
			this.buttonOpretAkutBooking = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listViewPatient
			// 
			this.listViewPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Navn,
            this.column_PatientID});
			this.listViewPatient.FullRowSelect = true;
			listViewGroup1.Header = "Patienter";
			listViewGroup1.Name = "listViewGroup1";
			listViewGroup1.Tag = "";
			this.listViewPatient.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
			this.listViewPatient.HideSelection = false;
			this.listViewPatient.Location = new System.Drawing.Point(12, 70);
			this.listViewPatient.MultiSelect = false;
			this.listViewPatient.Name = "listViewPatient";
			this.listViewPatient.Size = new System.Drawing.Size(242, 368);
			this.listViewPatient.TabIndex = 1;
			this.listViewPatient.UseCompatibleStateImageBehavior = false;
			this.listViewPatient.View = System.Windows.Forms.View.Details;
			this.listViewPatient.SelectedIndexChanged += new System.EventHandler(this.listViewPatient_SelectedIndexChanged);
			// 
			// column_Navn
			// 
			this.column_Navn.Text = "Navn";
			this.column_Navn.Width = 140;
			// 
			// column_PatientID
			// 
			this.column_PatientID.Text = "Patient ID";
			this.column_PatientID.Width = 98;
			// 
			// comboBoxTidspunkt
			// 
			this.comboBoxTidspunkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTidspunkt.FormattingEnabled = true;
			this.comboBoxTidspunkt.Location = new System.Drawing.Point(49, 14);
			this.comboBoxTidspunkt.Name = "comboBoxTidspunkt";
			this.comboBoxTidspunkt.Size = new System.Drawing.Size(205, 21);
			this.comboBoxTidspunkt.TabIndex = 2;
			this.comboBoxTidspunkt.SelectedIndexChanged += new System.EventHandler(this.comboBoxTidspunkt_SelectedIndexChanged);
			// 
			// buttonOpretAkutBooking
			// 
			this.buttonOpretAkutBooking.Enabled = false;
			this.buttonOpretAkutBooking.Location = new System.Drawing.Point(12, 41);
			this.buttonOpretAkutBooking.Name = "buttonOpretAkutBooking";
			this.buttonOpretAkutBooking.Size = new System.Drawing.Size(242, 23);
			this.buttonOpretAkutBooking.TabIndex = 3;
			this.buttonOpretAkutBooking.Text = "Opret Akut Booking";
			this.buttonOpretAkutBooking.UseVisualStyleBackColor = true;
			this.buttonOpretAkutBooking.Click += new System.EventHandler(this.buttonAkutpatient_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tider";
			// 
			// AkutPatient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 454);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOpretAkutBooking);
			this.Controls.Add(this.comboBoxTidspunkt);
			this.Controls.Add(this.listViewPatient);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AkutPatient";
			this.Text = "AkutPatient";
			this.Load += new System.EventHandler(this.AkutPatient_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPatient;
        private System.Windows.Forms.ColumnHeader column_Navn;
        private System.Windows.Forms.ColumnHeader column_PatientID;
        private System.Windows.Forms.Button buttonOpretAkutBooking;
        public System.Windows.Forms.ComboBox comboBoxTidspunkt;
        private System.Windows.Forms.Label label1;
    }
}