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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La funzione é errata!!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double ins=0;
            double cir=0;
            string f = textBox1.Text;
            try
            {
                a = Convert.ToDouble(textRegex1.SafeText);
                b = Convert.ToDouble(textRegex2.SafeText);
                if (a > b)
                {
                    double c = a;
                    a = b;
                    b = c;
                }
                int n = (int)numericUpDown1.Value;
                double step = (b - a) / n;
                for (int i = 0; i < n; i++) 
                {
                    double po = a + (step * i);
                    double fpo = fx(po, f);
                    double pos = po + step;
                    double fpos = fx(po + step, f);
                    if (fpo * fpos > 0 && ((fpo > 0) ? fpo : -(fpo)) > ((fpos > 0) ? fpos : -(fpos)))
                    {
                        graph1._drawRectangle(po, (fpo >= 0) ? fpo : 0, step, (fpo > 0) ? fpo : -(fpo), Color.Red);
                        cir += step * fpo;  
                        graph1._drawRectangle(po, (fpos >= 0) ? fpos : 0, step, (fpos > 0) ? fpos : -(fpos), Color.Blue);
                        ins += step * fpos;
                    }
                    else if ( ((fpo>0)?fpo:-(fpo)) < ((fpos>0)?fpos:-(fpos)) )
                    {
                        graph1._drawRectangle(po, (fpos >= 0) ? fpos : 0, step, (fpos > 0) ? fpos : -(fpos), Color.Red);
                        cir += step * fpos;
                        try
                        {
                            graph1._drawRectangle(po, (fpo >= 0) ? fpo : 0, step, (fpo > 0) ? fpo : -(fpo), Color.Blue);
                        }
                        catch (ClassGraph.GraphException ex)
                        {

                        }
                        ins += step * fpo;  
                    }
                }
                if (cir < 0.00000001)
                    cir = 0;
                if (ins < 0.00000001)
                    ins = 0;
                MessageBox.Show("Circoscritti: "+cir.ToString()+"\nInscritti: "+ins.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Controlla i vaolori inseriti!!");
            }
        }
    }
}
