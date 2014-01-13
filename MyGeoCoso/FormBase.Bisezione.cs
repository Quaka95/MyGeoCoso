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
        private void DisegnaBisezione(object sender, EventArgs e)
        {
            bpar.Clear();
            if (_disegnato && PrelevaBisezione())   //Se vi è una funzione rappresentata e tutti i dati sono presi correttamente
            {
                int n = 0;  //Contatore
                bool individuato = false;   //Indica se nel range si può eseguire almeno una rilevazione

                while (n < bpar.Cicli && ((bpar.Fc <= (-(bpar.Precisione))) || (bpar.Fc >= bpar.Precisione)))   //Fino a quando: (l'indice non supera il numero di giri) E (La funzione di C è compresa nella precisione maggiore o minore di zero)
                {
                    bpar.C = (bpar.A + bpar.B) / 2; //Trovo il punto medio
                    DisegnaPunto(bpar.A, bpar.Fa, Color.Red);   //Disegno il punto A
                    DisegnaPunto(bpar.B, bpar.Fb, Color.Red);   //Disegno il punto B

                    if (Discordi(bpar.Fa, bpar.Fc)) //Se A e C discordi
                    {
                        individuato = true; //Ho trovato qualcosa
                        bpar.B = bpar.C;    //C diventa B
                        DisegnaPunto(bpar.C, bpar.Fc, Color.Green); //Disegno C
                    }
                    else
                    {
                        if (Discordi(bpar.Fb, bpar.Fc)) //Se A e C discordi
                        {
                            individuato = true; //Ho trovato qualcosa
                            bpar.A = bpar.C;    //C diventa A
                            DisegnaPunto(bpar.C, bpar.Fc, Color.Green); //Disegno C
                        }
                    }

                    n++;    //Prossimo giro
                }

                if (n < bpar.Cicli) //Se ho raggiunto la precisione
                {
                    DisegnaPunto(bpar.C, bpar.Fc, Color.Green); //Rappresenta l'ultimo punto con uscita per precisione
                    individuato = true; //Indico che ho comunque trovato qualcosa
                }

                if (individuato)    //Se ho trovato qualcosa
                {
                    MessageBox.Show("Il punto più vicino f(x)=0 è:\nC(" + bpar.C + "," + bpar.Fc + ")","Risultato");
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
        }   //Esegue il metodo della Bissezione

        private bool PrelevaBisezione()
        {
            //Variabili
            bool status = true; //La variabile conferma che tutti i parametri erano corretti
            double outer = 0;   //Variabile per l'estrazione dei valori
            int iouter = 0;  //Variabile per l'estrazione dei valori interi

            //Integrità digitazione
            txrBXa.SafeText = txrBXa.SafeText.Replace('.',',');
            txrBXb.SafeText = txrBXb.SafeText.Replace('.',',');
            txrBCicli.SafeText = txrBCicli.SafeText.Replace('.', ',');
            txrBPrecisione.SafeText = txrBPrecisione.SafeText.Replace('.', ',');

            //Preleva dati
            bpar.Funzione = par.Funzione;

            if (double.TryParse(txrBXa.SafeText, out outer)) bpar.A = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore di A non valido", "Valore non valido");
            }

            if (double.TryParse(txrBXb.SafeText, out outer)) bpar.B = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore di B non valido", "Valore non valido");
            }

            if (int.TryParse(txrBCicli.SafeText, out iouter) && iouter>0) bpar.Cicli = iouter; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore dei cicli non valido", "Valore non valido");
            }

            if (double.TryParse(txrBPrecisione.SafeText, out outer)) bpar.Precisione = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Precision della Bisezione non valida", "Valore non valido");
            }

            return status;
        }   //Preleva i dati dalla form e ne controlla tutti i valori

        private bool Discordi(double xa, double xb,bool calcola=false) 
        {
            if (calcola)    //Se impostato a true calcola i valori
            {
                xa = fx(xa, txtFunzione.Text);   //Derivo i valori nella funzione
                xb = fx(xb, txtFunzione.Text);
            }

            return ((xa * xb) <= 0);//Se il prodotto è minore di zero sono discordi
        }   //La funzione determina se i due numeri forniti sono discordi

        private void DisegnaPunto(double x, double y,Color colore) 
        {
            graph._drawPoint(x, y, GraphPointSize.Small, GraphPointStyle.Circle, colore);
        }   //Disegna un punto

        private bool Errore(string message,string titolo)
        {
            MessageBox.Show(message, titolo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
    }

    /// <summary>
    /// Rappresenta i parametri per il metodo della bissezione
    /// </summary>
    public class BisezioneParametr
    {
        //Parametri
        private double _a;
        private double _b;
        private double _c;
        private double _fa;
        private double _fb;
        private double _fc;
        private double _precisione;
        private int _cicli;
        private string _funzione;
        private ExpressionParser _parser;

        //Costruttore
        public BisezioneParametr()
        {
            Clear(); //Inizializzo
        }

        //Proprietà
        /// <summary>
        /// Imposta il valore A
        /// </summary>
        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                if (!string.IsNullOrWhiteSpace(this.Funzione))
                {
                    _fa = fx(_a, _funzione);
                }
            }
        }

        /// <summary>
        /// Imposta il valore B
        /// </summary>
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
                if (!string.IsNullOrWhiteSpace(this.Funzione))
                {
                    _fb = fx(_b, _funzione);
                }
            }
        }

        /// <summary>
        /// Imposta il valore C
        /// </summary>
        public double C
        {
            get { return _c; }
            set
            {
                _c = value;
                if (!string.IsNullOrWhiteSpace(this.Funzione))
                {
                    _fc = fx(_c, _funzione);
                }
            }
        }

        /// <summary>
        /// Contiene il valore di A nella funzione
        /// </summary>
        public double Fa
        {
            get { return _fa; }
        }

        /// <summary>
        /// Contiene il valore di B nella funzione
        /// </summary>
        public double Fb
        {
            get { return _fb; }
        }

        /// <summary>
        /// Contiene il valore di C nella funzione
        /// </summary>
        public double Fc
        {
            get { return _fc; }
        }

        /// <summary>
        /// Indica la precisione con cui il valore deve avvicinarsi
        /// </summary>
        public double Precisione
        {
            get { return _precisione; }
            set { _precisione = value; }
        }

        /// <summary>
        /// Indica il numero di cicli che l'operazione deve initerare
        /// </summary>
        public int Cicli
        {
            get { return _cicli; }
            set { _cicli = value; }
        }

        /// <summary>
        /// Funzione con cui si ricavano i valori delle Funzioni
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
                    this.C = this.C;
                }
            }
        }

        //Metodi
        private double fx(double x, string f)   //Funzione per il calcolo del valore di una variabile in un punto
        {
            Hashtable table = new Hashtable();  //Creo una HashTable

            table.Add("x", x.ToString());   //imposto in X il valore da determinare
            table.Add("e", Math.E.ToString());  //imposto in e il numero di Nepero

            return _parser.Parse(f, table); //Calcolo il valore di x nella funzione
        }

        /// <summary>
        /// Ripulisce i dati
        /// </summary>
        public void Clear()
        {
            _a = 0; //Valori di default
            _b = 0;
            _c = 0;
            _fa = 0;
            _fb = 0;
            _fc = 0;
            _precisione = 0;
            _cicli = 0;
            _funzione = "";
            _parser = new ExpressionParser();
        }
    }
}
