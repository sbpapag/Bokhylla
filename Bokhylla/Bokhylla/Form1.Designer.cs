namespace Bokhylla
{
    partial class bokhyllaForm
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
            this.grupBok = new System.Windows.Forms.GroupBox();
            this.bokRegis = new System.Windows.Forms.Button();
            this.bokRoman = new System.Windows.Forms.RadioButton();
            this.bokTyp = new System.Windows.Forms.Label();
            this.bokFakta = new System.Windows.Forms.RadioButton();
            this.bokTiteln = new System.Windows.Forms.TextBox();
            this.bokBarn = new System.Windows.Forms.RadioButton();
            this.bokTitel = new System.Windows.Forms.Label();
            this.bokSkrib = new System.Windows.Forms.Label();
            this.bokSkriben = new System.Windows.Forms.TextBox();
            this.bokÅr = new System.Windows.Forms.Label();
            this.bokÅret = new System.Windows.Forms.TextBox();
            this.bokSidor = new System.Windows.Forms.Label();
            this.bokSidorna = new System.Windows.Forms.TextBox();
            this.grupTids = new System.Windows.Forms.GroupBox();
            this.tidsRegi = new System.Windows.Forms.Button();
            this.tidsComics = new System.Windows.Forms.RadioButton();
            this.tidsTyp = new System.Windows.Forms.Label();
            this.tidsMusik = new System.Windows.Forms.RadioButton();
            this.tidsTiteln = new System.Windows.Forms.TextBox();
            this.tidsFritid = new System.Windows.Forms.RadioButton();
            this.tidsTitel = new System.Windows.Forms.Label();
            this.tidsNum = new System.Windows.Forms.Label();
            this.tidsNummeret = new System.Windows.Forms.TextBox();
            this.tidsÅr = new System.Windows.Forms.Label();
            this.tidsÅret = new System.Windows.Forms.TextBox();
            this.bokhyllaCons = new System.Windows.Forms.TextBox();
            this.grbBibliotekare = new System.Windows.Forms.GroupBox();
            this.btnTaBortBibliot = new System.Windows.Forms.Button();
            this.btnSearchBibliot = new System.Windows.Forms.Button();
            this.rdbYearBibliot = new System.Windows.Forms.RadioButton();
            this.rdbTitelBibliot = new System.Windows.Forms.RadioButton();
            this.txbSearchBibliot = new System.Windows.Forms.TextBox();
            this.lblSearchBibliot = new System.Windows.Forms.Label();
            this.grbConsole = new System.Windows.Forms.GroupBox();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.grpKlient = new System.Windows.Forms.GroupBox();
            this.btnKlientAlla = new System.Windows.Forms.Button();
            this.btnKlientMark = new System.Windows.Forms.Button();
            this.btnKlientLadda = new System.Windows.Forms.Button();
            this.btnKlientKoppla = new System.Windows.Forms.Button();
            this.grupBok.SuspendLayout();
            this.grupTids.SuspendLayout();
            this.grbBibliotekare.SuspendLayout();
            this.grbConsole.SuspendLayout();
            this.grpList.SuspendLayout();
            this.grpKlient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupBok
            // 
            this.grupBok.Controls.Add(this.bokRegis);
            this.grupBok.Controls.Add(this.bokRoman);
            this.grupBok.Controls.Add(this.bokTyp);
            this.grupBok.Controls.Add(this.bokFakta);
            this.grupBok.Controls.Add(this.bokTiteln);
            this.grupBok.Controls.Add(this.bokBarn);
            this.grupBok.Controls.Add(this.bokTitel);
            this.grupBok.Controls.Add(this.bokSkrib);
            this.grupBok.Controls.Add(this.bokSkriben);
            this.grupBok.Controls.Add(this.bokÅr);
            this.grupBok.Controls.Add(this.bokÅret);
            this.grupBok.Controls.Add(this.bokSidor);
            this.grupBok.Controls.Add(this.bokSidorna);
            this.grupBok.Enabled = false;
            this.grupBok.Location = new System.Drawing.Point(16, 15);
            this.grupBok.Margin = new System.Windows.Forms.Padding(4);
            this.grupBok.Name = "grupBok";
            this.grupBok.Padding = new System.Windows.Forms.Padding(4);
            this.grupBok.Size = new System.Drawing.Size(337, 228);
            this.grupBok.TabIndex = 0;
            this.grupBok.TabStop = false;
            this.grupBok.Text = "Bok";
            // 
            // bokRegis
            // 
            this.bokRegis.Location = new System.Drawing.Point(101, 191);
            this.bokRegis.Margin = new System.Windows.Forms.Padding(4);
            this.bokRegis.Name = "bokRegis";
            this.bokRegis.Size = new System.Drawing.Size(133, 28);
            this.bokRegis.TabIndex = 7;
            this.bokRegis.Text = "Registrera bok";
            this.bokRegis.UseVisualStyleBackColor = true;
            this.bokRegis.Click += new System.EventHandler(this.bokRegis_Click);
            // 
            // bokRoman
            // 
            this.bokRoman.AutoSize = true;
            this.bokRoman.Location = new System.Drawing.Point(239, 149);
            this.bokRoman.Margin = new System.Windows.Forms.Padding(4);
            this.bokRoman.Name = "bokRoman";
            this.bokRoman.Size = new System.Drawing.Size(69, 21);
            this.bokRoman.TabIndex = 3;
            this.bokRoman.TabStop = true;
            this.bokRoman.Text = "roman";
            this.bokRoman.UseVisualStyleBackColor = true;
            // 
            // bokTyp
            // 
            this.bokTyp.AutoSize = true;
            this.bokTyp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bokTyp.Location = new System.Drawing.Point(47, 151);
            this.bokTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bokTyp.Name = "bokTyp";
            this.bokTyp.Size = new System.Drawing.Size(36, 17);
            this.bokTyp.TabIndex = 6;
            this.bokTyp.Text = "Typ:";
            this.bokTyp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bokFakta
            // 
            this.bokFakta.AutoSize = true;
            this.bokFakta.Location = new System.Drawing.Point(165, 149);
            this.bokFakta.Margin = new System.Windows.Forms.Padding(4);
            this.bokFakta.Name = "bokFakta";
            this.bokFakta.Size = new System.Drawing.Size(60, 21);
            this.bokFakta.TabIndex = 2;
            this.bokFakta.TabStop = true;
            this.bokFakta.Text = "fakta";
            this.bokFakta.UseVisualStyleBackColor = true;
            // 
            // bokTiteln
            // 
            this.bokTiteln.Location = new System.Drawing.Point(96, 23);
            this.bokTiteln.Margin = new System.Windows.Forms.Padding(4);
            this.bokTiteln.Name = "bokTiteln";
            this.bokTiteln.Size = new System.Drawing.Size(221, 22);
            this.bokTiteln.TabIndex = 2;
            // 
            // bokBarn
            // 
            this.bokBarn.AutoSize = true;
            this.bokBarn.Location = new System.Drawing.Point(96, 149);
            this.bokBarn.Margin = new System.Windows.Forms.Padding(4);
            this.bokBarn.Name = "bokBarn";
            this.bokBarn.Size = new System.Drawing.Size(58, 21);
            this.bokBarn.TabIndex = 1;
            this.bokBarn.TabStop = true;
            this.bokBarn.Text = "barn";
            this.bokBarn.UseVisualStyleBackColor = true;
            // 
            // bokTitel
            // 
            this.bokTitel.AutoSize = true;
            this.bokTitel.Location = new System.Drawing.Point(52, 27);
            this.bokTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bokTitel.Name = "bokTitel";
            this.bokTitel.Size = new System.Drawing.Size(35, 17);
            this.bokTitel.TabIndex = 1;
            this.bokTitel.Text = "Titel";
            this.bokTitel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bokSkrib
            // 
            this.bokSkrib.AutoSize = true;
            this.bokSkrib.Location = new System.Drawing.Point(27, 59);
            this.bokSkrib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bokSkrib.Name = "bokSkrib";
            this.bokSkrib.Size = new System.Drawing.Size(60, 17);
            this.bokSkrib.TabIndex = 2;
            this.bokSkrib.Text = "Skribent";
            this.bokSkrib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bokSkriben
            // 
            this.bokSkriben.Location = new System.Drawing.Point(96, 55);
            this.bokSkriben.Margin = new System.Windows.Forms.Padding(4);
            this.bokSkriben.Name = "bokSkriben";
            this.bokSkriben.Size = new System.Drawing.Size(221, 22);
            this.bokSkriben.TabIndex = 3;
            // 
            // bokÅr
            // 
            this.bokÅr.AutoSize = true;
            this.bokÅr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bokÅr.Location = new System.Drawing.Point(61, 89);
            this.bokÅr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bokÅr.Name = "bokÅr";
            this.bokÅr.Size = new System.Drawing.Size(22, 17);
            this.bokÅr.TabIndex = 3;
            this.bokÅr.Text = "År";
            this.bokÅr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bokÅret
            // 
            this.bokÅret.Location = new System.Drawing.Point(96, 85);
            this.bokÅret.Margin = new System.Windows.Forms.Padding(4);
            this.bokÅret.Name = "bokÅret";
            this.bokÅret.Size = new System.Drawing.Size(221, 22);
            this.bokÅret.TabIndex = 4;
            // 
            // bokSidor
            // 
            this.bokSidor.AutoSize = true;
            this.bokSidor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bokSidor.Location = new System.Drawing.Point(13, 117);
            this.bokSidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bokSidor.Name = "bokSidor";
            this.bokSidor.Size = new System.Drawing.Size(75, 17);
            this.bokSidor.TabIndex = 4;
            this.bokSidor.Text = "Antal sidor";
            this.bokSidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bokSidorna
            // 
            this.bokSidorna.Location = new System.Drawing.Point(96, 117);
            this.bokSidorna.Margin = new System.Windows.Forms.Padding(4);
            this.bokSidorna.Name = "bokSidorna";
            this.bokSidorna.Size = new System.Drawing.Size(221, 22);
            this.bokSidorna.TabIndex = 5;
            // 
            // grupTids
            // 
            this.grupTids.Controls.Add(this.tidsRegi);
            this.grupTids.Controls.Add(this.tidsComics);
            this.grupTids.Controls.Add(this.tidsTyp);
            this.grupTids.Controls.Add(this.tidsMusik);
            this.grupTids.Controls.Add(this.tidsTiteln);
            this.grupTids.Controls.Add(this.tidsFritid);
            this.grupTids.Controls.Add(this.tidsTitel);
            this.grupTids.Controls.Add(this.tidsNum);
            this.grupTids.Controls.Add(this.tidsNummeret);
            this.grupTids.Controls.Add(this.tidsÅr);
            this.grupTids.Controls.Add(this.tidsÅret);
            this.grupTids.Enabled = false;
            this.grupTids.Location = new System.Drawing.Point(361, 15);
            this.grupTids.Margin = new System.Windows.Forms.Padding(4);
            this.grupTids.Name = "grupTids";
            this.grupTids.Padding = new System.Windows.Forms.Padding(4);
            this.grupTids.Size = new System.Drawing.Size(337, 228);
            this.grupTids.TabIndex = 8;
            this.grupTids.TabStop = false;
            this.grupTids.Text = "Tidskrift";
            // 
            // tidsRegi
            // 
            this.tidsRegi.Location = new System.Drawing.Point(109, 191);
            this.tidsRegi.Margin = new System.Windows.Forms.Padding(4);
            this.tidsRegi.Name = "tidsRegi";
            this.tidsRegi.Size = new System.Drawing.Size(133, 28);
            this.tidsRegi.TabIndex = 7;
            this.tidsRegi.Text = "Registrera tidskrift";
            this.tidsRegi.UseVisualStyleBackColor = true;
            this.tidsRegi.Click += new System.EventHandler(this.tidsRegi_Click);
            // 
            // tidsComics
            // 
            this.tidsComics.AutoSize = true;
            this.tidsComics.Location = new System.Drawing.Point(239, 117);
            this.tidsComics.Margin = new System.Windows.Forms.Padding(4);
            this.tidsComics.Name = "tidsComics";
            this.tidsComics.Size = new System.Drawing.Size(72, 21);
            this.tidsComics.TabIndex = 3;
            this.tidsComics.TabStop = true;
            this.tidsComics.Text = "comics";
            this.tidsComics.UseVisualStyleBackColor = true;
            // 
            // tidsTyp
            // 
            this.tidsTyp.AutoSize = true;
            this.tidsTyp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tidsTyp.Location = new System.Drawing.Point(47, 119);
            this.tidsTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tidsTyp.Name = "tidsTyp";
            this.tidsTyp.Size = new System.Drawing.Size(36, 17);
            this.tidsTyp.TabIndex = 6;
            this.tidsTyp.Text = "Typ:";
            this.tidsTyp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tidsMusik
            // 
            this.tidsMusik.AutoSize = true;
            this.tidsMusik.Location = new System.Drawing.Point(165, 117);
            this.tidsMusik.Margin = new System.Windows.Forms.Padding(4);
            this.tidsMusik.Name = "tidsMusik";
            this.tidsMusik.Size = new System.Drawing.Size(65, 21);
            this.tidsMusik.TabIndex = 2;
            this.tidsMusik.TabStop = true;
            this.tidsMusik.Text = "musik";
            this.tidsMusik.UseVisualStyleBackColor = true;
            // 
            // tidsTiteln
            // 
            this.tidsTiteln.Location = new System.Drawing.Point(96, 23);
            this.tidsTiteln.Margin = new System.Windows.Forms.Padding(4);
            this.tidsTiteln.Name = "tidsTiteln";
            this.tidsTiteln.Size = new System.Drawing.Size(221, 22);
            this.tidsTiteln.TabIndex = 2;
            // 
            // tidsFritid
            // 
            this.tidsFritid.AutoSize = true;
            this.tidsFritid.Location = new System.Drawing.Point(96, 117);
            this.tidsFritid.Margin = new System.Windows.Forms.Padding(4);
            this.tidsFritid.Name = "tidsFritid";
            this.tidsFritid.Size = new System.Drawing.Size(56, 21);
            this.tidsFritid.TabIndex = 1;
            this.tidsFritid.TabStop = true;
            this.tidsFritid.Text = "fritid";
            this.tidsFritid.UseVisualStyleBackColor = true;
            // 
            // tidsTitel
            // 
            this.tidsTitel.AutoSize = true;
            this.tidsTitel.Location = new System.Drawing.Point(52, 27);
            this.tidsTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tidsTitel.Name = "tidsTitel";
            this.tidsTitel.Size = new System.Drawing.Size(35, 17);
            this.tidsTitel.TabIndex = 1;
            this.tidsTitel.Text = "Titel";
            this.tidsTitel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tidsNum
            // 
            this.tidsNum.AutoSize = true;
            this.tidsNum.Location = new System.Drawing.Point(27, 59);
            this.tidsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tidsNum.Name = "tidsNum";
            this.tidsNum.Size = new System.Drawing.Size(61, 17);
            this.tidsNum.TabIndex = 2;
            this.tidsNum.Text = "Nummer";
            this.tidsNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tidsNummeret
            // 
            this.tidsNummeret.Location = new System.Drawing.Point(96, 55);
            this.tidsNummeret.Margin = new System.Windows.Forms.Padding(4);
            this.tidsNummeret.Name = "tidsNummeret";
            this.tidsNummeret.Size = new System.Drawing.Size(221, 22);
            this.tidsNummeret.TabIndex = 3;
            // 
            // tidsÅr
            // 
            this.tidsÅr.AutoSize = true;
            this.tidsÅr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tidsÅr.Location = new System.Drawing.Point(61, 89);
            this.tidsÅr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tidsÅr.Name = "tidsÅr";
            this.tidsÅr.Size = new System.Drawing.Size(22, 17);
            this.tidsÅr.TabIndex = 3;
            this.tidsÅr.Text = "År";
            this.tidsÅr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tidsÅret
            // 
            this.tidsÅret.Location = new System.Drawing.Point(96, 85);
            this.tidsÅret.Margin = new System.Windows.Forms.Padding(4);
            this.tidsÅret.Name = "tidsÅret";
            this.tidsÅret.Size = new System.Drawing.Size(221, 22);
            this.tidsÅret.TabIndex = 4;
            // 
            // bokhyllaCons
            // 
            this.bokhyllaCons.Location = new System.Drawing.Point(7, 22);
            this.bokhyllaCons.Margin = new System.Windows.Forms.Padding(4);
            this.bokhyllaCons.Multiline = true;
            this.bokhyllaCons.Name = "bokhyllaCons";
            this.bokhyllaCons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bokhyllaCons.Size = new System.Drawing.Size(1013, 86);
            this.bokhyllaCons.TabIndex = 10;
            // 
            // grbBibliotekare
            // 
            this.grbBibliotekare.Controls.Add(this.btnTaBortBibliot);
            this.grbBibliotekare.Controls.Add(this.btnSearchBibliot);
            this.grbBibliotekare.Controls.Add(this.rdbYearBibliot);
            this.grbBibliotekare.Controls.Add(this.rdbTitelBibliot);
            this.grbBibliotekare.Controls.Add(this.txbSearchBibliot);
            this.grbBibliotekare.Controls.Add(this.lblSearchBibliot);
            this.grbBibliotekare.Enabled = false;
            this.grbBibliotekare.Location = new System.Drawing.Point(703, 15);
            this.grbBibliotekare.Name = "grbBibliotekare";
            this.grbBibliotekare.Size = new System.Drawing.Size(337, 228);
            this.grbBibliotekare.TabIndex = 11;
            this.grbBibliotekare.TabStop = false;
            this.grbBibliotekare.Text = "Bibliotekare";
            // 
            // btnTaBortBibliot
            // 
            this.btnTaBortBibliot.Location = new System.Drawing.Point(184, 106);
            this.btnTaBortBibliot.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaBortBibliot.Name = "btnTaBortBibliot";
            this.btnTaBortBibliot.Size = new System.Drawing.Size(133, 28);
            this.btnTaBortBibliot.TabIndex = 13;
            this.btnTaBortBibliot.Text = "Ta bort";
            this.btnTaBortBibliot.UseVisualStyleBackColor = true;
            this.btnTaBortBibliot.Click += new System.EventHandler(this.btnTaBortBibliot_Click);
            // 
            // btnSearchBibliot
            // 
            this.btnSearchBibliot.Location = new System.Drawing.Point(40, 106);
            this.btnSearchBibliot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBibliot.Name = "btnSearchBibliot";
            this.btnSearchBibliot.Size = new System.Drawing.Size(133, 28);
            this.btnSearchBibliot.TabIndex = 9;
            this.btnSearchBibliot.Text = "Söka efter";
            this.btnSearchBibliot.UseVisualStyleBackColor = true;
            this.btnSearchBibliot.Click += new System.EventHandler(this.btnSearchBibliot_Click);
            // 
            // rdbYearBibliot
            // 
            this.rdbYearBibliot.AutoSize = true;
            this.rdbYearBibliot.Location = new System.Drawing.Point(165, 67);
            this.rdbYearBibliot.Margin = new System.Windows.Forms.Padding(4);
            this.rdbYearBibliot.Name = "rdbYearBibliot";
            this.rdbYearBibliot.Size = new System.Drawing.Size(42, 21);
            this.rdbYearBibliot.TabIndex = 8;
            this.rdbYearBibliot.TabStop = true;
            this.rdbYearBibliot.Text = "år";
            this.rdbYearBibliot.UseVisualStyleBackColor = true;
            // 
            // rdbTitelBibliot
            // 
            this.rdbTitelBibliot.AutoSize = true;
            this.rdbTitelBibliot.Location = new System.Drawing.Point(96, 67);
            this.rdbTitelBibliot.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTitelBibliot.Name = "rdbTitelBibliot";
            this.rdbTitelBibliot.Size = new System.Drawing.Size(51, 21);
            this.rdbTitelBibliot.TabIndex = 4;
            this.rdbTitelBibliot.TabStop = true;
            this.rdbTitelBibliot.Text = "titel";
            this.rdbTitelBibliot.UseVisualStyleBackColor = true;
            // 
            // txbSearchBibliot
            // 
            this.txbSearchBibliot.Location = new System.Drawing.Point(96, 37);
            this.txbSearchBibliot.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchBibliot.Name = "txbSearchBibliot";
            this.txbSearchBibliot.Size = new System.Drawing.Size(221, 22);
            this.txbSearchBibliot.TabIndex = 3;
            // 
            // lblSearchBibliot
            // 
            this.lblSearchBibliot.AutoSize = true;
            this.lblSearchBibliot.Location = new System.Drawing.Point(59, 40);
            this.lblSearchBibliot.Name = "lblSearchBibliot";
            this.lblSearchBibliot.Size = new System.Drawing.Size(30, 17);
            this.lblSearchBibliot.TabIndex = 0;
            this.lblSearchBibliot.Text = "sök";
            this.lblSearchBibliot.Click += new System.EventHandler(this.lblSearchBibliot_Click);
            // 
            // grbConsole
            // 
            this.grbConsole.Controls.Add(this.bokhyllaCons);
            this.grbConsole.Location = new System.Drawing.Point(16, 613);
            this.grbConsole.Name = "grbConsole";
            this.grbConsole.Size = new System.Drawing.Size(1027, 115);
            this.grbConsole.TabIndex = 12;
            this.grbConsole.TabStop = false;
            this.grbConsole.Text = "Console";
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lbxList);
            this.grpList.Location = new System.Drawing.Point(16, 250);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(682, 357);
            this.grpList.TabIndex = 13;
            this.grpList.TabStop = false;
            this.grpList.Text = "List";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 16;
            this.lbxList.Location = new System.Drawing.Point(6, 24);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(670, 324);
            this.lbxList.TabIndex = 0;
            // 
            // grpKlient
            // 
            this.grpKlient.Controls.Add(this.btnKlientAlla);
            this.grpKlient.Controls.Add(this.btnKlientMark);
            this.grpKlient.Controls.Add(this.btnKlientLadda);
            this.grpKlient.Controls.Add(this.btnKlientKoppla);
            this.grpKlient.Location = new System.Drawing.Point(706, 250);
            this.grpKlient.Name = "grpKlient";
            this.grpKlient.Size = new System.Drawing.Size(337, 357);
            this.grpKlient.TabIndex = 14;
            this.grpKlient.TabStop = false;
            this.grpKlient.Text = "Klient";
            // 
            // btnKlientAlla
            // 
            this.btnKlientAlla.Enabled = false;
            this.btnKlientAlla.Location = new System.Drawing.Point(15, 206);
            this.btnKlientAlla.Margin = new System.Windows.Forms.Padding(4);
            this.btnKlientAlla.Name = "btnKlientAlla";
            this.btnKlientAlla.Size = new System.Drawing.Size(299, 28);
            this.btnKlientAlla.TabIndex = 17;
            this.btnKlientAlla.Text = "Skicka alla objekt";
            this.btnKlientAlla.UseVisualStyleBackColor = true;
            this.btnKlientAlla.Click += new System.EventHandler(this.btnKlientAlla_Click);
            // 
            // btnKlientMark
            // 
            this.btnKlientMark.Enabled = false;
            this.btnKlientMark.Location = new System.Drawing.Point(15, 160);
            this.btnKlientMark.Margin = new System.Windows.Forms.Padding(4);
            this.btnKlientMark.Name = "btnKlientMark";
            this.btnKlientMark.Size = new System.Drawing.Size(299, 28);
            this.btnKlientMark.TabIndex = 16;
            this.btnKlientMark.Text = "Skicka markerat objekt";
            this.btnKlientMark.UseVisualStyleBackColor = true;
            this.btnKlientMark.Click += new System.EventHandler(this.btnKlientMark_Click);
            // 
            // btnKlientLadda
            // 
            this.btnKlientLadda.Location = new System.Drawing.Point(15, 114);
            this.btnKlientLadda.Margin = new System.Windows.Forms.Padding(4);
            this.btnKlientLadda.Name = "btnKlientLadda";
            this.btnKlientLadda.Size = new System.Drawing.Size(299, 28);
            this.btnKlientLadda.TabIndex = 15;
            this.btnKlientLadda.Text = "Ladda lista";
            this.btnKlientLadda.UseVisualStyleBackColor = true;
            this.btnKlientLadda.Click += new System.EventHandler(this.btnKlientLadda_Click);
            // 
            // btnKlientKoppla
            // 
            this.btnKlientKoppla.Location = new System.Drawing.Point(15, 34);
            this.btnKlientKoppla.Margin = new System.Windows.Forms.Padding(4);
            this.btnKlientKoppla.Name = "btnKlientKoppla";
            this.btnKlientKoppla.Size = new System.Drawing.Size(299, 53);
            this.btnKlientKoppla.TabIndex = 14;
            this.btnKlientKoppla.Text = "Koppla till server";
            this.btnKlientKoppla.UseVisualStyleBackColor = true;
            this.btnKlientKoppla.Click += new System.EventHandler(this.btnKlientKoppla_Click);
            // 
            // bokhyllaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 739);
            this.Controls.Add(this.grpKlient);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grbConsole);
            this.Controls.Add(this.grbBibliotekare);
            this.Controls.Add(this.grupTids);
            this.Controls.Add(this.grupBok);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bokhyllaForm";
            this.Text = "Bokhylla";
            this.Load += new System.EventHandler(this.bokhyllaForm_Load);
            this.grupBok.ResumeLayout(false);
            this.grupBok.PerformLayout();
            this.grupTids.ResumeLayout(false);
            this.grupTids.PerformLayout();
            this.grbBibliotekare.ResumeLayout(false);
            this.grbBibliotekare.PerformLayout();
            this.grbConsole.ResumeLayout(false);
            this.grbConsole.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpKlient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupBok;
        private System.Windows.Forms.Label bokTitel;
        private System.Windows.Forms.Label bokSkrib;
        private System.Windows.Forms.Label bokÅr;
        private System.Windows.Forms.Label bokSidor;
        private System.Windows.Forms.TextBox bokTiteln;
        private System.Windows.Forms.TextBox bokSkriben;
        private System.Windows.Forms.TextBox bokÅret;
        private System.Windows.Forms.TextBox bokSidorna;
        private System.Windows.Forms.Label bokTyp;
        private System.Windows.Forms.RadioButton bokRoman;
        private System.Windows.Forms.RadioButton bokFakta;
        private System.Windows.Forms.RadioButton bokBarn;
        private System.Windows.Forms.Button bokRegis;
        private System.Windows.Forms.GroupBox grupTids;
        private System.Windows.Forms.Button tidsRegi;
        private System.Windows.Forms.RadioButton tidsComics;
        private System.Windows.Forms.Label tidsTyp;
        private System.Windows.Forms.RadioButton tidsMusik;
        private System.Windows.Forms.TextBox tidsTiteln;
        private System.Windows.Forms.RadioButton tidsFritid;
        private System.Windows.Forms.Label tidsTitel;
        private System.Windows.Forms.Label tidsNum;
        private System.Windows.Forms.TextBox tidsNummeret;
        private System.Windows.Forms.Label tidsÅr;
        private System.Windows.Forms.TextBox tidsÅret;
        private System.Windows.Forms.TextBox bokhyllaCons;
        private System.Windows.Forms.GroupBox grbBibliotekare;
        private System.Windows.Forms.GroupBox grbConsole;
        private System.Windows.Forms.Button btnSearchBibliot;
        private System.Windows.Forms.RadioButton rdbYearBibliot;
        private System.Windows.Forms.RadioButton rdbTitelBibliot;
        private System.Windows.Forms.TextBox txbSearchBibliot;
        private System.Windows.Forms.Label lblSearchBibliot;
        private System.Windows.Forms.Button btnTaBortBibliot;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.GroupBox grpKlient;
        private System.Windows.Forms.Button btnKlientAlla;
        private System.Windows.Forms.Button btnKlientMark;
        private System.Windows.Forms.Button btnKlientLadda;
        private System.Windows.Forms.Button btnKlientKoppla;
        private System.Windows.Forms.ListBox lbxList;
    }
}

