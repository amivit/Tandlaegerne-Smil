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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Tandlægerne Smil\'s Patienter", System.Windows.Forms.HorizontalAlignment.Left);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemVisKonsolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demotilstandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afslutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjælpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabFaktura = new System.Windows.Forms.TabPage();
            this.button_VisAlleFolk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PatientID = new System.Windows.Forms.TextBox();
            this.udskrivFaktura = new System.Windows.Forms.Button();
            this.listView_Faktura = new System.Windows.Forms.ListView();
            this.FakturaID_ListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Navn_ListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PertientID_ListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FakturaingsDato_ListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_Søg = new System.Windows.Forms.Button();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.listViewPatienter = new System.Windows.Forms.ListView();
            this.columnFornavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEfternavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOpretPatient = new System.Windows.Forms.Button();
            this.buttonRedigerePatient = new System.Windows.Forms.Button();
            this.buttonOpretBooking = new System.Windows.Forms.Button();
            this.opretTestPatient = new System.Windows.Forms.Button();
            this.tabLiveView = new System.Windows.Forms.TabPage();
            this.buttonUdskrivDagensBookinger = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAkutAnkomst = new System.Windows.Forms.Button();
            this.buttonRedigereBookning = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTjekkeInd = new System.Windows.Forms.Button();
            this.listViewDagensProgram = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewVenteværelse = new System.Windows.Forms.ListView();
            this.columnBookingTid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBehandling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLæge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView_FakturaDetaljer = new System.Windows.Forms.ListView();
            this.button_VisDetaljer = new System.Windows.Forms.Button();
            this.column_BehanID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Pris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_FakID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLokale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLæge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBehandling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabFaktura.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabLiveView.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filerToolStripMenuItem,
            this.hjælpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // filerToolStripMenuItem
            // 
            this.filerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gemVisKonsolToolStripMenuItem,
            this.demotilstandToolStripMenuItem,
            this.afslutToolStripMenuItem});
            this.filerToolStripMenuItem.Name = "filerToolStripMenuItem";
            this.filerToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.filerToolStripMenuItem.Text = "Filer";
            // 
            // gemVisKonsolToolStripMenuItem
            // 
            this.gemVisKonsolToolStripMenuItem.Checked = true;
            this.gemVisKonsolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gemVisKonsolToolStripMenuItem.Name = "gemVisKonsolToolStripMenuItem";
            this.gemVisKonsolToolStripMenuItem.ShowShortcutKeys = false;
            this.gemVisKonsolToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.gemVisKonsolToolStripMenuItem.Text = "Vis Konsol";
            this.gemVisKonsolToolStripMenuItem.Click += new System.EventHandler(this.VisKonsolToolStripMenuItem_Click);
            // 
            // demotilstandToolStripMenuItem
            // 
            this.demotilstandToolStripMenuItem.Checked = true;
            this.demotilstandToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.demotilstandToolStripMenuItem.Name = "demotilstandToolStripMenuItem";
            this.demotilstandToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.demotilstandToolStripMenuItem.Text = "Demo-tilstand";
            // 
            // afslutToolStripMenuItem
            // 
            this.afslutToolStripMenuItem.Name = "afslutToolStripMenuItem";
            this.afslutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.afslutToolStripMenuItem.Text = "Afslut";
            this.afslutToolStripMenuItem.Click += new System.EventHandler(this.AfslutToolStripMenuItem_Click);
            // 
            // hjælpToolStripMenuItem
            // 
            this.hjælpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
            this.hjælpToolStripMenuItem.Name = "hjælpToolStripMenuItem";
            this.hjælpToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.hjælpToolStripMenuItem.Text = "Hjælp";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.omToolStripMenuItem.Text = "Om";
            this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // tabFaktura
            // 
            this.tabFaktura.Controls.Add(this.button_VisDetaljer);
            this.tabFaktura.Controls.Add(this.listView_FakturaDetaljer);
            this.tabFaktura.Controls.Add(this.button_VisAlleFolk);
            this.tabFaktura.Controls.Add(this.label3);
            this.tabFaktura.Controls.Add(this.textBox_PatientID);
            this.tabFaktura.Controls.Add(this.udskrivFaktura);
            this.tabFaktura.Controls.Add(this.listView_Faktura);
            this.tabFaktura.Controls.Add(this.Button_Søg);
            this.tabFaktura.Location = new System.Drawing.Point(4, 22);
            this.tabFaktura.Name = "tabFaktura";
            this.tabFaktura.Size = new System.Drawing.Size(639, 431);
            this.tabFaktura.TabIndex = 3;
            this.tabFaktura.Text = "Faktura";
            this.tabFaktura.UseVisualStyleBackColor = true;
            this.tabFaktura.Click += new System.EventHandler(this.tabFaktura_Click);
            // 
            // button_VisAlleFolk
            // 
            this.button_VisAlleFolk.Location = new System.Drawing.Point(321, 4);
            this.button_VisAlleFolk.Name = "button_VisAlleFolk";
            this.button_VisAlleFolk.Size = new System.Drawing.Size(75, 23);
            this.button_VisAlleFolk.TabIndex = 6;
            this.button_VisAlleFolk.Text = "Søg Patient";
            this.button_VisAlleFolk.UseVisualStyleBackColor = true;
            this.button_VisAlleFolk.Click += new System.EventHandler(this.button_VisAlleFolk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pertient ID";
            // 
            // textBox_PatientID
            // 
            this.textBox_PatientID.Location = new System.Drawing.Point(71, 6);
            this.textBox_PatientID.Name = "textBox_PatientID";
            this.textBox_PatientID.Size = new System.Drawing.Size(60, 20);
            this.textBox_PatientID.TabIndex = 3;
            this.textBox_PatientID.TextChanged += new System.EventHandler(this.textBox_PatientID_TextChanged);
            // 
            // udskrivFaktura
            // 
            this.udskrivFaktura.Location = new System.Drawing.Point(546, 405);
            this.udskrivFaktura.Name = "udskrivFaktura";
            this.udskrivFaktura.Size = new System.Drawing.Size(90, 23);
            this.udskrivFaktura.TabIndex = 0;
            this.udskrivFaktura.Text = "Udskriv Faktura";
            this.udskrivFaktura.UseVisualStyleBackColor = true;
            this.udskrivFaktura.Click += new System.EventHandler(this.udskrivFaktura_Click);
            // 
            // listView_Faktura
            // 
            this.listView_Faktura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FakturaID_ListView,
            this.Navn_ListView,
            this.PertientID_ListView,
            this.FakturaingsDato_ListView});
            this.listView_Faktura.FullRowSelect = true;
            this.listView_Faktura.Location = new System.Drawing.Point(11, 32);
            this.listView_Faktura.Name = "listView_Faktura";
            this.listView_Faktura.Size = new System.Drawing.Size(385, 185);
            this.listView_Faktura.TabIndex = 2;
            this.listView_Faktura.UseCompatibleStateImageBehavior = false;
            this.listView_Faktura.View = System.Windows.Forms.View.Details;
            this.listView_Faktura.SelectedIndexChanged += new System.EventHandler(this.listView_Faktura_SelectedIndexChanged);
            // 
            // FakturaID_ListView
            // 
            this.FakturaID_ListView.Text = "Faktura ID";
            this.FakturaID_ListView.Width = 84;
            // 
            // Navn_ListView
            // 
            this.Navn_ListView.Text = "Navn";
            this.Navn_ListView.Width = 87;
            // 
            // PertientID_ListView
            // 
            this.PertientID_ListView.Text = "Patient ID";
            this.PertientID_ListView.Width = 85;
            // 
            // FakturaingsDato_ListView
            // 
            this.FakturaingsDato_ListView.Text = "Fakturerings Dato";
            this.FakturaingsDato_ListView.Width = 101;
            // 
            // Button_Søg
            // 
            this.Button_Søg.Location = new System.Drawing.Point(137, 4);
            this.Button_Søg.Name = "Button_Søg";
            this.Button_Søg.Size = new System.Drawing.Size(75, 23);
            this.Button_Søg.TabIndex = 1;
            this.Button_Søg.Text = "Søg";
            this.Button_Søg.UseVisualStyleBackColor = true;
            this.Button_Søg.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.listViewPatienter);
            this.tabPatient.Controls.Add(this.flowLayoutPanel1);
            this.tabPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Size = new System.Drawing.Size(639, 431);
            this.tabPatient.TabIndex = 2;
            this.tabPatient.Text = "Patient";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // listViewPatienter
            // 
            this.listViewPatienter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFornavn,
            this.columnEfternavn,
            this.columnTelefon,
            this.columnPatientID});
            this.listViewPatienter.FullRowSelect = true;
            listViewGroup1.Header = "Tandlægerne Smil\'s Patienter";
            listViewGroup1.Name = "Tandlægerne Smil\'s Patienter";
            this.listViewPatienter.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewPatienter.HideSelection = false;
            this.listViewPatienter.Location = new System.Drawing.Point(6, 6);
            this.listViewPatienter.MultiSelect = false;
            this.listViewPatienter.Name = "listViewPatienter";
            this.listViewPatienter.Size = new System.Drawing.Size(522, 387);
            this.listViewPatienter.TabIndex = 3;
            this.listViewPatienter.UseCompatibleStateImageBehavior = false;
            this.listViewPatienter.View = System.Windows.Forms.View.Details;
            this.listViewPatienter.SelectedIndexChanged += new System.EventHandler(this.listViewPatienter_SelectedIndexChanged);
            // 
            // columnFornavn
            // 
            this.columnFornavn.Text = "Fornavn";
            this.columnFornavn.Width = 82;
            // 
            // columnEfternavn
            // 
            this.columnEfternavn.Text = "Efternavn";
            this.columnEfternavn.Width = 100;
            // 
            // columnTelefon
            // 
            this.columnTelefon.Text = "Telefon";
            this.columnTelefon.Width = 95;
            // 
            // columnPatientID
            // 
            this.columnPatientID.Text = "ID";
            this.columnPatientID.Width = 40;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonOpretPatient);
            this.flowLayoutPanel1.Controls.Add(this.buttonRedigerePatient);
            this.flowLayoutPanel1.Controls.Add(this.buttonOpretBooking);
            this.flowLayoutPanel1.Controls.Add(this.opretTestPatient);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(531, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 428);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonOpretPatient
            // 
            this.buttonOpretPatient.Location = new System.Drawing.Point(3, 3);
            this.buttonOpretPatient.Name = "buttonOpretPatient";
            this.buttonOpretPatient.Size = new System.Drawing.Size(96, 23);
            this.buttonOpretPatient.TabIndex = 1;
            this.buttonOpretPatient.Text = "Opret Ny Patient";
            this.buttonOpretPatient.UseVisualStyleBackColor = true;
            this.buttonOpretPatient.Click += new System.EventHandler(this.buttonOpretPatient_Click);
            // 
            // buttonRedigerePatient
            // 
            this.buttonRedigerePatient.Location = new System.Drawing.Point(3, 32);
            this.buttonRedigerePatient.Name = "buttonRedigerePatient";
            this.buttonRedigerePatient.Size = new System.Drawing.Size(96, 23);
            this.buttonRedigerePatient.TabIndex = 2;
            this.buttonRedigerePatient.Text = "Redigere Patient";
            this.buttonRedigerePatient.UseVisualStyleBackColor = true;
            this.buttonRedigerePatient.Click += new System.EventHandler(this.buttonRedigerePatient_Click);
            // 
            // buttonOpretBooking
            // 
            this.buttonOpretBooking.Location = new System.Drawing.Point(3, 61);
            this.buttonOpretBooking.Name = "buttonOpretBooking";
            this.buttonOpretBooking.Size = new System.Drawing.Size(96, 23);
            this.buttonOpretBooking.TabIndex = 15;
            this.buttonOpretBooking.Text = "Opret Booking";
            this.buttonOpretBooking.UseVisualStyleBackColor = true;
            // 
            // opretTestPatient
            // 
            this.opretTestPatient.Location = new System.Drawing.Point(3, 90);
            this.opretTestPatient.Name = "opretTestPatient";
            this.opretTestPatient.Size = new System.Drawing.Size(96, 23);
            this.opretTestPatient.TabIndex = 0;
            this.opretTestPatient.Text = "Refresh";
            this.opretTestPatient.UseVisualStyleBackColor = true;
            this.opretTestPatient.Click += new System.EventHandler(this.opretTestPatient_Click);
            // 
            // tabLiveView
            // 
            this.tabLiveView.Controls.Add(this.buttonUdskrivDagensBookinger);
            this.tabLiveView.Controls.Add(this.dateTimePicker);
            this.tabLiveView.Controls.Add(this.buttonAkutAnkomst);
            this.tabLiveView.Controls.Add(this.buttonRedigereBookning);
            this.tabLiveView.Controls.Add(this.button4);
            this.tabLiveView.Controls.Add(this.button2);
            this.tabLiveView.Controls.Add(this.buttonTjekkeInd);
            this.tabLiveView.Controls.Add(this.listViewDagensProgram);
            this.tabLiveView.Controls.Add(this.label2);
            this.tabLiveView.Controls.Add(this.listViewVenteværelse);
            this.tabLiveView.Controls.Add(this.label1);
            this.tabLiveView.Location = new System.Drawing.Point(4, 22);
            this.tabLiveView.Name = "tabLiveView";
            this.tabLiveView.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiveView.Size = new System.Drawing.Size(639, 431);
            this.tabLiveView.TabIndex = 0;
            this.tabLiveView.Text = "Live-View";
            this.tabLiveView.UseVisualStyleBackColor = true;
            this.tabLiveView.Click += new System.EventHandler(this.tabLiveView_Click);
            // 
            // buttonUdskrivDagensBookinger
            // 
            this.buttonUdskrivDagensBookinger.Location = new System.Drawing.Point(518, 106);
            this.buttonUdskrivDagensBookinger.Name = "buttonUdskrivDagensBookinger";
            this.buttonUdskrivDagensBookinger.Size = new System.Drawing.Size(115, 34);
            this.buttonUdskrivDagensBookinger.TabIndex = 13;
            this.buttonUdskrivDagensBookinger.Text = "Udskriv Dagens Bookinger";
            this.buttonUdskrivDagensBookinger.UseVisualStyleBackColor = true;
            this.buttonUdskrivDagensBookinger.Click += new System.EventHandler(this.buttonUdskrivDagensBookninger_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // buttonAkutAnkomst
            // 
            this.buttonAkutAnkomst.Location = new System.Drawing.Point(518, 402);
            this.buttonAkutAnkomst.Name = "buttonAkutAnkomst";
            this.buttonAkutAnkomst.Size = new System.Drawing.Size(115, 23);
            this.buttonAkutAnkomst.TabIndex = 10;
            this.buttonAkutAnkomst.Text = "AKUT Ankomst";
            this.buttonAkutAnkomst.UseVisualStyleBackColor = true;
            // 
            // buttonRedigereBookning
            // 
            this.buttonRedigereBookning.Location = new System.Drawing.Point(518, 77);
            this.buttonRedigereBookning.Name = "buttonRedigereBookning";
            this.buttonRedigereBookning.Size = new System.Drawing.Size(115, 23);
            this.buttonRedigereBookning.TabIndex = 9;
            this.buttonRedigereBookning.Text = "Åbne Booking";
            this.buttonRedigereBookning.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Markere som Under Behandling";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Afslut Behandling";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTjekkeInd
            // 
            this.buttonTjekkeInd.Location = new System.Drawing.Point(518, 19);
            this.buttonTjekkeInd.Name = "buttonTjekkeInd";
            this.buttonTjekkeInd.Size = new System.Drawing.Size(115, 23);
            this.buttonTjekkeInd.TabIndex = 5;
            this.buttonTjekkeInd.Text = "Tjekke Patient Ind";
            this.buttonTjekkeInd.UseVisualStyleBackColor = true;
            this.buttonTjekkeInd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewDagensProgram
            // 
            this.listViewDagensProgram.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTid,
            this.columnHeaderLokale,
            this.columnHeaderLæge,
            this.columnHeaderPatient,
            this.columnHeaderBehandling});
            this.listViewDagensProgram.Location = new System.Drawing.Point(6, 45);
            this.listViewDagensProgram.Name = "listViewDagensProgram";
            this.listViewDagensProgram.Size = new System.Drawing.Size(506, 176);
            this.listViewDagensProgram.TabIndex = 4;
            this.listViewDagensProgram.UseCompatibleStateImageBehavior = false;
            this.listViewDagensProgram.View = System.Windows.Forms.View.Details;
            this.listViewDagensProgram.SelectedIndexChanged += new System.EventHandler(this.listViewDagensProgram_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dagens Bookninger";
            // 
            // listViewVenteværelse
            // 
            this.listViewVenteværelse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBookingTid,
            this.columnBehandling,
            this.columnLæge,
            this.columnPatient});
            this.listViewVenteværelse.Location = new System.Drawing.Point(9, 240);
            this.listViewVenteværelse.Name = "listViewVenteværelse";
            this.listViewVenteværelse.Size = new System.Drawing.Size(503, 185);
            this.listViewVenteværelse.TabIndex = 2;
            this.listViewVenteværelse.UseCompatibleStateImageBehavior = false;
            this.listViewVenteværelse.View = System.Windows.Forms.View.Details;
            this.listViewVenteværelse.SelectedIndexChanged += new System.EventHandler(this.listViewVenteværelse_SelectedIndexChanged);
            // 
            // columnBookingTid
            // 
            this.columnBookingTid.Text = "Booking Tid";
            this.columnBookingTid.Width = 87;
            // 
            // columnBehandling
            // 
            this.columnBehandling.Text = "Behandling";
            this.columnBehandling.Width = 195;
            // 
            // columnLæge
            // 
            this.columnLæge.Text = "Ansat";
            this.columnLæge.Width = 102;
            // 
            // columnPatient
            // 
            this.columnPatient.Text = "Patient";
            this.columnPatient.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Venteværelse";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLiveView);
            this.tabControl1.Controls.Add(this.tabPatient);
            this.tabControl1.Controls.Add(this.tabFaktura);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 457);
            this.tabControl1.TabIndex = 2;
            // 
            // columnHeaderTid
            // 
            this.columnHeaderTid.Text = "Tidspunkt";
            // 
            // columnHeaderLokale
            // 
            this.columnHeaderLokale.Text = "Lokale";
            this.columnHeaderLokale.Width = 59;
            // 
            // columnHeaderLæge
            // 
            this.columnHeaderLæge.Text = "Læge";
            // 
            // columnHeaderPatient
            // 
            this.columnHeaderPatient.Text = "Patient";
            this.columnHeaderPatient.Width = 58;
            // 
            // columnHeaderBehandling
            // listView_FakturaDetaljer
            // 
            this.listView_FakturaDetaljer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_BehanID,
            this.column_FakID,
            this.column_Navn,
            this.column_Pris});
            this.listView_FakturaDetaljer.Location = new System.Drawing.Point(11, 224);
            this.listView_FakturaDetaljer.Name = "listView_FakturaDetaljer";
            this.listView_FakturaDetaljer.Size = new System.Drawing.Size(385, 191);
            this.listView_FakturaDetaljer.TabIndex = 7;
            this.listView_FakturaDetaljer.UseCompatibleStateImageBehavior = false;
            this.listView_FakturaDetaljer.View = System.Windows.Forms.View.Details;
            // 
            // button_VisDetaljer
            // 
            this.button_VisDetaljer.Location = new System.Drawing.Point(403, 224);
            this.button_VisDetaljer.Name = "button_VisDetaljer";
            this.button_VisDetaljer.Size = new System.Drawing.Size(75, 23);
            this.button_VisDetaljer.TabIndex = 8;
            this.button_VisDetaljer.Text = "Vis detaljer";
            this.button_VisDetaljer.UseVisualStyleBackColor = true;
            this.button_VisDetaljer.Click += new System.EventHandler(this.button_VisDetaljer_Click);
            // 
            // column_BehanID
            // 
            this.column_BehanID.Text = "ID";
            // 
            // column_Navn
            // 
            this.column_Navn.Text = "Behan Navn";
            this.column_Navn.Width = 119;
            // 
            // column_Pris
            // 
            this.column_Pris.Text = "Pris";
            // 
            // column_FakID
            // 
            this.column_FakID.Text = "Fak.ID";
            // 
            // buttonOpretBooking
            // 
            this.columnHeaderBehandling.Text = "Behandling";
            this.columnHeaderBehandling.Width = 242;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "Tandlægerne Smil";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabFaktura.ResumeLayout(false);
            this.tabFaktura.PerformLayout();
            this.tabPatient.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabLiveView.ResumeLayout(false);
            this.tabLiveView.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afslutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjælpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem gemVisKonsolToolStripMenuItem;
        private System.Windows.Forms.TabPage tabFaktura;
        private System.Windows.Forms.Button udskrivFaktura;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.ColumnHeader columnFornavn;
        private System.Windows.Forms.ColumnHeader columnEfternavn;
        private System.Windows.Forms.ColumnHeader columnTelefon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonOpretPatient;
        private System.Windows.Forms.Button buttonRedigerePatient;
        private System.Windows.Forms.Button opretTestPatient;
        private System.Windows.Forms.TabPage tabLiveView;
        private System.Windows.Forms.Button buttonUdskrivDagensBookinger;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonAkutAnkomst;
        private System.Windows.Forms.Button buttonRedigereBookning;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTjekkeInd;
        private System.Windows.Forms.ListView listViewDagensProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewVenteværelse;
        private System.Windows.Forms.ColumnHeader columnBookingTid;
        private System.Windows.Forms.ColumnHeader columnBehandling;
        private System.Windows.Forms.ColumnHeader columnLæge;
        private System.Windows.Forms.ColumnHeader columnPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem demotilstandToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnPatientID;
        public System.Windows.Forms.ListView listViewPatienter;
        private System.Windows.Forms.ListView listView_Faktura;
        private System.Windows.Forms.ColumnHeader FakturaID_ListView;
        private System.Windows.Forms.ColumnHeader PertientID_ListView;
        private System.Windows.Forms.ColumnHeader FakturaingsDato_ListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Navn_ListView;
        private System.Windows.Forms.Button button_VisAlleFolk;
        public System.Windows.Forms.TextBox textBox_PatientID;
        public System.Windows.Forms.Button Button_Søg;
        private System.Windows.Forms.Button button_VisDetaljer;
        private System.Windows.Forms.ColumnHeader column_BehanID;
        private System.Windows.Forms.ColumnHeader column_Navn;
        private System.Windows.Forms.ColumnHeader column_Pris;
        private System.Windows.Forms.ColumnHeader column_FakID;
        public System.Windows.Forms.ListView listView_FakturaDetaljer;
        private System.Windows.Forms.Button buttonOpretBooking;
        private System.Windows.Forms.ColumnHeader columnHeaderTid;
        private System.Windows.Forms.ColumnHeader columnHeaderLokale;
        private System.Windows.Forms.ColumnHeader columnHeaderLæge;
        private System.Windows.Forms.ColumnHeader columnHeaderPatient;
        private System.Windows.Forms.ColumnHeader columnHeaderBehandling;
    }
}