using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGeoCoso
{
    public partial class FormBase
    {
        //Funzioni di gestione
        private void DisegnaClick(object sender, EventArgs e)
        {
            if (PrelevaParametri()) //Se tutti i parametri sono letti correttamente disegna
            {
                DisegnaBackground();
                DisegnaFunzione();
            }   
        }

        private void PulisciGrafico(object sender, EventArgs e)
        {
            par = new GraphParametr();
            graph._clearAll();
            DisegnaBackground();
            _disegnato = false;
        }   //Ripulisce il grafico e lo riporta allo stato iniziale

        private void ControlloMinuscolo(object sender, EventArgs e)
        {
            int pos = txtFunzione.SelectionStart;   //Ottiene posizion puntatore
            txtFunzione.Text = txtFunzione.Text.ToLower(System.Globalization.CultureInfo.CurrentCulture);   //Mette in minuscolo tenendo conto delle regole grammaticali della lingua del computer
            txtFunzione.SelectionStart = pos;   //Reimposta la posizione del puntatore
        }   //Controlla che la funzione immessa sia minuscola

        private void DisegnaBackground()
        {
            graph._xMax = par.MaxX; //Imposto i valori degli assi
            graph._xMin = par.MinX;
            graph._yMax = par.MaxY;
            graph._yMin = par.MinY;

            graph._drawAxis(par.Assi);  //Richiamo la funzione per disegnare il grafico

            graph._drawGridFixed(par.DeltaX, par.DeltaY, par.Griglia); //Richiamo funzione per il disegno della griglia
        }   //Funzione per il disegno di assi e griglia

        private bool PrelevaParametri()
        {
            //Variabili
            bool status = true; //La variabile conferma che tutti i parametri erano corretti
            double outer = 0;   //Variabile per l'estrazione dei valori

            //Integrità dati
            txrMaxX.SafeText = txrMaxX.SafeText.Replace('.', ',');  //Il parser legge solo i valori con la ','
            txrMinX.SafeText = txrMinX.SafeText.Replace('.', ',');
            txrMaxY.SafeText = txrMaxY.SafeText.Replace('.', ',');
            txrMinY.SafeText = txrMinY.SafeText.Replace('.', ',');
            txrDelX.SafeText = txrDelX.SafeText.Replace('.', ',');
            txrDelY.SafeText = txrDelY.SafeText.Replace('.', ',');
            
            //Estrazione dati
            if (!string.IsNullOrWhiteSpace(txtFunzione.Text)) par.Funzione = txtFunzione.Text;  //Controllo che la funzione non sia vuota, posta a null o con soli spazzi e assegno il suo valore
            else
            {
                MessageBox.Show("La funzione è vuota o contenete carratteri non validi", "Funzione Errata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (double.TryParse(txrMaxX.SafeText, out outer)) par.MaxX = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore Massimo delle Ascisse errato", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;  
            }

            if (double.TryParse(txrMinX.SafeText, out outer)) par.MinX = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore Minimo delle Ascisse errato", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (double.TryParse(txrMaxY.SafeText, out outer)) par.MaxY = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore Massimo delle Ordinate errato", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (double.TryParse(txrMinY.SafeText, out outer)) par.MinY = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore Minimo delle Ordinate errato", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (double.TryParse(txrDelX.SafeText, out outer)) par.DeltaX = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore di distanza nella griglia relativo alle Ascisse","Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (double.TryParse(txrDelY.SafeText, out outer)) par.DeltaY = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore di distanza nella griglia relativo alle Ordinate", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            //Controllo Integrità valori
            if (status) //Controllo che i minori siano realmente minori
            {
                if (par.MinX >= par.MaxX)
                {
                    MessageBox.Show("Il valore Massimo e il Minimo delle ascisse non sono corretti", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //In questa maniera evitiamo l'eccezione
                    status = false;
                }

                if (par.MinY >= par.MaxY)
                {
                    MessageBox.Show("Il valore Massimo e il Minimo delle ordinate non sono corretti", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    status = false;
                }
            }

            return status;
        }   //Funzione per l'estrazione dei parametri

        private void DisegnaFunzione()  //Disegna la funzione
        {
            try
            {
                graph._drawFunction(par.Funzione, 500, new Pen(Color.DarkRed, 1f));   //Disegno la funzione con precisione di 500 punti e penna color rosso scuro
                _disegnato = true;
            }
            catch (Exception e) { } //Nonostante le innumerevoli prove, non sono riuscito a individuare il tipo di eccezione
        }
    }

    //Classe contente i parametri
    public class GraphParametr
    {
        //Parametri
        private string _Funz;
        private double _Xmax;
        private double _Xmin;
        private double _Ymax;
        private double _Ymin;
        private double _Xdel;
        private double _Ydel;
        private Pen _Assi;
        private Pen _Griglia;

        //Costruttore
        public GraphParametr() {    //Setto i parametri secondo i valori di base
            this.Funzione = "0";
            this.MaxX = 10d;
            this.MinX = -10d;
            this.MaxY = 10d;
            this.MinY = -10d;
            this.DeltaX = 1d;
            this.DeltaY = 1d;

            //Default Penne
            _Assi = new Pen(Color.Black, 1.8f);
            _Griglia = new Pen(Color.Gray, 0.8f);
        }

        //Proprietà
        /// <summary>
        /// Testo della funzione
        /// </summary>
        public string Funzione
        {
            get { return _Funz; }
            set { if (!string.IsNullOrWhiteSpace(value))_Funz = value; }
        }

        /// <summary>
        /// Valore massimo Asse X
        /// </summary>
        public double MaxX
        {
            get { return _Xmax; }
            set { _Xmax = value; }
        }

        /// <summary>
        /// Valore massimo Asse Y
        /// </summary>
        public double MaxY
        {
            get { return _Xmin; }
            set { _Xmin = value; }
        }

        /// <summary>
        /// Valore minimo Asse X
        /// </summary>
        public double MinX
        {
            get { return _Ymax; }
            set { _Ymax = value; }
        }

        /// <summary>
        /// Valore minimo Asse Y
        /// </summary>
        public double MinY
        {
            get { return _Ymin; }
            set { _Ymin = value; }
        }

        /// <summary>
        /// Valore di grandezza per la griglia nell'esperessione delle ascisse
        /// </summary>
        public double DeltaX
        {
            get { return _Xdel; }
            set { _Xdel = value; }
        }

        /// <summary>
        /// Valore di grandezza per la griglia nell'esperessione delle ordinate
        /// </summary>
        public double DeltaY
        {
            get { return _Ydel; }
            set { _Ydel = value; }
        }

        /// <summary>
        /// Penna per il disegno della griglia
        /// </summary>
        public Pen Griglia
        {
            get { return _Griglia; }
            set { if (value != null)_Griglia = value; }
        }

        /// <summary>
        /// Penna per il disegno degli assi
        /// </summary>
        public Pen Assi
        {
            get { return _Assi; }
            set { if (value != null)_Assi = value; }
        }
    }
}
