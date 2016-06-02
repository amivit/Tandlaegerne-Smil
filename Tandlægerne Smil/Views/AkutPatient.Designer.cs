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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Patienter", System.Windows.Forms.HorizontalAlignment.Left);
            this.listViewPatient = new System.Windows.Forms.ListView();
            this.column_Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxTidspunkt = new System.Windows.Forms.ComboBox();
            this.buttonAkutpatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPatient
            // 
            this.listViewPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Navn,
            this.column_PatientID});
            this.listViewPatient.FullRowSelect = true;
            listViewGroup2.Header = "Patienter";
            listViewGroup2.Name = "listViewGroup1";
            listViewGroup2.Tag = "";
            this.listViewPatient.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listViewPatient.HideSelection = false;
            this.listViewPatient.Location = new System.Drawing.Point(12, 12);
            this.listViewPatient.MultiSelect = false;
            this.listViewPatient.Name = "listViewPatient";
            this.listViewPatient.Size = new System.Drawing.Size(242, 396);
            this.listViewPatient.TabIndex = 1;
            this.listViewPatient.UseCompatibleStateImageBehavior = false;
            this.listViewPatient.View = System.Windows.Forms.View.Details;
            // 
            // column_Navn
            // 
            this.column_Navn.Text = "Navn";
            this.column_Navn.Width = 140;
            // 
            // column_PatientID
            // 
            this.column_PatientID.Text = "Patient ID";
            this.column_PatientID.Width = 95;
            // 
            // comboBoxTidspunkt
            // 
            this.comboBoxTidspunkt.FormattingEnabled = true;
            this.comboBoxTidspunkt.Location = new System.Drawing.Point(260, 12);
            this.comboBoxTidspunkt.Name = "comboBoxTidspunkt";
            this.comboBoxTidspunkt.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTidspunkt.TabIndex = 2;
            // 
            // buttonAkutpatient
            // 
            this.buttonAkutpatient.Location = new System.Drawing.Point(275, 384);
            this.buttonAkutpatient.Name = "buttonAkutpatient";
            this.buttonAkutpatient.Size = new System.Drawing.Size(106, 23);
            this.buttonAkutpatient.TabIndex = 3;
            this.buttonAkutpatient.Text = "Akut Booking";
            this.buttonAkutpatient.UseVisualStyleBackColor = true;
            // 
            // AkutPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 429);
            this.Controls.Add(this.buttonAkutpatient);
            this.Controls.Add(this.comboBoxTidspunkt);
            this.Controls.Add(this.listViewPatient);
            this.Name = "AkutPatient";
            this.Text = "AkutPatient";
            this.Load += new System.EventHandler(this.AkutPatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPatient;
        private System.Windows.Forms.ColumnHeader column_Navn;
        private System.Windows.Forms.ColumnHeader column_PatientID;
        private System.Windows.Forms.ComboBox comboBoxTidspunkt;
        private System.Windows.Forms.Button buttonAkutpatient;
    }
}