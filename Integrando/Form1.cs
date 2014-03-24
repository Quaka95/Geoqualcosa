using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
using Mate.Graph;

namespace Integrando
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private double fx(double x, string f)   //Funzione per il calcolo del valore di una variabile in un punto
        {
            Hashtable table = new Hashtable();  //Creo una HashTable
            table.Add("x", x.ToString());   //imposto in X il valore da determinare
            table.Add("e", Math.E.ToString());  //imposto in e il numero di Nepero
            ExpressionParser _parser = new ExpressionParser();
            return _parser.Parse(f, table); //Calcolo il valore di x nella funzione
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                graph1._clearAll();
                graph1._drawAxis();
                graph1._drawGridFixed(1, 1);
                try
                {
                    graph1._drawFunction(textBox1.Text, 100, new Pen(Color.Red));
                    flag = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La funzione é errata!!");
                }
            }
        }

        bool dati_ok()
        {
            bool ret;
            ret = false;
            ret = ret && textRegex1.Match;
            ret = ret && textRegex2.Match;
            return ret;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            const double VERY_LITTLE_NUMBER = 0.00000001;

            if (flag && dati_ok()) // _funzione_disegnata // se la funzione é già stata disegnata
            {
                double a;  // il punto a sx dell'integrale
                double b;  // il punto a dx dell'integrale
                double ins = 0; // l'area delimitata dai rettangoli inferiori
                double cir = 0; // l'area delimitata dai rettangoli superiori
                string f = textBox1.Text;  // la stringa con la funzione
                // preleva i dati dalla form
                a = Convert.ToDouble(textRegex1.SafeText);
                b = Convert.ToDouble(textRegex2.SafeText);
                if (a > b)
                // nel caso in cui i dati xa ed xb non siano compatibili li swappa
                {
                    double c = a;
                    a = b;
                    b = c;
                }
                int n = (int)numericUpDown1.Value;  // preleva il numero di poligoni dalla form
                double step = (b - a) / n;  // la larghezza del singolo poligono

                // double deltax = (xb - xa) / n;

                for (double x = a; x <= b; x += step)


                //for (int i = 0; i < n; i++)
                {
                    double po = x;  // l'ascissa del punto dell'angolo in basso a sinistra del rettangolo
                    double fpo = fx(x, f);      // l'ordinata del punto dell'angolo in basso a sinistra del rettangolo
                    double pos = x + step;     // l'ascissa del punto in basso a destra del rettangolo
                    double fpos = fx(x + step, f); // l'ordinata del punto in basso a destra del rettangolo

                    // TODO: utilizzare tre checkboxes per le tre tipologie di aree
                    try
                    {
                        if (fpo * fpos > 0 && ((fpo > 0) ? fpo : -(fpo)) > ((fpos > 0) ? fpos : -(fpos)))
                        {
                            // rettangoli la cui base inferiore poggia sull'asse delle ascisse
                            graph1._drawRectangle(po, (fpo >= 0) ? fpo : 0, step, (fpo > 0) ? fpo : -(fpo), Color.Red);
                            cir += step * fpo;
                            graph1._drawRectangle(po, (fpos >= 0) ? fpos : 0, step, (fpos > 0) ? fpos : -(fpos), Color.Blue);
                            ins += step * fpos;
                        }
                        else if (((fpo > 0) ? fpo : -(fpo)) < ((fpos > 0) ? fpos : -(fpos)))
                        {
                            // rettangoli la cui base superiore poggia sull'asse delle ascisse
                            graph1._drawRectangle(po, (fpos >= 0) ? fpos : 0, step, (fpos > 0) ? fpos : -(fpos), Color.Red);
                            cir += step * fpos;
                            graph1._drawRectangle(po, (fpo >= 0) ? fpo : 0, step, (fpo > 0) ? fpo : -(fpo), Color.Blue);
                            ins += step * fpo;
                        }
                    }

                    catch (ClassGraph.GraphException ex) { }
                    catch (OverflowException ex) { MessageBox.Show("La funzione molto probabilmente in uno dei punti non esiste!!!"); }
                    //TODO: Capire perché se passo da (0,0) non funziona...
                }
                if (cir < VERY_LITTLE_NUMBER && -(cir) < VERY_LITTLE_NUMBER)
                    cir = 0;
                if (ins < VERY_LITTLE_NUMBER && -(ins) < VERY_LITTLE_NUMBER)
                    ins = 0;
                MessageBox.Show("Circoscritti: " + cir.ToString() + "\nInscritti: " + ins.ToString());
            }
            else
            {
                MessageBox.Show("Se disegni qualcosa forse è meglio...");
            }
        }
    }
}
