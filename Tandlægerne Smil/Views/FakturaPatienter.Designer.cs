namespace Tandlægerne_Smil.Views
{
    partial class FakturaPatienter
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
            this.listView = new System.Windows.Forms.ListView();
            this.column_Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Navn,
            this.column_PatientID});
            listViewGroup1.Header = "Patienter";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 34);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(244, 491);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // column_Navn
            // 
            this.column_Navn.Text = "Navn";
            this.column_Navn.Width = 180;
            // 
            // column_PatientID
            // 
            this.column_PatientID.Text = "PatientID";
            // 
            // FakturaPatienter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 557);
            this.Controls.Add(this.listView);
            this.Name = "FakturaPatienter";
            this.Text = "FakturaPatienter";
            this.Load += new System.EventHandler(this.FakturaPatienter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader column_Navn;
        private System.Windows.Forms.ColumnHeader column_PatientID;
    }
}