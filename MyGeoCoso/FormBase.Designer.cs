namespace MyGeoCoso
{
    partial class FormBase
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.graph = new Mate.Graph.Graph();
            this.txtFunzione = new System.Windows.Forms.TextBox();
            this.btnDisegna = new System.Windows.Forms.Button();
            this.TabPanFunzioni = new System.Windows.Forms.TabControl();
            this.tabParametri = new System.Windows.Forms.TabPage();
            this.btnSvuota = new System.Windows.Forms.Button();
            this.lblDelY = new System.Windows.Forms.Label();
            this.lblDelX = new System.Windows.Forms.Label();
            this.lblMinY = new System.Windows.Forms.Label();
            this.lblMaxY = new System.Windows.Forms.Label();
            this.lblMinX = new System.Windows.Forms.Label();
            this.lblMaxX = new System.Windows.Forms.Label();
            this.txrMaxX = new Mate.TextRegex.TextRegex();
            this.txrMinX = new Mate.TextRegex.TextRegex();
            this.txrMaxY = new Mate.TextRegex.TextRegex();
            this.txrDelY = new Mate.TextRegex.TextRegex();
            this.txrMinY = new Mate.TextRegex.TextRegex();
            this.txrDelX = new Mate.TextRegex.TextRegex();
            this.tabBisezione = new System.Windows.Forms.TabPage();
            this.btnBisezione = new System.Windows.Forms.Button();
            this.lblBXa = new System.Windows.Forms.Label();
            this.lblBXb = new System.Windows.Forms.Label();
            this.lblBPrecisione = new System.Windows.Forms.Label();
            this.lblBCicli = new System.Windows.Forms.Label();
            this.txrBXa = new Mate.TextRegex.TextRegex();
            this.txrBXb = new Mate.TextRegex.TextRegex();
            this.txrBPrecisione = new Mate.TextRegex.TextRegex();
            this.txrBCicli = new Mate.TextRegex.TextRegex();
            this.tabSecanti = new System.Windows.Forms.TabPage();
            this.btnSecante = new System.Windows.Forms.Button();
            this.lblSXa = new System.Windows.Forms.Label();
            this.lblSXb = new System.Windows.Forms.Label();
            this.lblSPrecisione = new System.Windows.Forms.Label();
            this.lblSCicli = new System.Windows.Forms.Label();
            this.txrSXa = new Mate.TextRegex.TextRegex();
            this.txrSXb = new Mate.TextRegex.TextRegex();
            this.txrSPrecisione = new Mate.TextRegex.TextRegex();
            this.txrSCicli = new Mate.TextRegex.TextRegex();
            this.tabTangenti = new System.Windows.Forms.TabPage();
            this.btnTengenti = new System.Windows.Forms.Button();
            this.lblTXa = new System.Windows.Forms.Label();
            this.lblTXb = new System.Windows.Forms.Label();
            this.lblTPrecisione = new System.Windows.Forms.Label();
            this.lblTCicli = new System.Windows.Forms.Label();
            this.txrTXa = new Mate.TextRegex.TextRegex();
            this.txrTXb = new Mate.TextRegex.TextRegex();
            this.txrTPrecisione = new Mate.TextRegex.TextRegex();
            this.txrTCicli = new Mate.TextRegex.TextRegex();
            this.tabIntegrale = new System.Windows.Forms.TabPage();
            this.btnIntegra = new System.Windows.Forms.Button();
            this.numIDivisioni = new System.Windows.Forms.NumericUpDown();
            this.lblIDivisioni = new System.Windows.Forms.Label();
            this.groupIDisegna = new System.Windows.Forms.GroupBox();
            this.checkTrap = new System.Windows.Forms.CheckBox();
            this.checkRetMin = new System.Windows.Forms.CheckBox();
            this.checkRetMag = new System.Windows.Forms.CheckBox();
            this.lblIXa = new System.Windows.Forms.Label();
            this.lblIXb = new System.Windows.Forms.Label();
            this.txrIXa = new Mate.TextRegex.TextRegex();
            this.txrIXb = new Mate.TextRegex.TextRegex();
            this.lblFunzione = new System.Windows.Forms.Label();
            this.TabPanFunzioni.SuspendLayout();
            this.tabParametri.SuspendLayout();
            this.tabBisezione.SuspendLayout();
            this.tabSecanti.SuspendLayout();
            this.tabTangenti.SuspendLayout();
            this.tabIntegrale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIDivisioni)).BeginInit();
            this.groupIDisegna.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph._enableZoomingPanning = true;
            this.graph._xMax = 10D;
            this.graph._xMin = -10D;
            this.graph._yMax = 10D;
            this.graph._yMin = -10D;
            this.graph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(360, 360);
            this.graph.TabIndex = 0;
            this.graph.TabStop = false;
            // 
            // txtFunzione
            // 
            this.txtFunzione.Location = new System.Drawing.Point(396, 14);
            this.txtFunzione.Name = "txtFunzione";
            this.txtFunzione.Size = new System.Drawing.Size(273, 20);
            this.txtFunzione.TabIndex = 0;
            this.txtFunzione.Text = "x";
            this.txtFunzione.TextChanged += new System.EventHandler(this.ControlloMinuscolo);
            // 
            // btnDisegna
            // 
            this.btnDisegna.Location = new System.Drawing.Point(675, 12);
            this.btnDisegna.Name = "btnDisegna";
            this.btnDisegna.Size = new System.Drawing.Size(75, 23);
            this.btnDisegna.TabIndex = 1;
            this.btnDisegna.Text = "Disegna";
            this.btnDisegna.UseVisualStyleBackColor = true;
            this.btnDisegna.Click += new System.EventHandler(this.DisegnaClick);
            // 
            // TabPanFunzioni
            // 
            this.TabPanFunzioni.Controls.Add(this.tabParametri);
            this.TabPanFunzioni.Controls.Add(this.tabBisezione);
            this.TabPanFunzioni.Controls.Add(this.tabSecanti);
            this.TabPanFunzioni.Controls.Add(this.tabTangenti);
            this.TabPanFunzioni.Controls.Add(this.tabIntegrale);
            this.TabPanFunzioni.HotTrack = true;
            this.TabPanFunzioni.Location = new System.Drawing.Point(362, 38);
            this.TabPanFunzioni.Name = "TabPanFunzioni";
            this.TabPanFunzioni.SelectedIndex = 0;
            this.TabPanFunzioni.Size = new System.Drawing.Size(400, 322);
            this.TabPanFunzioni.TabIndex = 2;
            // 
            // tabParametri
            // 
            this.tabParametri.Controls.Add(this.btnSvuota);
            this.tabParametri.Controls.Add(this.lblDelY);
            this.tabParametri.Controls.Add(this.lblDelX);
            this.tabParametri.Controls.Add(this.lblMinY);
            this.tabParametri.Controls.Add(this.lblMaxY);
            this.tabParametri.Controls.Add(this.lblMinX);
            this.tabParametri.Controls.Add(this.lblMaxX);
            this.tabParametri.Controls.Add(this.txrMaxX);
            this.tabParametri.Controls.Add(this.txrMinX);
            this.tabParametri.Controls.Add(this.txrMaxY);
            this.tabParametri.Controls.Add(this.txrDelY);
            this.tabParametri.Controls.Add(this.txrMinY);
            this.tabParametri.Controls.Add(this.txrDelX);
            this.tabParametri.Location = new System.Drawing.Point(4, 22);
            this.tabParametri.Name = "tabParametri";
            this.tabParametri.Padding = new System.Windows.Forms.Padding(3);
            this.tabParametri.Size = new System.Drawing.Size(392, 296);
            this.tabParametri.TabIndex = 0;
            this.tabParametri.Text = "Parametri";
            this.tabParametri.UseVisualStyleBackColor = true;
            // 
            // btnSvuota
            // 
            this.btnSvuota.Location = new System.Drawing.Point(311, 256);
            this.btnSvuota.Name = "btnSvuota";
            this.btnSvuota.Size = new System.Drawing.Size(75, 34);
            this.btnSvuota.TabIndex = 9;
            this.btnSvuota.Text = "Pulisci Grafico";
            this.btnSvuota.UseVisualStyleBackColor = true;
            this.btnSvuota.Click += new System.EventHandler(this.PulisciGrafico);
            // 
            // lblDelY
            // 
            this.lblDelY.AutoSize = true;
            this.lblDelY.Location = new System.Drawing.Point(48, 250);
            this.lblDelY.Name = "lblDelY";
            this.lblDelY.Size = new System.Drawing.Size(27, 13);
            this.lblDelY.TabIndex = 12;
            this.lblDelY.Text = "Δ Y:";
            // 
            // lblDelX
            // 
            this.lblDelX.AutoSize = true;
            this.lblDelX.Location = new System.Drawing.Point(48, 209);
            this.lblDelX.Name = "lblDelX";
            this.lblDelX.Size = new System.Drawing.Size(27, 13);
            this.lblDelX.TabIndex = 11;
            this.lblDelX.Text = "Δ X:";
            // 
            // lblMinY
            // 
            this.lblMinY.AutoSize = true;
            this.lblMinY.Location = new System.Drawing.Point(48, 167);
            this.lblMinY.Name = "lblMinY";
            this.lblMinY.Size = new System.Drawing.Size(37, 13);
            this.lblMinY.TabIndex = 10;
            this.lblMinY.Text = "Y Min:";
            // 
            // lblMaxY
            // 
            this.lblMaxY.AutoSize = true;
            this.lblMaxY.Location = new System.Drawing.Point(48, 125);
            this.lblMaxY.Name = "lblMaxY";
            this.lblMaxY.Size = new System.Drawing.Size(40, 13);
            this.lblMaxY.TabIndex = 9;
            this.lblMaxY.Text = "Y Max:";
            // 
            // lblMinX
            // 
            this.lblMinX.AutoSize = true;
            this.lblMinX.Location = new System.Drawing.Point(48, 83);
            this.lblMinX.Name = "lblMinX";
            this.lblMinX.Size = new System.Drawing.Size(37, 13);
            this.lblMinX.TabIndex = 8;
            this.lblMinX.Text = "X Min:";
            // 
            // lblMaxX
            // 
            this.lblMaxX.AutoSize = true;
            this.lblMaxX.Location = new System.Drawing.Point(48, 41);
            this.lblMaxX.Name = "lblMaxX";
            this.lblMaxX.Size = new System.Drawing.Size(40, 13);
            this.lblMaxX.TabIndex = 7;
            this.lblMaxX.Text = "X Max:";
            // 
            // txrMaxX
            // 
            this.txrMaxX.Location = new System.Drawing.Point(113, 34);
            this.txrMaxX.Name = "txrMaxX";
            this.txrMaxX.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrMaxX.SafeText = "10";
            this.txrMaxX.Size = new System.Drawing.Size(154, 20);
            this.txrMaxX.TabIndex = 3;
            // 
            // txrMinX
            // 
            this.txrMinX.Location = new System.Drawing.Point(113, 76);
            this.txrMinX.Name = "txrMinX";
            this.txrMinX.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrMinX.SafeText = "-10";
            this.txrMinX.Size = new System.Drawing.Size(154, 20);
            this.txrMinX.TabIndex = 4;
            // 
            // txrMaxY
            // 
            this.txrMaxY.Location = new System.Drawing.Point(113, 118);
            this.txrMaxY.Name = "txrMaxY";
            this.txrMaxY.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrMaxY.SafeText = "10";
            this.txrMaxY.Size = new System.Drawing.Size(154, 20);
            this.txrMaxY.TabIndex = 5;
            // 
            // txrDelY
            // 
            this.txrDelY.Location = new System.Drawing.Point(113, 243);
            this.txrDelY.Name = "txrDelY";
            this.txrDelY.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrDelY.SafeText = "1";
            this.txrDelY.Size = new System.Drawing.Size(154, 20);
            this.txrDelY.TabIndex = 8;
            // 
            // txrMinY
            // 
            this.txrMinY.Location = new System.Drawing.Point(113, 160);
            this.txrMinY.Name = "txrMinY";
            this.txrMinY.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrMinY.SafeText = "-10";
            this.txrMinY.Size = new System.Drawing.Size(154, 20);
            this.txrMinY.TabIndex = 6;
            // 
            // txrDelX
            // 
            this.txrDelX.Location = new System.Drawing.Point(113, 202);
            this.txrDelX.Name = "txrDelX";
            this.txrDelX.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrDelX.SafeText = "1";
            this.txrDelX.Size = new System.Drawing.Size(154, 20);
            this.txrDelX.TabIndex = 7;
            // 
            // tabBisezione
            // 
            this.tabBisezione.Controls.Add(this.btnBisezione);
            this.tabBisezione.Controls.Add(this.lblBXa);
            this.tabBisezione.Controls.Add(this.lblBXb);
            this.tabBisezione.Controls.Add(this.lblBPrecisione);
            this.tabBisezione.Controls.Add(this.lblBCicli);
            this.tabBisezione.Controls.Add(this.txrBXa);
            this.tabBisezione.Controls.Add(this.txrBXb);
            this.tabBisezione.Controls.Add(this.txrBPrecisione);
            this.tabBisezione.Controls.Add(this.txrBCicli);
            this.tabBisezione.Location = new System.Drawing.Point(4, 22);
            this.tabBisezione.Name = "tabBisezione";
            this.tabBisezione.Padding = new System.Windows.Forms.Padding(3);
            this.tabBisezione.Size = new System.Drawing.Size(392, 296);
            this.tabBisezione.TabIndex = 1;
            this.tabBisezione.Text = "Bisezione";
            this.tabBisezione.UseVisualStyleBackColor = true;
            // 
            // btnBisezione
            // 
            this.btnBisezione.Location = new System.Drawing.Point(159, 219);
            this.btnBisezione.Name = "btnBisezione";
            this.btnBisezione.Size = new System.Drawing.Size(75, 23);
            this.btnBisezione.TabIndex = 7;
            this.btnBisezione.Text = "Biseziona";
            this.btnBisezione.UseVisualStyleBackColor = true;
            this.btnBisezione.Click += new System.EventHandler(this.DisegnaBisezione);
            // 
            // lblBXa
            // 
            this.lblBXa.AutoSize = true;
            this.lblBXa.Location = new System.Drawing.Point(118, 61);
            this.lblBXa.Name = "lblBXa";
            this.lblBXa.Size = new System.Drawing.Size(26, 13);
            this.lblBXa.TabIndex = 10;
            this.lblBXa.Text = "Xa: ";
            // 
            // lblBXb
            // 
            this.lblBXb.AutoSize = true;
            this.lblBXb.Location = new System.Drawing.Point(118, 87);
            this.lblBXb.Name = "lblBXb";
            this.lblBXb.Size = new System.Drawing.Size(26, 13);
            this.lblBXb.TabIndex = 11;
            this.lblBXb.Text = "Xb: ";
            // 
            // lblBPrecisione
            // 
            this.lblBPrecisione.AutoSize = true;
            this.lblBPrecisione.Location = new System.Drawing.Point(89, 135);
            this.lblBPrecisione.Name = "lblBPrecisione";
            this.lblBPrecisione.Size = new System.Drawing.Size(62, 13);
            this.lblBPrecisione.TabIndex = 12;
            this.lblBPrecisione.Text = "Precisione: ";
            // 
            // lblBCicli
            // 
            this.lblBCicli.AutoSize = true;
            this.lblBCicli.Location = new System.Drawing.Point(122, 161);
            this.lblBCicli.Name = "lblBCicli";
            this.lblBCicli.Size = new System.Drawing.Size(29, 13);
            this.lblBCicli.TabIndex = 13;
            this.lblBCicli.Text = "Cicli:";
            // 
            // txrBXa
            // 
            this.txrBXa.Location = new System.Drawing.Point(183, 54);
            this.txrBXa.Name = "txrBXa";
            this.txrBXa.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrBXa.SafeText = "-2";
            this.txrBXa.Size = new System.Drawing.Size(120, 20);
            this.txrBXa.TabIndex = 3;
            // 
            // txrBXb
            // 
            this.txrBXb.Location = new System.Drawing.Point(183, 80);
            this.txrBXb.Name = "txrBXb";
            this.txrBXb.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrBXb.SafeText = "2";
            this.txrBXb.Size = new System.Drawing.Size(120, 20);
            this.txrBXb.TabIndex = 4;
            // 
            // txrBPrecisione
            // 
            this.txrBPrecisione.Location = new System.Drawing.Point(183, 128);
            this.txrBPrecisione.Name = "txrBPrecisione";
            this.txrBPrecisione.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrBPrecisione.SafeText = "0,01";
            this.txrBPrecisione.Size = new System.Drawing.Size(120, 20);
            this.txrBPrecisione.TabIndex = 5;
            // 
            // txrBCicli
            // 
            this.txrBCicli.Location = new System.Drawing.Point(183, 154);
            this.txrBCicli.Name = "txrBCicli";
            this.txrBCicli.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrBCicli.SafeText = "5";
            this.txrBCicli.Size = new System.Drawing.Size(120, 20);
            this.txrBCicli.TabIndex = 6;
            // 
            // tabSecanti
            // 
            this.tabSecanti.Controls.Add(this.btnSecante);
            this.tabSecanti.Controls.Add(this.lblSXa);
            this.tabSecanti.Controls.Add(this.lblSXb);
            this.tabSecanti.Controls.Add(this.lblSPrecisione);
            this.tabSecanti.Controls.Add(this.lblSCicli);
            this.tabSecanti.Controls.Add(this.txrSXa);
            this.tabSecanti.Controls.Add(this.txrSXb);
            this.tabSecanti.Controls.Add(this.txrSPrecisione);
            this.tabSecanti.Controls.Add(this.txrSCicli);
            this.tabSecanti.Location = new System.Drawing.Point(4, 22);
            this.tabSecanti.Name = "tabSecanti";
            this.tabSecanti.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecanti.Size = new System.Drawing.Size(392, 296);
            this.tabSecanti.TabIndex = 2;
            this.tabSecanti.Text = "Secanti";
            this.tabSecanti.UseVisualStyleBackColor = true;
            // 
            // btnSecante
            // 
            this.btnSecante.Location = new System.Drawing.Point(159, 219);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(75, 23);
            this.btnSecante.TabIndex = 7;
            this.btnSecante.Text = "Secante";
            this.btnSecante.UseVisualStyleBackColor = true;
            this.btnSecante.Click += new System.EventHandler(this.DisegnaSecante);
            // 
            // lblSXa
            // 
            this.lblSXa.AutoSize = true;
            this.lblSXa.Location = new System.Drawing.Point(118, 61);
            this.lblSXa.Name = "lblSXa";
            this.lblSXa.Size = new System.Drawing.Size(26, 13);
            this.lblSXa.TabIndex = 18;
            this.lblSXa.Text = "Xa: ";
            // 
            // lblSXb
            // 
            this.lblSXb.AutoSize = true;
            this.lblSXb.Location = new System.Drawing.Point(118, 87);
            this.lblSXb.Name = "lblSXb";
            this.lblSXb.Size = new System.Drawing.Size(26, 13);
            this.lblSXb.TabIndex = 20;
            this.lblSXb.Text = "Xb: ";
            // 
            // lblSPrecisione
            // 
            this.lblSPrecisione.AutoSize = true;
            this.lblSPrecisione.Location = new System.Drawing.Point(89, 135);
            this.lblSPrecisione.Name = "lblSPrecisione";
            this.lblSPrecisione.Size = new System.Drawing.Size(62, 13);
            this.lblSPrecisione.TabIndex = 21;
            this.lblSPrecisione.Text = "Precisione: ";
            // 
            // lblSCicli
            // 
            this.lblSCicli.AutoSize = true;
            this.lblSCicli.Location = new System.Drawing.Point(122, 161);
            this.lblSCicli.Name = "lblSCicli";
            this.lblSCicli.Size = new System.Drawing.Size(29, 13);
            this.lblSCicli.TabIndex = 22;
            this.lblSCicli.Text = "Cicli:";
            // 
            // txrSXa
            // 
            this.txrSXa.Location = new System.Drawing.Point(183, 54);
            this.txrSXa.Name = "txrSXa";
            this.txrSXa.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrSXa.SafeText = "-2";
            this.txrSXa.Size = new System.Drawing.Size(120, 20);
            this.txrSXa.TabIndex = 3;
            // 
            // txrSXb
            // 
            this.txrSXb.Location = new System.Drawing.Point(183, 80);
            this.txrSXb.Name = "txrSXb";
            this.txrSXb.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrSXb.SafeText = "2";
            this.txrSXb.Size = new System.Drawing.Size(120, 20);
            this.txrSXb.TabIndex = 4;
            // 
            // txrSPrecisione
            // 
            this.txrSPrecisione.Location = new System.Drawing.Point(183, 128);
            this.txrSPrecisione.Name = "txrSPrecisione";
            this.txrSPrecisione.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrSPrecisione.SafeText = "0,01";
            this.txrSPrecisione.Size = new System.Drawing.Size(120, 20);
            this.txrSPrecisione.TabIndex = 5;
            // 
            // txrSCicli
            // 
            this.txrSCicli.Location = new System.Drawing.Point(183, 154);
            this.txrSCicli.Name = "txrSCicli";
            this.txrSCicli.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrSCicli.SafeText = "5";
            this.txrSCicli.Size = new System.Drawing.Size(120, 20);
            this.txrSCicli.TabIndex = 6;
            // 
            // tabTangenti
            // 
            this.tabTangenti.Controls.Add(this.btnTengenti);
            this.tabTangenti.Controls.Add(this.lblTXa);
            this.tabTangenti.Controls.Add(this.lblTXb);
            this.tabTangenti.Controls.Add(this.lblTPrecisione);
            this.tabTangenti.Controls.Add(this.lblTCicli);
            this.tabTangenti.Controls.Add(this.txrTXa);
            this.tabTangenti.Controls.Add(this.txrTXb);
            this.tabTangenti.Controls.Add(this.txrTPrecisione);
            this.tabTangenti.Controls.Add(this.txrTCicli);
            this.tabTangenti.Location = new System.Drawing.Point(4, 22);
            this.tabTangenti.Name = "tabTangenti";
            this.tabTangenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabTangenti.Size = new System.Drawing.Size(392, 296);
            this.tabTangenti.TabIndex = 3;
            this.tabTangenti.Text = "Tangenti/Newton";
            this.tabTangenti.UseVisualStyleBackColor = true;
            // 
            // btnTengenti
            // 
            this.btnTengenti.Location = new System.Drawing.Point(159, 219);
            this.btnTengenti.Name = "btnTengenti";
            this.btnTengenti.Size = new System.Drawing.Size(75, 23);
            this.btnTengenti.TabIndex = 7;
            this.btnTengenti.Text = "Tangente";
            this.btnTengenti.UseVisualStyleBackColor = true;
            this.btnTengenti.Click += new System.EventHandler(this.DisegnaTagenti);
            // 
            // lblTXa
            // 
            this.lblTXa.AutoSize = true;
            this.lblTXa.Location = new System.Drawing.Point(118, 61);
            this.lblTXa.Name = "lblTXa";
            this.lblTXa.Size = new System.Drawing.Size(26, 13);
            this.lblTXa.TabIndex = 27;
            this.lblTXa.Text = "Xa: ";
            // 
            // lblTXb
            // 
            this.lblTXb.AutoSize = true;
            this.lblTXb.Location = new System.Drawing.Point(118, 87);
            this.lblTXb.Name = "lblTXb";
            this.lblTXb.Size = new System.Drawing.Size(26, 13);
            this.lblTXb.TabIndex = 29;
            this.lblTXb.Text = "Xb: ";
            // 
            // lblTPrecisione
            // 
            this.lblTPrecisione.AutoSize = true;
            this.lblTPrecisione.Location = new System.Drawing.Point(89, 135);
            this.lblTPrecisione.Name = "lblTPrecisione";
            this.lblTPrecisione.Size = new System.Drawing.Size(62, 13);
            this.lblTPrecisione.TabIndex = 30;
            this.lblTPrecisione.Text = "Precisione: ";
            // 
            // lblTCicli
            // 
            this.lblTCicli.AutoSize = true;
            this.lblTCicli.Location = new System.Drawing.Point(122, 161);
            this.lblTCicli.Name = "lblTCicli";
            this.lblTCicli.Size = new System.Drawing.Size(29, 13);
            this.lblTCicli.TabIndex = 31;
            this.lblTCicli.Text = "Cicli:";
            // 
            // txrTXa
            // 
            this.txrTXa.Location = new System.Drawing.Point(183, 54);
            this.txrTXa.Name = "txrTXa";
            this.txrTXa.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrTXa.SafeText = "-2";
            this.txrTXa.Size = new System.Drawing.Size(120, 20);
            this.txrTXa.TabIndex = 3;
            // 
            // txrTXb
            // 
            this.txrTXb.Location = new System.Drawing.Point(183, 80);
            this.txrTXb.Name = "txrTXb";
            this.txrTXb.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrTXb.SafeText = "2";
            this.txrTXb.Size = new System.Drawing.Size(120, 20);
            this.txrTXb.TabIndex = 4;
            // 
            // txrTPrecisione
            // 
            this.txrTPrecisione.Location = new System.Drawing.Point(183, 128);
            this.txrTPrecisione.Name = "txrTPrecisione";
            this.txrTPrecisione.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrTPrecisione.SafeText = "0,01";
            this.txrTPrecisione.Size = new System.Drawing.Size(120, 20);
            this.txrTPrecisione.TabIndex = 5;
            // 
            // txrTCicli
            // 
            this.txrTCicli.Location = new System.Drawing.Point(183, 154);
            this.txrTCicli.Name = "txrTCicli";
            this.txrTCicli.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrTCicli.SafeText = "5";
            this.txrTCicli.Size = new System.Drawing.Size(120, 20);
            this.txrTCicli.TabIndex = 6;
            // 
            // tabIntegrale
            // 
            this.tabIntegrale.Controls.Add(this.btnIntegra);
            this.tabIntegrale.Controls.Add(this.numIDivisioni);
            this.tabIntegrale.Controls.Add(this.lblIDivisioni);
            this.tabIntegrale.Controls.Add(this.groupIDisegna);
            this.tabIntegrale.Controls.Add(this.lblIXa);
            this.tabIntegrale.Controls.Add(this.lblIXb);
            this.tabIntegrale.Controls.Add(this.txrIXa);
            this.tabIntegrale.Controls.Add(this.txrIXb);
            this.tabIntegrale.Location = new System.Drawing.Point(4, 22);
            this.tabIntegrale.Name = "tabIntegrale";
            this.tabIntegrale.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntegrale.Size = new System.Drawing.Size(392, 296);
            this.tabIntegrale.TabIndex = 4;
            this.tabIntegrale.Text = "Integrale";
            this.tabIntegrale.UseVisualStyleBackColor = true;
            // 
            // btnIntegra
            // 
            this.btnIntegra.Location = new System.Drawing.Point(259, 207);
            this.btnIntegra.Name = "btnIntegra";
            this.btnIntegra.Size = new System.Drawing.Size(75, 23);
            this.btnIntegra.TabIndex = 7;
            this.btnIntegra.Text = "Integra";
            this.btnIntegra.UseVisualStyleBackColor = true;
            this.btnIntegra.Click += new System.EventHandler(this.DisegnaIntegrale);
            // 
            // numIDivisioni
            // 
            this.numIDivisioni.Location = new System.Drawing.Point(119, 109);
            this.numIDivisioni.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numIDivisioni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIDivisioni.Name = "numIDivisioni";
            this.numIDivisioni.Size = new System.Drawing.Size(120, 20);
            this.numIDivisioni.TabIndex = 5;
            this.numIDivisioni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIDivisioni
            // 
            this.lblIDivisioni.AutoSize = true;
            this.lblIDivisioni.Location = new System.Drawing.Point(54, 111);
            this.lblIDivisioni.Name = "lblIDivisioni";
            this.lblIDivisioni.Size = new System.Drawing.Size(49, 13);
            this.lblIDivisioni.TabIndex = 26;
            this.lblIDivisioni.Text = "Divisioni:";
            // 
            // groupIDisegna
            // 
            this.groupIDisegna.Controls.Add(this.checkTrap);
            this.groupIDisegna.Controls.Add(this.checkRetMin);
            this.groupIDisegna.Controls.Add(this.checkRetMag);
            this.groupIDisegna.Location = new System.Drawing.Point(57, 165);
            this.groupIDisegna.Name = "groupIDisegna";
            this.groupIDisegna.Size = new System.Drawing.Size(126, 88);
            this.groupIDisegna.TabIndex = 6;
            this.groupIDisegna.TabStop = false;
            this.groupIDisegna.Text = "Disegna";
            // 
            // checkTrap
            // 
            this.checkTrap.AutoSize = true;
            this.checkTrap.Location = new System.Drawing.Point(6, 65);
            this.checkTrap.Name = "checkTrap";
            this.checkTrap.Size = new System.Drawing.Size(61, 17);
            this.checkTrap.TabIndex = 2;
            this.checkTrap.Text = "Trapezi";
            this.checkTrap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTrap.UseVisualStyleBackColor = true;
            // 
            // checkRetMin
            // 
            this.checkRetMin.AutoSize = true;
            this.checkRetMin.Location = new System.Drawing.Point(6, 42);
            this.checkRetMin.Name = "checkRetMin";
            this.checkRetMin.Size = new System.Drawing.Size(105, 17);
            this.checkRetMin.TabIndex = 1;
            this.checkRetMin.Text = "Rettangoli Minori";
            this.checkRetMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkRetMin.UseVisualStyleBackColor = true;
            // 
            // checkRetMag
            // 
            this.checkRetMag.AutoSize = true;
            this.checkRetMag.Checked = true;
            this.checkRetMag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRetMag.Location = new System.Drawing.Point(6, 19);
            this.checkRetMag.Name = "checkRetMag";
            this.checkRetMag.Size = new System.Drawing.Size(117, 17);
            this.checkRetMag.TabIndex = 0;
            this.checkRetMag.Text = "Rettangoli Maggiori";
            this.checkRetMag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkRetMag.UseVisualStyleBackColor = true;
            // 
            // lblIXa
            // 
            this.lblIXa.AutoSize = true;
            this.lblIXa.Location = new System.Drawing.Point(54, 61);
            this.lblIXa.Name = "lblIXa";
            this.lblIXa.Size = new System.Drawing.Size(26, 13);
            this.lblIXa.TabIndex = 23;
            this.lblIXa.Text = "Xa: ";
            // 
            // lblIXb
            // 
            this.lblIXb.AutoSize = true;
            this.lblIXb.Location = new System.Drawing.Point(54, 87);
            this.lblIXb.Name = "lblIXb";
            this.lblIXb.Size = new System.Drawing.Size(26, 13);
            this.lblIXb.TabIndex = 24;
            this.lblIXb.Text = "Xb: ";
            // 
            // txrIXa
            // 
            this.txrIXa.Location = new System.Drawing.Point(119, 54);
            this.txrIXa.Name = "txrIXa";
            this.txrIXa.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrIXa.SafeText = "0";
            this.txrIXa.Size = new System.Drawing.Size(120, 20);
            this.txrIXa.TabIndex = 3;
            // 
            // txrIXb
            // 
            this.txrIXb.Location = new System.Drawing.Point(119, 80);
            this.txrIXb.Name = "txrIXb";
            this.txrIXb.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrIXb.SafeText = "5";
            this.txrIXb.Size = new System.Drawing.Size(120, 20);
            this.txrIXb.TabIndex = 4;
            // 
            // lblFunzione
            // 
            this.lblFunzione.AutoSize = true;
            this.lblFunzione.Location = new System.Drawing.Point(366, 17);
            this.lblFunzione.Name = "lblFunzione";
            this.lblFunzione.Size = new System.Drawing.Size(24, 13);
            this.lblFunzione.TabIndex = 7;
            this.lblFunzione.Text = "f(x):";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(762, 361);
            this.Controls.Add(this.lblFunzione);
            this.Controls.Add(this.TabPanFunzioni);
            this.Controls.Add(this.btnDisegna);
            this.Controls.Add(this.txtFunzione);
            this.Controls.Add(this.graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyGeoCoso";
            this.TabPanFunzioni.ResumeLayout(false);
            this.tabParametri.ResumeLayout(false);
            this.tabParametri.PerformLayout();
            this.tabBisezione.ResumeLayout(false);
            this.tabBisezione.PerformLayout();
            this.tabSecanti.ResumeLayout(false);
            this.tabSecanti.PerformLayout();
            this.tabTangenti.ResumeLayout(false);
            this.tabTangenti.PerformLayout();
            this.tabIntegrale.ResumeLayout(false);
            this.tabIntegrale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIDivisioni)).EndInit();
            this.groupIDisegna.ResumeLayout(false);
            this.groupIDisegna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mate.Graph.Graph graph;
        private Mate.TextRegex.TextRegex txrMaxX;
        private Mate.TextRegex.TextRegex txrMinX;
        private Mate.TextRegex.TextRegex txrMaxY;
        private Mate.TextRegex.TextRegex txrMinY;
        private Mate.TextRegex.TextRegex txrDelX;
        private Mate.TextRegex.TextRegex txrDelY;
        private System.Windows.Forms.TextBox txtFunzione;
        private System.Windows.Forms.Button btnDisegna;
        private System.Windows.Forms.TabControl TabPanFunzioni;
        private System.Windows.Forms.TabPage tabParametri;
        private System.Windows.Forms.Label lblFunzione;
        private System.Windows.Forms.Label lblDelY;
        private System.Windows.Forms.Label lblDelX;
        private System.Windows.Forms.Label lblMinY;
        private System.Windows.Forms.Label lblMaxY;
        private System.Windows.Forms.Label lblMinX;
        private System.Windows.Forms.Label lblMaxX;
        private System.Windows.Forms.Button btnSvuota;
        private System.Windows.Forms.TabPage tabBisezione;
        private System.Windows.Forms.Button btnBisezione;
        private System.Windows.Forms.Label lblBXa;
        private System.Windows.Forms.Label lblBXb;
        private System.Windows.Forms.Label lblBPrecisione;
        private System.Windows.Forms.Label lblBCicli;
        private Mate.TextRegex.TextRegex txrBXa;
        private Mate.TextRegex.TextRegex txrBXb;
        private Mate.TextRegex.TextRegex txrBPrecisione;
        private Mate.TextRegex.TextRegex txrBCicli;
        private System.Windows.Forms.TabPage tabSecanti;
        private System.Windows.Forms.Button btnSecante;
        private System.Windows.Forms.Label lblSXa;
        private System.Windows.Forms.Label lblSXb;
        private System.Windows.Forms.Label lblSPrecisione;
        private System.Windows.Forms.Label lblSCicli;
        private Mate.TextRegex.TextRegex txrSXa;
        private Mate.TextRegex.TextRegex txrSXb;
        private Mate.TextRegex.TextRegex txrSPrecisione;
        private Mate.TextRegex.TextRegex txrSCicli;
        private System.Windows.Forms.TabPage tabTangenti;
        private System.Windows.Forms.Button btnTengenti;
        private System.Windows.Forms.Label lblTXa;
        private System.Windows.Forms.Label lblTXb;
        private System.Windows.Forms.Label lblTPrecisione;
        private System.Windows.Forms.Label lblTCicli;
        private Mate.TextRegex.TextRegex txrTXa;
        private Mate.TextRegex.TextRegex txrTXb;
        private Mate.TextRegex.TextRegex txrTPrecisione;
        private Mate.TextRegex.TextRegex txrTCicli;
        private System.Windows.Forms.TabPage tabIntegrale;
        private System.Windows.Forms.Label lblIXa;
        private System.Windows.Forms.Label lblIXb;
        private Mate.TextRegex.TextRegex txrIXa;
        private Mate.TextRegex.TextRegex txrIXb;
        private System.Windows.Forms.GroupBox groupIDisegna;
        private System.Windows.Forms.CheckBox checkTrap;
        private System.Windows.Forms.CheckBox checkRetMin;
        private System.Windows.Forms.CheckBox checkRetMag;
        private System.Windows.Forms.NumericUpDown numIDivisioni;
        private System.Windows.Forms.Label lblIDivisioni;
        private System.Windows.Forms.Button btnIntegra;
    }
}

