using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using info.lundin.math;
using System.Collections;

namespace MyGeoCoso
{
    public partial class FormBase : Form
    {
        //Parametri
        GraphParametr par;
        BisezioneParametr bpar;
        SecantiParametr spar;
        ExpressionParser _parser;
        bool _disegnato = false;

        //Costritture
        public FormBase()
        {
            InitializeComponent();
            par = new GraphParametr();
            bpar = new BisezioneParametr();
            spar = new SecantiParametr();
            _parser = new ExpressionParser();
        }

        //Metodi
        private double fx(double x, string f)   //Funzione per il calcolo del valore di una variabile in un punto
        {
            Hashtable table = new Hashtable();  //Creo una HashTable

            table.Add("x", x.ToString());   //imposto in X il valore da determinare
            table.Add("e", Math.E.ToString());  //imposto in e il numero di Nepero

            return _parser.Parse(f, table); //Calcolo il valore di x nella funzione
        }
    }
}
