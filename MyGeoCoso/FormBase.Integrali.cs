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
    }

    public class IntegraliParametr
    {
        //Campi
        private double _a;
        private double _b;
        private double _fa;
        private double _fb;
        private double _fx;
        private ExpressionParser _parser;
        private string _funzione;
        private double _precisione;
        private int _cicli;

        //Costruttore
        public IntegraliParametr()
        {
            Clear();    //Setta a zero tutto
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
        /// Permetta la pulizia della classe
        /// </summary>
        public void Clear()
        {
            _a = 0; //Settaggio di default delle variabili
            _b = 0;
            _fa = 0;
            _fb = 0;
            _parser = new ExpressionParser();
            _funzione = "";
            _precisione = 0;
            _cicli = 0;
        }

        /// <summary>
        /// Calcola la secante passante per A e B
        /// </summary>
        public void Elabora()
        {
        }   //Metodo che elabora la retta secante

        private double fx(double x) //Funzione per il calcolo del valore di una variabile in un punto
        {
            Hashtable table = new Hashtable();  //Creo una HashTable

            table.Add("x", x.ToString());   //imposto in X il valore da determinare
            table.Add("e", Math.E.ToString());  //imposto in e il numero di Nepero

            return _parser.Parse(_funzione, table); //Calcolo il valore di x nella funzione
        }
    }
}
