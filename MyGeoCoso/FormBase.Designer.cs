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
            this.tabBase = new System.Windows.Forms.TabControl();
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
            this.lblFunzione = new System.Windows.Forms.Label();
            this.tabBase.SuspendLayout();
            this.tabParametri.SuspendLayout();
            this.tabBisezione.SuspendLayout();
            this.tabSecanti.SuspendLayout();
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
            // 
            // txtFunzione
            // 
            this.txtFunzione.Location = new System.Drawing.Point(396, 14);
            this.txtFunzione.Name = "txtFunzione";
            this.txtFunzione.Size = new System.Drawing.Size(273, 20);
            this.txtFunzione.TabIndex = 7;
            this.txtFunzione.Text = "e^(x)-x^(2)";
            this.txtFunzione.TextChanged += new System.EventHandler(this.ControlloMinuscolo);
            // 
            // btnDisegna
            // 
            this.btnDisegna.Location = new System.Drawing.Point(675, 12);
            this.btnDisegna.Name = "btnDisegna";
            this.btnDisegna.Size = new System.Drawing.Size(75, 23);
            this.btnDisegna.TabIndex = 8;
            this.btnDisegna.Text = "Disegna";
            this.btnDisegna.UseVisualStyleBackColor = true;
            this.btnDisegna.Click += new System.EventHandler(this.DisegnaClick);
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.tabParametri);
            this.tabBase.Controls.Add(this.tabBisezione);
            this.tabBase.Controls.Add(this.tabSecanti);
            this.tabBase.HotTrack = true;
            this.tabBase.Location = new System.Drawing.Point(362, 38);
            this.tabBase.Name = "tabBase";
            this.tabBase.SelectedIndex = 0;
            this.tabBase.Size = new System.Drawing.Size(400, 322);
            this.tabBase.TabIndex = 9;
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
            this.btnSvuota.TabIndex = 10;
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
            this.txrMaxX.TabIndex = 1;
            // 
            // txrMinX
            // 
            this.txrMinX.Location = new System.Drawing.Point(113, 76);
            this.txrMinX.Name = "txrMinX";
            this.txrMinX.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrMinX.SafeText = "-10";
            this.txrMinX.Size = new System.Drawing.Size(154, 20);
            this.txrMinX.TabIndex = 2;
            // 
            // txrMaxY
            // 
            this.txrMaxY.Location = new System.Drawing.Point(113, 118);
            this.txrMaxY.Name = "txrMaxY";
            this.txrMaxY.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrMaxY.SafeText = "10";
            this.txrMaxY.Size = new System.Drawing.Size(154, 20);
            this.txrMaxY.TabIndex = 3;
            // 
            // txrDelY
            // 
            this.txrDelY.Location = new System.Drawing.Point(113, 243);
            this.txrDelY.Name = "txrDelY";
            this.txrDelY.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrDelY.SafeText = "1";
            this.txrDelY.Size = new System.Drawing.Size(154, 20);
            this.txrDelY.TabIndex = 6;
            // 
            // txrMinY
            // 
            this.txrMinY.Location = new System.Drawing.Point(113, 160);
            this.txrMinY.Name = "txrMinY";
            this.txrMinY.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrMinY.SafeText = "-10";
            this.txrMinY.Size = new System.Drawing.Size(154, 20);
            this.txrMinY.TabIndex = 4;
            // 
            // txrDelX
            // 
            this.txrDelX.Location = new System.Drawing.Point(113, 202);
            this.txrDelX.Name = "txrDelX";
            this.txrDelX.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrDelX.SafeText = "1";
            this.txrDelX.Size = new System.Drawing.Size(154, 20);
            this.txrDelX.TabIndex = 5;
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
            this.btnBisezione.TabIndex = 10;
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
            this.txrBXa.SafeText = "-1";
            this.txrBXa.Size = new System.Drawing.Size(120, 20);
            this.txrBXa.TabIndex = 14;
            // 
            // txrBXb
            // 
            this.txrBXb.Location = new System.Drawing.Point(183, 80);
            this.txrBXb.Name = "txrBXb";
            this.txrBXb.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrBXb.SafeText = "0";
            this.txrBXb.Size = new System.Drawing.Size(120, 20);
            this.txrBXb.TabIndex = 15;
            // 
            // txrBPrecisione
            // 
            this.txrBPrecisione.Location = new System.Drawing.Point(183, 128);
            this.txrBPrecisione.Name = "txrBPrecisione";
            this.txrBPrecisione.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrBPrecisione.SafeText = "0,01";
            this.txrBPrecisione.Size = new System.Drawing.Size(120, 20);
            this.txrBPrecisione.TabIndex = 16;
            // 
            // txrBCicli
            // 
            this.txrBCicli.Location = new System.Drawing.Point(183, 154);
            this.txrBCicli.Name = "txrBCicli";
            this.txrBCicli.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrBCicli.SafeText = "5";
            this.txrBCicli.Size = new System.Drawing.Size(120, 20);
            this.txrBCicli.TabIndex = 17;
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
            this.btnSecante.TabIndex = 19;
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
            this.txrSXa.SafeText = "-1";
            this.txrSXa.Size = new System.Drawing.Size(120, 20);
            this.txrSXa.TabIndex = 23;
            // 
            // txrSXb
            // 
            this.txrSXb.Location = new System.Drawing.Point(183, 80);
            this.txrSXb.Name = "txrSXb";
            this.txrSXb.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrSXb.SafeText = "0";
            this.txrSXb.Size = new System.Drawing.Size(120, 20);
            this.txrSXb.TabIndex = 24;
            // 
            // txrSPrecisione
            // 
            this.txrSPrecisione.Location = new System.Drawing.Point(183, 128);
            this.txrSPrecisione.Name = "txrSPrecisione";
            this.txrSPrecisione.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrSPrecisione.SafeText = "0,01";
            this.txrSPrecisione.Size = new System.Drawing.Size(120, 20);
            this.txrSPrecisione.TabIndex = 25;
            // 
            // txrSCicli
            // 
            this.txrSCicli.Location = new System.Drawing.Point(183, 154);
            this.txrSCicli.Name = "txrSCicli";
            this.txrSCicli.Regex = "[-+]?[0-9]*[.|,]?[0-9]*";
            this.txrSCicli.SafeText = "5";
            this.txrSCicli.Size = new System.Drawing.Size(120, 20);
            this.txrSCicli.TabIndex = 26;
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
            this.Controls.Add(this.tabBase);
            this.Controls.Add(this.btnDisegna);
            this.Controls.Add(this.txtFunzione);
            this.Controls.Add(this.graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyGeoCoso";
            this.tabBase.ResumeLayout(false);
            this.tabParametri.ResumeLayout(false);
            this.tabParametri.PerformLayout();
            this.tabBisezione.ResumeLayout(false);
            this.tabBisezione.PerformLayout();
            this.tabSecanti.ResumeLayout(false);
            this.tabSecanti.PerformLayout();
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
        private System.Windows.Forms.TabControl tabBase;
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
    }
}

