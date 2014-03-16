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
                    double retMag;
                    double retMin;
                    string msg = "L'integrale calcolato con il metodo:\n";

                    retMag = CalcolaRettangoliMaggiori(Color.Blue);
                    retMin = CalcolaRettangoliMinori(Color.Red);

                    msg += (ipar.RettangoliMaggiori) ? "Rettangoli circoscritti: " + retMag.ToString() + "\n" : "";
                    msg += (ipar.RettangoliMinori) ? "Rettangoli inscritti: " + retMin.ToString() + "\n" : "";

                    MessageBox.Show(msg, "Risultato");
                }
                else
                {
                    Errore("Nessun metodo per il calcolo dell'integrale selezionato", "Errore Selezione");
                }
            }

            if (!_disegnato)    //Se non è disegnato nulla
            {
                Errore("Rappresentare almeno una funzione", "Errore Funzione");
            }
        }

        private double CalcolaRettangoliMaggiori(Color Colore)
        {
            double a = (ipar.A < ipar.B) ? ipar.A : ipar.B;
            double b = (ipar.A > ipar.B) ? ipar.A : ipar.B;
            double incrm = (b - a) / ipar.Divisioni;
            bool positivo;
            double lmInf;
            double lmSup = a;

            double area = 0;

            for (int i = 0; i < ipar.Divisioni; i++)
            {
                lmInf = lmSup;
                lmSup = a + ((i + 1) * incrm);

                if (!Discordi(lmInf, lmSup, ipar.Funzione, true))
                {
                    positivo = (fx(lmInf, ipar.Funzione) >= 0);
                    double val = (positivo) ? MassimoFunzione(ipar.Funzione, lmInf, lmSup) : MinimoFunzione(ipar.Funzione, lmInf, lmSup);
                    val = (!positivo) ? Modulo(val) : val;

                    if (ipar.RettangoliMaggiori)
                    {
                        if (val != 0)
                        {
                            DisegnaRettangolo(lmInf, 0, incrm, val, Colore, positivo);
                            area += incrm * val;
                        }
                    }
                }
            }

            return area;
        }

        private double CalcolaRettangoliMinori(Color Colore)
        {
            double a = (ipar.A < ipar.B) ? ipar.A : ipar.B;
            double b = (ipar.A > ipar.B) ? ipar.A : ipar.B;
            double incrm = (b - a) / ipar.Divisioni;
            bool positivo;
            double lmInf;
            double lmSup = a;

            double area = 0;

            for (int i = 0; i < ipar.Divisioni; i++)
            {
                lmInf = lmSup;
                lmSup = a + ((i + 1) * incrm);

                if (!Discordi(lmInf, lmSup, ipar.Funzione, true))
                {
                    positivo = (fx(lmInf, ipar.Funzione) >= 0);
                    double val = (positivo) ? MinimoFunzione(ipar.Funzione, lmInf, lmSup) : MassimoFunzione(ipar.Funzione, lmInf, lmSup);
                    val = (!positivo) ? Modulo(val) : val;

                    if (ipar.RettangoliMinori)
                    {
                        if (val != 0)
                        {
                            DisegnaRettangolo(lmInf, 0, incrm, val, Colore, positivo);
                            area += incrm * val;
                        }
                    }
                }
            }

            return area;
        }

        private double MassimoFunzione(string Funzione, double LimiteInferiore, double LimiteSuperiore)
        {
            double max = fx(LimiteInferiore, Funzione);
            double indx = LimiteInferiore;
            double val;
            double incremento = (LimiteSuperiore - LimiteInferiore) / 4;

            while (indx <= LimiteSuperiore)
            {
                val = fx(indx, Funzione);
                if (max < val) max = val;
                indx += incremento;
            }

            return max;
        }

        private double MinimoFunzione(string Funzione, double LimiteInferiore, double LimiteSuperiore)
        {
            double min = fx(LimiteInferiore, Funzione);
            double indx = LimiteInferiore;
            double val;
            double incremento = (LimiteSuperiore - LimiteInferiore) / 4;

            while (indx <= LimiteSuperiore)
            {
                val = fx(indx, Funzione);
                if (min > val) min = val;
                indx += incremento;
            }

            return min;
        }

        private double Modulo(double valore)
        {
            return (valore >= 0) ? valore : 0 - valore;
        }

        private void PulisciRidisegna(object sender, EventArgs e)
        {
            PulisciGrafico(null, null);
            DisegnaClick(null, null);
        }

        private void DisegnaRettangolo(double X, double Y, double width, double height, Color colore, bool positivo = true)
        {
            try
            {
                graph._drawRectangle(X, (positivo) ? height - Y : Y, width, height, colore);
            }
            catch (NullReferenceException ex) { }
        }

        private bool PrelevaIntegrale()
        {
            //Variabili
            bool status = true; //La variabile conferma che tutti i parametri erano corretti
            double outer = 0;   //Variabile per l'estrazione dei valori
            int iouter = 0;  //Variabile per l'estrazione dei valori interi

            //Integrità digitazione
            txrIXa.SafeText = txrIXa.SafeText.Replace('.', ',');
            txrIXb.SafeText = txrIXb.SafeText.Replace('.', ',');

            //Preleva dati
            ipar.Funzione = par.Funzione;
            ipar.RettangoliMaggiori = checkRetMag.Checked;
            ipar.RettangoliMinori = checkRetMin.Checked;
            ipar.Trapezii = checkTrap.Checked;

            if (int.TryParse(numIDivisioni.Value.ToString(), out iouter)) ipar.Divisioni = iouter;
            else
            {
                status = Errore("Valore di Divisione non valido", "Valore non valido");
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
        private int _divisioni;
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
        public int Divisioni
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
            _divisioni = 0;
            _retMax = false;
            _retMin = false;
            _trap = false;
            _funzione = "";
            _parser = new ExpressionParser();
        }
    }
}
