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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemVisKonsolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afslutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjælpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabFaktura = new System.Windows.Forms.TabPage();
            this.button_VisDetaljer = new System.Windows.Forms.Button();
            this.listView_FakturaDetaljer = new System.Windows.Forms.ListView();
            this.column_BehanID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_FakID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Pris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.buttonRedigerePatient = new System.Windows.Forms.Button();
            this.buttonOpretBooking = new System.Windows.Forms.Button();
            this.buttonOpretPatient = new System.Windows.Forms.Button();
            this.listViewPatienter = new System.Windows.Forms.ListView();
            this.columnFornavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEfternavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLiveView = new System.Windows.Forms.TabPage();
            this.buttonSletbooking = new System.Windows.Forms.Button();
            this.buttonUdskrivDagensBookinger = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAkutAnkomst = new System.Windows.Forms.Button();
            this.buttonRedigereBookning = new System.Windows.Forms.Button();
            this.buttonUnderBehandling = new System.Windows.Forms.Button();
            this.buttonAfslutBehandling = new System.Windows.Forms.Button();
            this.buttonTjekkeInd = new System.Windows.Forms.Button();
            this.listViewDagensProgram = new System.Windows.Forms.ListView();
            this.columnHeaderTid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAnsat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalAnslåetTid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLokale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBehandling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listViewVenteværelse = new System.Windows.Forms.ListView();
            this.columnBookingTid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnsat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnslåetTidTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLokale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBehandling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBookingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabFaktura.SuspendLayout();
            this.tabPatient.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // filerToolStripMenuItem
            // 
            this.filerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gemVisKonsolToolStripMenuItem,
            this.afslutToolStripMenuItem});
            this.filerToolStripMenuItem.Name = "filerToolStripMenuItem";
            this.filerToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.filerToolStripMenuItem.Text = "Filer";
            // 
            // gemVisKonsolToolStripMenuItem
            // 
            this.gemVisKonsolToolStripMenuItem.Checked = true;
            this.gemVisKonsolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gemVisKonsolToolStripMenuItem.Name = "gemVisKonsolToolStripMenuItem";
            this.gemVisKonsolToolStripMenuItem.ShowShortcutKeys = false;
            this.gemVisKonsolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gemVisKonsolToolStripMenuItem.Text = "Vis Konsol";
            this.gemVisKonsolToolStripMenuItem.Click += new System.EventHandler(this.VisKonsolToolStripMenuItem_Click);
            // 
            // afslutToolStripMenuItem
            // 
            this.afslutToolStripMenuItem.Name = "afslutToolStripMenuItem";
            this.afslutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afslutToolStripMenuItem.Text = "Afslut";
            this.afslutToolStripMenuItem.Click += new System.EventHandler(this.AfslutToolStripMenuItem_Click);
            // 
            // hjælpToolStripMenuItem
            // 
            this.hjælpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
            this.hjælpToolStripMenuItem.Name = "hjælpToolStripMenuItem";
            this.hjælpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjælpToolStripMenuItem.Text = "Hjælp";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.tabFaktura.Size = new System.Drawing.Size(771, 431);
            this.tabFaktura.TabIndex = 3;
            this.tabFaktura.Text = "Faktura";
            this.tabFaktura.UseVisualStyleBackColor = true;
            this.tabFaktura.Click += new System.EventHandler(this.tabFaktura_Click);
            // 
            // button_VisDetaljer
            // 
            this.button_VisDetaljer.Location = new System.Drawing.Point(668, 224);
            this.button_VisDetaljer.Name = "button_VisDetaljer";
            this.button_VisDetaljer.Size = new System.Drawing.Size(90, 23);
            this.button_VisDetaljer.TabIndex = 8;
            this.button_VisDetaljer.Text = "Vis detaljer";
            this.button_VisDetaljer.UseVisualStyleBackColor = true;
            this.button_VisDetaljer.Click += new System.EventHandler(this.button_VisDetaljer_Click);
            // 
            // listView_FakturaDetaljer
            // 
            this.listView_FakturaDetaljer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_BehanID,
            this.column_FakID,
            this.column_Navn,
            this.column_Pris});
            this.listView_FakturaDetaljer.Location = new System.Drawing.Point(11, 224);
            this.listView_FakturaDetaljer.Name = "listView_FakturaDetaljer";
            this.listView_FakturaDetaljer.Size = new System.Drawing.Size(652, 191);
            this.listView_FakturaDetaljer.TabIndex = 7;
            this.listView_FakturaDetaljer.UseCompatibleStateImageBehavior = false;
            this.listView_FakturaDetaljer.View = System.Windows.Forms.View.Details;
            // 
            // column_BehanID
            // 
            this.column_BehanID.Text = "ID";
            this.column_BehanID.Width = 68;
            // 
            // column_FakID
            // 
            this.column_FakID.Text = "Faktura ID";
            this.column_FakID.Width = 88;
            // 
            // column_Navn
            // 
            this.column_Navn.Text = "Behandlingsnavn";
            this.column_Navn.Width = 344;
            // 
            // column_Pris
            // 
            this.column_Pris.Text = "Pris";
            this.column_Pris.Width = 105;
            // 
            // button_VisAlleFolk
            // 
            this.button_VisAlleFolk.Location = new System.Drawing.Point(209, 3);
            this.button_VisAlleFolk.Name = "button_VisAlleFolk";
            this.button_VisAlleFolk.Size = new System.Drawing.Size(92, 23);
            this.button_VisAlleFolk.TabIndex = 6;
            this.button_VisAlleFolk.Text = "Patient register";
            this.button_VisAlleFolk.UseVisualStyleBackColor = true;
            this.button_VisAlleFolk.Click += new System.EventHandler(this.button_VisAlleFolk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient ID";
            // 
            // textBox_PatientID
            // 
            this.textBox_PatientID.Location = new System.Drawing.Point(68, 6);
            this.textBox_PatientID.Name = "textBox_PatientID";
            this.textBox_PatientID.Size = new System.Drawing.Size(56, 20);
            this.textBox_PatientID.TabIndex = 3;
            this.textBox_PatientID.TextChanged += new System.EventHandler(this.textBox_PatientID_TextChanged);
            // 
            // udskrivFaktura
            // 
            this.udskrivFaktura.Location = new System.Drawing.Point(668, 254);
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
            this.listView_Faktura.Location = new System.Drawing.Point(11, 30);
            this.listView_Faktura.Name = "listView_Faktura";
            this.listView_Faktura.Size = new System.Drawing.Size(748, 185);
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
            this.FakturaingsDato_ListView.Width = 125;
            // 
            // Button_Søg
            // 
            this.Button_Søg.Location = new System.Drawing.Point(128, 3);
            this.Button_Søg.Name = "Button_Søg";
            this.Button_Søg.Size = new System.Drawing.Size(75, 23);
            this.Button_Søg.TabIndex = 1;
            this.Button_Søg.Text = "Søg";
            this.Button_Søg.UseVisualStyleBackColor = true;
            this.Button_Søg.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.buttonRedigerePatient);
            this.tabPatient.Controls.Add(this.buttonOpretBooking);
            this.tabPatient.Controls.Add(this.buttonOpretPatient);
            this.tabPatient.Controls.Add(this.listViewPatienter);
            this.tabPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Size = new System.Drawing.Size(771, 431);
            this.tabPatient.TabIndex = 2;
            this.tabPatient.Text = "Patient";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // buttonRedigerePatient
            // 
            this.buttonRedigerePatient.Enabled = false;
            this.buttonRedigerePatient.Location = new System.Drawing.Point(672, 35);
            this.buttonRedigerePatient.Name = "buttonRedigerePatient";
            this.buttonRedigerePatient.Size = new System.Drawing.Size(96, 23);
            this.buttonRedigerePatient.TabIndex = 2;
            this.buttonRedigerePatient.Text = "Redigere patient";
            this.buttonRedigerePatient.UseVisualStyleBackColor = true;
            this.buttonRedigerePatient.Click += new System.EventHandler(this.buttonRedigerePatient_Click);
            // 
            // buttonOpretBooking
            // 
            this.buttonOpretBooking.Enabled = false;
            this.buttonOpretBooking.Location = new System.Drawing.Point(672, 64);
            this.buttonOpretBooking.Name = "buttonOpretBooking";
            this.buttonOpretBooking.Size = new System.Drawing.Size(96, 23);
            this.buttonOpretBooking.TabIndex = 15;
            this.buttonOpretBooking.Text = "Opret booking";
            this.buttonOpretBooking.UseVisualStyleBackColor = true;
            this.buttonOpretBooking.Click += new System.EventHandler(this.buttonOpretBooking_Click);
            // 
            // buttonOpretPatient
            // 
            this.buttonOpretPatient.Location = new System.Drawing.Point(672, 6);
            this.buttonOpretPatient.Name = "buttonOpretPatient";
            this.buttonOpretPatient.Size = new System.Drawing.Size(96, 23);
            this.buttonOpretPatient.TabIndex = 1;
            this.buttonOpretPatient.Text = "Opret ny patient";
            this.buttonOpretPatient.UseVisualStyleBackColor = true;
            this.buttonOpretPatient.Click += new System.EventHandler(this.buttonOpretPatient_Click);
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
            this.listViewPatienter.Size = new System.Drawing.Size(661, 425);
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
            // tabLiveView
            // 
            this.tabLiveView.Controls.Add(this.buttonSletbooking);
            this.tabLiveView.Controls.Add(this.buttonUdskrivDagensBookinger);
            this.tabLiveView.Controls.Add(this.dateTimePicker);
            this.tabLiveView.Controls.Add(this.buttonAkutAnkomst);
            this.tabLiveView.Controls.Add(this.buttonRedigereBookning);
            this.tabLiveView.Controls.Add(this.buttonUnderBehandling);
            this.tabLiveView.Controls.Add(this.buttonAfslutBehandling);
            this.tabLiveView.Controls.Add(this.buttonTjekkeInd);
            this.tabLiveView.Controls.Add(this.listViewDagensProgram);
            this.tabLiveView.Controls.Add(this.label2);
            this.tabLiveView.Controls.Add(this.listViewVenteværelse);
            this.tabLiveView.Controls.Add(this.label1);
            this.tabLiveView.Location = new System.Drawing.Point(4, 22);
            this.tabLiveView.Name = "tabLiveView";
            this.tabLiveView.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiveView.Size = new System.Drawing.Size(771, 431);
            this.tabLiveView.TabIndex = 0;
            this.tabLiveView.Text = "Live-View";
            this.tabLiveView.UseVisualStyleBackColor = true;
            this.tabLiveView.Click += new System.EventHandler(this.tabLiveView_Click);
            // 
            // buttonSletbooking
            // 
            this.buttonSletbooking.Enabled = false;
            this.buttonSletbooking.Location = new System.Drawing.Point(652, 143);
            this.buttonSletbooking.Name = "buttonSletbooking";
            this.buttonSletbooking.Size = new System.Drawing.Size(115, 29);
            this.buttonSletbooking.TabIndex = 14;
            this.buttonSletbooking.Text = "Slet booking";
            this.buttonSletbooking.UseVisualStyleBackColor = true;
            this.buttonSletbooking.Click += new System.EventHandler(this.buttonSletbooking_Click);
            // 
            // buttonUdskrivDagensBookinger
            // 
            this.buttonUdskrivDagensBookinger.Location = new System.Drawing.Point(652, 103);
            this.buttonUdskrivDagensBookinger.Name = "buttonUdskrivDagensBookinger";
            this.buttonUdskrivDagensBookinger.Size = new System.Drawing.Size(115, 34);
            this.buttonUdskrivDagensBookinger.TabIndex = 13;
            this.buttonUdskrivDagensBookinger.Text = "Udskriv dagens bookninger";
            this.buttonUdskrivDagensBookinger.UseVisualStyleBackColor = true;
            this.buttonUdskrivDagensBookinger.Click += new System.EventHandler(this.buttonUdskrivDagensBookninger_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // buttonAkutAnkomst
            // 
            this.buttonAkutAnkomst.Location = new System.Drawing.Point(652, 310);
            this.buttonAkutAnkomst.Name = "buttonAkutAnkomst";
            this.buttonAkutAnkomst.Size = new System.Drawing.Size(115, 23);
            this.buttonAkutAnkomst.TabIndex = 10;
            this.buttonAkutAnkomst.Text = "AKUT Patient";
            this.buttonAkutAnkomst.UseVisualStyleBackColor = true;
            this.buttonAkutAnkomst.Click += new System.EventHandler(this.buttonAkutAnkomst_Click);
            // 
            // buttonRedigereBookning
            // 
            this.buttonRedigereBookning.Enabled = false;
            this.buttonRedigereBookning.Location = new System.Drawing.Point(652, 74);
            this.buttonRedigereBookning.Name = "buttonRedigereBookning";
            this.buttonRedigereBookning.Size = new System.Drawing.Size(115, 23);
            this.buttonRedigereBookning.TabIndex = 9;
            this.buttonRedigereBookning.Text = "Åben booking";
            this.buttonRedigereBookning.UseVisualStyleBackColor = true;
            this.buttonRedigereBookning.Click += new System.EventHandler(this.buttonRedigereBookning_Click);
            // 
            // buttonUnderBehandling
            // 
            this.buttonUnderBehandling.Enabled = false;
            this.buttonUnderBehandling.Location = new System.Drawing.Point(652, 240);
            this.buttonUnderBehandling.Name = "buttonUnderBehandling";
            this.buttonUnderBehandling.Size = new System.Drawing.Size(115, 35);
            this.buttonUnderBehandling.TabIndex = 8;
            this.buttonUnderBehandling.Text = "Markér som under behandling";
            this.buttonUnderBehandling.UseVisualStyleBackColor = true;
            this.buttonUnderBehandling.Click += new System.EventHandler(this.buttonUnderBehandling_Click);
            // 
            // buttonAfslutBehandling
            // 
            this.buttonAfslutBehandling.Enabled = false;
            this.buttonAfslutBehandling.Location = new System.Drawing.Point(652, 281);
            this.buttonAfslutBehandling.Name = "buttonAfslutBehandling";
            this.buttonAfslutBehandling.Size = new System.Drawing.Size(115, 23);
            this.buttonAfslutBehandling.TabIndex = 6;
            this.buttonAfslutBehandling.Text = "Afslut behandling";
            this.buttonAfslutBehandling.UseVisualStyleBackColor = true;
            this.buttonAfslutBehandling.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTjekkeInd
            // 
            this.buttonTjekkeInd.Enabled = false;
            this.buttonTjekkeInd.Location = new System.Drawing.Point(652, 45);
            this.buttonTjekkeInd.Name = "buttonTjekkeInd";
            this.buttonTjekkeInd.Size = new System.Drawing.Size(115, 23);
            this.buttonTjekkeInd.TabIndex = 5;
            this.buttonTjekkeInd.Text = "Tjekke patient ind";
            this.buttonTjekkeInd.UseVisualStyleBackColor = true;
            this.buttonTjekkeInd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewDagensProgram
            // 
            this.listViewDagensProgram.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTid,
            this.columnHeaderAnsat,
            this.columnTotalAnslåetTid,
            this.columnHeaderLokale,
            this.columnHeaderPatient,
            this.columnHeaderBehandling,
            this.columnHeaderBookingID});
            this.listViewDagensProgram.FullRowSelect = true;
            this.listViewDagensProgram.Location = new System.Drawing.Point(9, 45);
            this.listViewDagensProgram.Name = "listViewDagensProgram";
            this.listViewDagensProgram.Size = new System.Drawing.Size(639, 176);
            this.listViewDagensProgram.TabIndex = 4;
            this.listViewDagensProgram.UseCompatibleStateImageBehavior = false;
            this.listViewDagensProgram.View = System.Windows.Forms.View.Details;
            this.listViewDagensProgram.SelectedIndexChanged += new System.EventHandler(this.listViewDagensProgram_SelectedIndexChanged);
            // 
            // columnHeaderTid
            // 
            this.columnHeaderTid.Text = "Tidspunkt";
            this.columnHeaderTid.Width = 59;
            // 
            // columnHeaderAnsat
            // 
            this.columnHeaderAnsat.Text = "Ansat";
            this.columnHeaderAnsat.Width = 72;
            // 
            // columnTotalAnslåetTid
            // 
            this.columnTotalAnslåetTid.Text = "Anslået Tid";
            this.columnTotalAnslåetTid.Width = 66;
            // 
            // columnHeaderLokale
            // 
            this.columnHeaderLokale.Text = "Lokale";
            this.columnHeaderLokale.Width = 77;
            // 
            // columnHeaderPatient
            // 
            this.columnHeaderPatient.Text = "Patient";
            this.columnHeaderPatient.Width = 107;
            // 
            // columnHeaderBehandling
            // 
            this.columnHeaderBehandling.Text = "Behandling(er)";
            this.columnHeaderBehandling.Width = 185;
            // 
            // columnHeaderBookingID
            // 
            this.columnHeaderBookingID.Text = "BookingID";
            this.columnHeaderBookingID.Width = 66;
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
            this.columnAnsat,
            this.columnAnslåetTidTotal,
            this.columnLokale,
            this.columnPatient,
            this.columnBehandling,
            this.columnBookingID});
            this.listViewVenteværelse.FullRowSelect = true;
            this.listViewVenteværelse.Location = new System.Drawing.Point(9, 240);
            this.listViewVenteværelse.Name = "listViewVenteværelse";
            this.listViewVenteværelse.Size = new System.Drawing.Size(636, 185);
            this.listViewVenteværelse.TabIndex = 2;
            this.listViewVenteværelse.UseCompatibleStateImageBehavior = false;
            this.listViewVenteværelse.View = System.Windows.Forms.View.Details;
            this.listViewVenteværelse.SelectedIndexChanged += new System.EventHandler(this.listViewVenteværelse_SelectedIndexChanged);
            // 
            // columnBookingTid
            // 
            this.columnBookingTid.Text = "Tidspunkt";
            this.columnBookingTid.Width = 61;
            // 
            // columnAnsat
            // 
            this.columnAnsat.Text = "Ansat";
            this.columnAnsat.Width = 74;
            // 
            // columnAnslåetTidTotal
            // 
            this.columnAnslåetTidTotal.Text = "Anslået Tid";
            this.columnAnslåetTidTotal.Width = 71;
            // 
            // columnLokale
            // 
            this.columnLokale.Text = "Lokale";
            this.columnLokale.Width = 75;
            // 
            // columnPatient
            // 
            this.columnPatient.Text = "Patient";
            this.columnPatient.Width = 102;
            // 
            // columnBehandling
            // 
            this.columnBehandling.Text = "Behandling(er)";
            this.columnBehandling.Width = 182;
            // 
            // columnBookingID
            // 
            this.columnBookingID.Text = "BookingID";
            this.columnBookingID.Width = 65;
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
            this.tabControl1.Size = new System.Drawing.Size(779, 457);
            this.tabControl1.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button buttonOpretPatient;
        private System.Windows.Forms.Button buttonRedigerePatient;
        private System.Windows.Forms.TabPage tabLiveView;
        private System.Windows.Forms.Button buttonUdskrivDagensBookinger;
        private System.Windows.Forms.Button buttonAkutAnkomst;
        private System.Windows.Forms.Button buttonRedigereBookning;
        private System.Windows.Forms.Button buttonUnderBehandling;
        private System.Windows.Forms.Button buttonAfslutBehandling;
        private System.Windows.Forms.Button buttonTjekkeInd;
        private System.Windows.Forms.ListView listViewDagensProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewVenteværelse;
        private System.Windows.Forms.ColumnHeader columnBookingTid;
        private System.Windows.Forms.ColumnHeader columnAnsat;
        private System.Windows.Forms.ColumnHeader columnBehandling;
        private System.Windows.Forms.ColumnHeader columnPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.ColumnHeader columnHeaderAnsat;
        private System.Windows.Forms.ColumnHeader columnHeaderPatient;
        private System.Windows.Forms.ColumnHeader columnHeaderBehandling;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader columnTotalAnslåetTid;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonSletbooking;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingID;
        private System.Windows.Forms.ColumnHeader columnAnslåetTidTotal;
        private System.Windows.Forms.ColumnHeader columnLokale;
        private System.Windows.Forms.ColumnHeader columnBookingID;
        private System.Windows.Forms.Timer timer1;
    }
}