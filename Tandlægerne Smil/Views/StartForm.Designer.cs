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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afslutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjælpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLiveView = new System.Windows.Forms.TabPage();
            this.buttonSletBookning = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTjekkeInd = new System.Windows.Forms.Button();
            this.listViewDagensProgram = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewVenteværelse = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.buttonOpretBookning = new System.Windows.Forms.Button();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.buttonOpretPatient = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonRedigereBookning = new System.Windows.Forms.Button();
            this.buttonAkutAnkomst = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLiveView.SuspendLayout();
            this.tabBook.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // opretTestPatient
            // 
            this.opretTestPatient.Location = new System.Drawing.Point(540, 384);
            this.opretTestPatient.Name = "opretTestPatient";
            this.opretTestPatient.Size = new System.Drawing.Size(96, 23);
            this.opretTestPatient.TabIndex = 0;
            this.opretTestPatient.Text = "opretTestPatient";
            this.opretTestPatient.UseVisualStyleBackColor = true;
            this.opretTestPatient.Click += new System.EventHandler(this.opretTestPatient_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filerToolStripMenuItem,
            this.hjælpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filerToolStripMenuItem
            // 
            this.filerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afslutToolStripMenuItem});
            this.filerToolStripMenuItem.Name = "filerToolStripMenuItem";
            this.filerToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.filerToolStripMenuItem.Text = "Filer";
            // 
            // afslutToolStripMenuItem
            // 
            this.afslutToolStripMenuItem.Name = "afslutToolStripMenuItem";
            this.afslutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.afslutToolStripMenuItem.Text = "Afslut";
            // 
            // hjælpToolStripMenuItem
            // 
            this.hjælpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
            this.hjælpToolStripMenuItem.Name = "hjælpToolStripMenuItem";
            this.hjælpToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hjælpToolStripMenuItem.Text = "Hjælp";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.omToolStripMenuItem.Text = "Om";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLiveView);
            this.tabControl1.Controls.Add(this.tabBook);
            this.tabControl1.Controls.Add(this.tabPatient);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 436);
            this.tabControl1.TabIndex = 2;
            // 
            // tabLiveView
            // 
            this.tabLiveView.Controls.Add(this.buttonAkutAnkomst);
            this.tabLiveView.Controls.Add(this.buttonRedigereBookning);
            this.tabLiveView.Controls.Add(this.button4);
            this.tabLiveView.Controls.Add(this.buttonSletBookning);
            this.tabLiveView.Controls.Add(this.button2);
            this.tabLiveView.Controls.Add(this.buttonTjekkeInd);
            this.tabLiveView.Controls.Add(this.listViewDagensProgram);
            this.tabLiveView.Controls.Add(this.label2);
            this.tabLiveView.Controls.Add(this.listViewVenteværelse);
            this.tabLiveView.Controls.Add(this.label1);
            this.tabLiveView.Location = new System.Drawing.Point(4, 22);
            this.tabLiveView.Name = "tabLiveView";
            this.tabLiveView.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiveView.Size = new System.Drawing.Size(639, 410);
            this.tabLiveView.TabIndex = 0;
            this.tabLiveView.Text = "Live-View";
            this.tabLiveView.UseVisualStyleBackColor = true;
            // 
            // buttonSletBookning
            // 
            this.buttonSletBookning.Location = new System.Drawing.Point(235, 376);
            this.buttonSletBookning.Name = "buttonSletBookning";
            this.buttonSletBookning.Size = new System.Drawing.Size(171, 23);
            this.buttonSletBookning.TabIndex = 7;
            this.buttonSletBookning.Text = "Slet Bookning";
            this.buttonSletBookning.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Afslut Behandling";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTjekkeInd
            // 
            this.buttonTjekkeInd.Location = new System.Drawing.Point(236, 19);
            this.buttonTjekkeInd.Name = "buttonTjekkeInd";
            this.buttonTjekkeInd.Size = new System.Drawing.Size(171, 23);
            this.buttonTjekkeInd.TabIndex = 5;
            this.buttonTjekkeInd.Text = "Tjekke Patient Ind";
            this.buttonTjekkeInd.UseVisualStyleBackColor = true;
            this.buttonTjekkeInd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewDagensProgram
            // 
            this.listViewDagensProgram.Location = new System.Drawing.Point(413, 19);
            this.listViewDagensProgram.Name = "listViewDagensProgram";
            this.listViewDagensProgram.Size = new System.Drawing.Size(220, 380);
            this.listViewDagensProgram.TabIndex = 4;
            this.listViewDagensProgram.UseCompatibleStateImageBehavior = false;
            this.listViewDagensProgram.SelectedIndexChanged += new System.EventHandler(this.listViewDagensProgram_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dagens Bookninger";
            // 
            // listViewVenteværelse
            // 
            this.listViewVenteværelse.Location = new System.Drawing.Point(6, 19);
            this.listViewVenteværelse.Name = "listViewVenteværelse";
            this.listViewVenteværelse.Size = new System.Drawing.Size(224, 380);
            this.listViewVenteværelse.TabIndex = 2;
            this.listViewVenteværelse.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Venteværelse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabBook
            // 
            this.tabBook.Controls.Add(this.buttonOpretBookning);
            this.tabBook.Location = new System.Drawing.Point(4, 22);
            this.tabBook.Name = "tabBook";
            this.tabBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabBook.Size = new System.Drawing.Size(639, 410);
            this.tabBook.TabIndex = 1;
            this.tabBook.Text = "Book";
            this.tabBook.UseVisualStyleBackColor = true;
            // 
            // buttonOpretBookning
            // 
            this.buttonOpretBookning.Location = new System.Drawing.Point(6, 6);
            this.buttonOpretBookning.Name = "buttonOpretBookning";
            this.buttonOpretBookning.Size = new System.Drawing.Size(89, 23);
            this.buttonOpretBookning.TabIndex = 0;
            this.buttonOpretBookning.Text = "Opret Bookning";
            this.buttonOpretBookning.UseVisualStyleBackColor = true;
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.buttonOpretPatient);
            this.tabPatient.Controls.Add(this.opretTestPatient);
            this.tabPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Size = new System.Drawing.Size(639, 410);
            this.tabPatient.TabIndex = 2;
            this.tabPatient.Text = "Patient";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // buttonOpretPatient
            // 
            this.buttonOpretPatient.Location = new System.Drawing.Point(12, 14);
            this.buttonOpretPatient.Name = "buttonOpretPatient";
            this.buttonOpretPatient.Size = new System.Drawing.Size(96, 23);
            this.buttonOpretPatient.TabIndex = 1;
            this.buttonOpretPatient.Text = "Opret Patient";
            this.buttonOpretPatient.UseVisualStyleBackColor = true;
            this.buttonOpretPatient.Click += new System.EventHandler(this.buttonOpretPatient_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(235, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Markere som Under Behandling";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonRedigereBookning
            // 
            this.buttonRedigereBookning.Location = new System.Drawing.Point(236, 347);
            this.buttonRedigereBookning.Name = "buttonRedigereBookning";
            this.buttonRedigereBookning.Size = new System.Drawing.Size(171, 23);
            this.buttonRedigereBookning.TabIndex = 9;
            this.buttonRedigereBookning.Text = "Redigere Bookning";
            this.buttonRedigereBookning.UseVisualStyleBackColor = true;
            // 
            // buttonAkutAnkomst
            // 
            this.buttonAkutAnkomst.Location = new System.Drawing.Point(236, 318);
            this.buttonAkutAnkomst.Name = "buttonAkutAnkomst";
            this.buttonAkutAnkomst.Size = new System.Drawing.Size(171, 23);
            this.buttonAkutAnkomst.TabIndex = 10;
            this.buttonAkutAnkomst.Text = "AKUT Ankomst";
            this.buttonAkutAnkomst.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 490);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "Tandlægerne Smil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabLiveView.ResumeLayout(false);
            this.tabLiveView.PerformLayout();
            this.tabBook.ResumeLayout(false);
            this.tabPatient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opretTestPatient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afslutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjælpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLiveView;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.ListView listViewDagensProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewVenteværelse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.Button buttonSletBookning;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTjekkeInd;
        private System.Windows.Forms.Button buttonOpretBookning;
        private System.Windows.Forms.Button buttonOpretPatient;
        private System.Windows.Forms.Button buttonRedigereBookning;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonAkutAnkomst;
    }
}