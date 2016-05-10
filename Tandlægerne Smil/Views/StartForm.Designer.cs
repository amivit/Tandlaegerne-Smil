namespace Tandlægerne_Smil.Views
{
    partial class StartForm
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
            this.opretTestPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opretTestPatient
            // 
            this.opretTestPatient.Location = new System.Drawing.Point(179, 226);
            this.opretTestPatient.Name = "opretTestPatient";
            this.opretTestPatient.Size = new System.Drawing.Size(93, 23);
            this.opretTestPatient.TabIndex = 0;
            this.opretTestPatient.Text = "opretTestPatient";
            this.opretTestPatient.UseVisualStyleBackColor = true;
            this.opretTestPatient.Click += new System.EventHandler(this.opretTestPatient_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.opretTestPatient);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opretTestPatient;
    }
}