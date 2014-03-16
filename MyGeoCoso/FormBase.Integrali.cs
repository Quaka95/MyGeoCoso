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
        private void DisegnaIntegrale(object sender, EventArgs e)
        {
            ipar.Clear();
            if (_disegnato && PrelevaIntegrale())
            {
                if (ipar.RettangoliMaggiori || ipar.RettangoliMinori || ipar.Trapezii)
                {
                    double iretMax = -1d;
                    double iretMin = -1d;
                    double itrap = -1d;
                }
                else
                {
                    Errore("Nessun metodo per il calcolo dell'integrale selezionato","Errore Selezione");
                }
            }

            if (!_disegnato)    //Se non è disegnato nulla
            {
                Errore("Rappresentare almeno una funzione", "Errore Funzione");
            }
        }

        private bool PrelevaIntegrale()
        {
            //Variabili
            bool status = true; //La variabile conferma che tutti i parametri erano corretti
            double outer = 0;   //Variabile per l'estrazione dei valori
            int iouter = 0;  //Variabile per l'estrazione dei valori interi

            //Integrità digitazione
            txrIXa.SafeText = txrIXa.SafeText.Replace('.',',');
            txrIXb.SafeText = txrIXb.SafeText.Replace('.',',');

            //Preleva dati
            ipar.Funzione = par.Funzione;
            ipar.RettangoliMaggiori = checkRetMag.Checked;
            ipar.RettangoliMinori = checkRetMin.Checked;
            ipar.Trapezii = checkTrap.Checked;

            if (int.TryParse(numIDivisioni.Value.ToString(), out iouter)) ipar.Divisioni = iouter;
            else
            {
                status = Errore("Valore di Divisione non valido","Valore non valido");
            }

            if (double.TryParse(txrIXa.SafeText, out outer)) ipar.A = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore di A non valido", "Valore non valido");
            }

            if (double.TryParse(txrIXb.SafeText, out outer)) ipar.B = outer; //Provo a parserizzare e se la parserizzazione va a buon fine salvo il risultato
            else
            {
                status = Errore("Valore di B non valido", "Valore non valido");
            }

            return status;
        }   //Preleva i dati dalla form e ne controlla tutti i valori
    }

    public class IntegraliParametr
    {
        //Parametri
        private double _a;
        private double _b;
        private double _fa;
        private double _fb;
        private bool _retMax;
        private bool _retMin;
        private bool _trap;
        private double _divisioni;
        private string _funzione;
        private ExpressionParser _parser;

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

        public bool RettangoliMaggiori
        {
            get { return _retMax; }
            set { _retMax = value; }
        }

        public bool RettangoliMinori
        {
            get { return _retMin; }
            set { _retMin = value; }
        }

        public bool Trapezii
        {
            get { return _trap; }
            set { _trap = value; }
        }

        /// <summary>
        /// Espremi il numero di volte per cui verrà divisa la funzione
        /// </summary>
        public double Divisioni
        {
            get { return _divisioni; }
            set { _divisioni = value; }
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
                }
            }
        }

        //Costruttore
        public IntegraliParametr()
        {
            Clear(); //Inizializzo
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
            _fa = 0;
            _fb = 0;
            _retMax = false;
            _retMin = false;
            _trap = false;
            _funzione = "";
            _parser = new ExpressionParser();
        }
    }
}
