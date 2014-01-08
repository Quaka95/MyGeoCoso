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
        private bool PrelevaSecanti()
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
            spar.Funzione = par.Funzione;

            if (double.TryParse(txrSXa.SafeText, out outer)) spar.A = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore di A non valido", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (double.TryParse(txrSXb.SafeText, out outer)) spar.B = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore di B non valido", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (int.TryParse(txrSCicli.SafeText, out iouter) && iouter > 0) spar.Cicli = iouter; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Valore dei cicli non valido", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            if (double.TryParse(txrSPrecisione.SafeText, out outer)) spar.Precisione = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                MessageBox.Show("Precision della Bisezione non valida", "Valore non valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                status = false;
            }

            return status;
        }   //Preleva i dati dalla form e ne controlla tutti i valori

        private void DisegnaSecante(object sender, EventArgs e)
        {
            if (_disegnato && PrelevaSecanti())   //Se vi è una funzione rappresentata e tutti i dati sono presi correttamente
            {
                int n = 0;
                bool individuato = false;

                while (n < spar.Cicli && ((spar.Fx <= (-(bpar.Precisione))) || (spar.Fx >= bpar.Precisione)))   //Fino a quando: (l'indice non supera il numero di giri) E (La funzione di C è compresa nella precisione maggiore o minore di zero)
                {
                    if (Discordi(spar.Fa, spar.Fb))
                    {
                        spar.Elabora();
                        DisegnaSecante(Color.Blue);

                        if (Discordi(spar.Fa, spar.Fx))
                        {
                            DisegnaPunto(spar.X, spar.Fx, Color.Green);
                            individuato = true;
                            spar.B = spar.X;
                        }
                        if (Discordi(spar.Fb, spar.Fx))
                        {
                            DisegnaPunto(spar.X, spar.Fx, Color.Green);
                            individuato = true;
                            spar.A = spar.X;
                        }
                    }
                    n++;
                }

                if (n < bpar.Cicli)
                {
                    DisegnaPunto(spar.X, spar.Fx, Color.Green); //Rappresenta l'ultimo punto con uscita per precisione
                    individuato = true;
                }

                if (individuato)
                {
                    MessageBox.Show("Il punto più vicino f(x)=0 è:\nC(" + spar.X + "," + spar.Fx + ")", "Risultato");
                }
                else
                {
                    MessageBox.Show("Il range inserito non porta a nessun risultato", "Range Errato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void DisegnaSecante(Color colore)
        {
            try
            {
                graph._drawFunction(spar.Secante, 500, new Pen(colore, 1f));   //Disegno la funzione con precisione di 500 punti e penna color rosso scuro
            }
            catch (Exception e) { } //Nonostante le innumerevoli prove, non sono riuscito a individuare il tipo di eccezione
        }
    }

    public class SecantiParametr
    {
        //Campi
        private double _a;
        private double _b;
        private double _fa;
        private double _fb;
        private double _q;
        private double _m;
        private string _retta;
        private double _x;
        private double _fx;
        private ExpressionParser _parser;
        private string _funzione;
        private double _precisione;
        private int _cicli;

        //Costruttore
        public SecantiParametr()
        {
            _a = 0; //Settaggio di default delle variabili
            _b = 0;
            _fa = 0;
            _fb = 0;
            _q = 0;
            _m = 0;
            _retta = "";
            _x = 0;
            _parser = new ExpressionParser();
            _funzione = "";
            _precisione = 0;
            _cicli = 0;
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
        /// Retta secante ad A e B
        /// </summary>
        public string Secante
        {
            get { return _retta; }
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
        public void Elabora()
        {
            _q = q();
            _m = m();
            _x = (-(_q)) / _m;  //Vedi appunto in fondo
            _fx = fx(_x);   //X sulla funzione
            _retta = "(x*" + _m + ")+" + _q;
        }   //Metodo che elabora la retta secante

        private double fx(double x) //Funzione per il calcolo del valore di una variabile in un punto
        {
            Hashtable table = new Hashtable();  //Creo una HashTable

            table.Add("x", x.ToString());   //imposto in X il valore da determinare
            table.Add("e", Math.E.ToString());  //imposto in e il numero di Nepero

            return _parser.Parse(_funzione, table); //Calcolo il valore di x nella funzione
        }

        private double q()
        {
            return -(((_a * (_fb - _fa)) / (_b - _a)) + _fa);
        }   //Deriva la q della secante, mediante la formula riportata sotto

        private double m()
        {
            return (_fb - _fa) / (_b - _a);
        }   //Deriva la m della secante, mediante la formula sotto riportata
    }
}

/*///////////// APPUNTI MATEMATICI --- ROBA DA SECCHIONE /////////////////////
//                                                                          //
//         Questo commento contiene la riflessione per le secanti           //
//                                                                          //
//                                                                          //
//              Data una retta, se sappiamo che r: y=xm+q                   //
//                                   allora:                                //
//                                                                          //
//                  0 = xm+q     quindi     x = -q/m                        //
//                                                                          //
//      Se partiamo dalla formula della retta passante per 2 punti          //
//                                                                          //
//                                                                          //
//                            Y-Y1     X-X1                                 //
//                           ------ _ ------                                //
//                            X2-X1    X2-X1                                //
//                                                                          //
//                                                                          //
//                          Allora arriviamo a                              //
//                                                                          //
//                                                                          //
//                   X1(y2-y1)                                              //
//                  ---------- -Y1                                          //
//                     X2-X1                                                //
//            X=-----------------------        A=x1,f(A)=Y1                 //
//                      Y2-Y1                  B=x2,f(B)=Y2                 //
//                     -------                                              //
//                      X2-x1                                               //
//                                                                          //
////////////////////////////////////////////////////////////////////////////*/