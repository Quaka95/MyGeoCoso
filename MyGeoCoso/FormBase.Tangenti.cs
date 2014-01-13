using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Mate.Graph;
using info.lundin.math;

namespace MyGeoCoso
{
    public partial class FormBase
    {
        private bool PrelevaTagente()
        {
            //Variabili
            bool status = true; //La variabile conferma che tutti i parametri erano corretti
            double outer = 0;   //Variabile per l'estrazione dei valori
            int iouter = 0;  //Variabile per l'estrazione dei valori interi

            //Integrità digitazione
            txrSXa.SafeText = txrSXa.SafeText.Replace('.', ',');
            txrSXb.SafeText = txrSXb.SafeText.Replace('.', ',');
            txrSCicli.SafeText = txrSCicli.SafeText.Replace('.', ',');
            txrSPrecisione.SafeText = txrSPrecisione.SafeText.Replace('.', ',');

            //Preleva dati
            tpar.Funzione = par.Funzione;

            if (double.TryParse(txrTXa.SafeText, out outer)) tpar.A = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore di A non valido", "Valore non valido");
            }

            if (double.TryParse(txrTXb.SafeText, out outer)) tpar.B = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore di B non valido", "Valore non valido");
            }

            if (int.TryParse(txrTCicli.SafeText, out iouter) && iouter > 0) tpar.Cicli = iouter; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore dei cicli non valido", "Valore non valido");
            }

            if (double.TryParse(txrTPrecisione.SafeText, out outer)) tpar.Precisione = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Precision della Bisezione non valida", "Valore non valido");
            }

            return status;
        }   //Preleva i dati dalla form e ne controlla tutti i valori

        private void DisegnaTagenti(object sender, EventArgs e)
        {
            tpar.Clear();   //Ripulisco i parametri
            if (_disegnato && PrelevaTagente())   //Se vi è una funzione rappresentata e tutti i dati sono presi correttamente
            {
                int n = 0;  //Contatore
                bool individuato = false;   //Indica se ho potuto fare almeno una rilevazione

                do
                {
                    tpar.Elabora(); //Elabora il calcolo della tangente
                    if (!double.IsInfinity(tpar.X)) //Se è possibile trovare una coincidenza fra la tangente e l'asse delle ascisse 
                    {
                        DisegnaPunto(tpar.A, tpar.Fa, Color.DarkRed);   //Disegno A
                        DisegnaPunto(tpar.B, tpar.Fb, Color.DarkRed);   //Disegno B
                        DisegnaTangente(Color.Blue);    //Disegno tangente presente fra i parametri
                        DisegnaPunto(tpar.X, tpar.Fx, Color.Green); //Disegno punto X sulla funzione
                        DisegnaPunto(tpar.X, 0, Color.Yellow);  //Disegno punto X sulle ascisse
                        individuato = true; //Individuato punto

                        tpar.A = tpar.X;    //Pongo X ad A
                    }
                    n++; //Prossimo giro
                } while (n < tpar.Cicli && ((tpar.Fx <= (-(tpar.Precisione))) || (tpar.Fx >= tpar.Precisione)));   //Fino a quando: (l'indice non supera il numero di giri) E (La funzione di C è compresa nella precisione maggiore o minore di zero)

                if (n < tpar.Cicli) //Se esco per la precisione
                {
                    DisegnaPunto(tpar.X, tpar.Fx, Color.Green); //Rappresenta l'ultimo punto con uscita per precisione
                    individuato = true; //Individuato punto
                }

                if (individuato)    //Determina se è stat individuato almeno un punto
                {
                    MessageBox.Show("Il punto più vicino f(x)=0 è:\nC(" + tpar.X + "," + tpar.Fx + ")", "Risultato");
                }
                else
                {
                    Errore("Il range inserito non porta a nessun risultato", "Range Errato");
                }
            }

            if (!_disegnato)    //Se non è disegnato nulla
            {
                Errore("Rappresentare almeno una funzione", "Errore Funzione");
            }
        }   //Esegue il metodo Newtoniano

        private void DisegnaTangente(Color colore)
        {
            try
            {
                graph._drawFunction(tpar.Tangente, 500, new Pen(colore, 1f));   //Disegno la funzione con precisione di 500 punti e penna color rosso scuro
            }
            catch (Exception e) { } //Nonostante le innumerevoli prove, non sono riuscito a individuare il tipo di eccezione
        }   //Disegna la tangente in tpar
    }

    /// <summary>
    /// Descrive i parametri  per eseguire il calcolo delle tangenti
    /// </summary>
    public class TagentiParametr
    {
        //Campi
        private double _a;
        private double _b;
        private double _fa;
        private double _fb;
        private double _inc;
        private double _q;
        private double _m;
        private string _tan;
        private double _x;
        private double _fx;
        private ExpressionParser _parser;
        private string _funzione;
        private double _precisione;
        private int _cicli;

        //Costruttore
        public TagentiParametr()
        {
            Clear();    //setta il default
        }

        //Proprietà
        /// <summary>
        /// Punto A del Range
        /// </summary>
        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                if (!string.IsNullOrWhiteSpace(this.Funzione))
                {
                    _fa = fx(_a);
                }
            }
        }

        /// <summary>
        /// Punto B del Range
        /// </summary>
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
                if (!string.IsNullOrWhiteSpace(this.Funzione))
                {
                    _fb = fx(_b);
                }
            }
        }

        /// <summary>
        /// Corrisponde al valore di A nella funzione
        /// </summary>
        public double Fa
        {
            get { return _fa; }
        }

        /// <summary>
        /// Corrisponde al valore di B nella funzione
        /// </summary>
        public double Fb
        {
            get { return _fb; }
        }

        /// <summary>
        /// Funzione da cui si ricavano i valori
        /// </summary>
        public string Funzione
        {
            get { return _funzione; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _funzione = value;
                    this.A = this.A;
                    this.B = this.B;
                }
            }
        }

        /// <summary>
        /// Riporta la funzione che rappresenta la tangente al punto A
        /// </summary>
        public string Tangente
        {
            get { return _tan; }
        }

        /// <summary>
        /// Valore della retta secante in Y=0
        /// </summary>
        public double X
        {
            get { return _x; }
        }

        /// <summary>
        /// Valore della retta secante in Y=0 sulla funzione
        /// </summary>
        public double Fx
        {
            get { return _fx; }
        }

        /// <summary>
        /// Precisione
        /// </summary>
        public double Precisione
        {
            get { return _precisione; }
            set { _precisione = value; }
        }

        /// <summary>
        /// Numero di cicli
        /// </summary>
        public int Cicli
        {
            get { return _cicli; }
            set { _cicli = value; }
        }

        //Metodi
        /// <summary>
        /// Pulisce i parametri
        /// </summary>
        public void Clear()
        {
            _a = 0; //Settaggio di default delle variabili
            _b = 0;
            _fa = 0;
            _fb = 0;
            _inc = 0;
            _tan = "";
            _x = 0;
            _parser = new ExpressionParser();
            _funzione = "";
            _precisione = 0;
            _cicli = 0;
        }

        /// <summary>
        /// La funzione esegue i calcoli necessari a individuare gli elementi per il calcolo della tangente
        /// </summary>
        public void Elabora()
        {
            _inc = RapportoIncrementale();  //Calcolo il rapporto incrementale
            _x = (((_a * _inc) - _fa) / _inc);  //Derivo la coordinata delle Ascisse del punto della funzione con ordinate a 0
            _fx = fx(_x);   //Calcolo la x sulla funzione
            _tan = _inc + "x -(" + (_inc *_a) + ")+(" + _fa + ")";  //Descivo la funzione che rappresenta la funzione al punto
        }

        private double RapportoIncrementale()
        {
            double h = 0.0000000001d;   //Indica una h→0
            double fxh = fx(_a + h);    //Uso una variabile di supporto per il controllo nel DEBUG
            return (fxh - _fa) / h;  //Vedi gli appunti in fondo
        }   //Calcola il rapporto incrementale in un punto

        private double fx(double x) //Funzione per il calcolo del valore di una variabile in un punto
        {
            Hashtable table = new Hashtable();  //Creo una HashTable

            table.Add("x", x.ToString());   //imposto in X il valore da determinare
            table.Add("e", Math.E.ToString());  //imposto in e il numero di Nepero

            return _parser.Parse(_funzione, table); //Calcolo il valore di x nella funzione
        }
    }
}

/*///////////// APPUNTI MATEMATICI --- ROBA DA SECCHIONE /////////////////////
//                                                                          //
//         Questo commento contiene la riflessione per le tangenti          //
//                                                                          //
//                                                                          //
//            Per cominciare partiamo dalla forumla di una retta            //
//                        passante per un punto:                            //
//                                                                          //
//                                                                          //
//                         Y-Yb = f'(Xb) (X-Xb)                             //
//                                                                          //
//                                                                          //
/         a questo punto possiamo isolare l'elemento X dal resto con        //
//                                                                          //
//                                                                          //
//                              Xb * f'(Xb) - Yb                            //
//                         X = -------------------                          //
//                                  f'(Xb)                                  //
//                                                                          //
//                                                                          //
////////////////////////////////////////////////////////////////////////////*/
