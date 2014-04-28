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
                graph._clearAll();
                graph._drawAxis();
                graph._drawGridFixed(1, 1);
                try
                {
                    graph._drawFunction(txtFunct.Text, 100, new Pen(Color.Red));
                    flag = true;
                }
                catch (ClassGraph.GraphException ex)
                {
                    MessageBox.Show("La funzione é errata!!\n"+ex.Message);
                }
            }
        }

        bool dati_ok()
        {
            bool ret;
            ret = true;
            ret = ret && regexA.Match;
            ret = ret && regexB.Match;
            return ret;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            const double VERY_LITTLE_NUMBER = 0.00000001;

            if (flag && dati_ok()) // _funzione_disegnata // se la funzione é già stata disegnata
            {
                double a;                           // il punto a sx dell'integrale
                double b;                           // il punto a dx dell'integrale
                double ins = 0;                     // l'area delimitata dai rettangoli inferiori
                double cir = 0;                     // l'area delimitata dai rettangoli superiori
                double tra = 0;                     // l'area delimitata dai trapezi
                string f = txtFunct.Text;           // la stringa con la funzione
                // preleva i dati dalla form
                a = Convert.ToDouble(regexA.SafeText);
                b = Convert.ToDouble(regexB.SafeText);
                if (a > b)
                // nel caso in cui i dati xa ed xb non siano compatibili li swappa
                {
                    double c = a;
                    a = b;
                    b = c;
                }
                int n = (int)nbrIterazioni.Value;       // preleva il numero di poligoni dalla form
                double deltaX = (b - a) / n;            // la larghezza del singolo poligono

                for (double x = a; x <= b; x += deltaX)
                {
                    double Xleft = x;                   // l'ascissa del punto dell'angolo in basso a sinistra del rettangolo
                    double Yleft = fx(x, f);            // l'ordinata del punto dell'angolo in basso a sinistra del rettangolo
                    double Xright = x + deltaX;         // l'ascissa del punto in basso a destra del rettangolo
                    double Yright = fx(x + deltaX, f);  // l'ordinata del punto in basso a destra del rettangolo

                    try
                    {
                        if (CBinf.Checked)
                            if (Yleft * Yright > 0 &&
                               ((Yleft > 0) ? Yleft : -(Yleft)) > ((Yright > 0) ? Yright : -(Yright)))
                            {
                                // rettangoli inferiroi su funzioni tendenti allo 0
                                graph._drawRectangle(  Xleft,
                                                        (Yright >= 0) ? Yright : 0,
                                                        deltaX,
                                                        (Yright > 0) ? Yright : -(Yright),
                                                        Color.Blue);
                                ins += deltaX * Yright;
                            }
                            else if (((Yleft > 0) ? Yleft : -(Yleft)) < ((Yright > 0) ? Yright : -(Yright)))
                            {
                                // rettangoli inferiori su funzioni tendenti a un valore diverso da zero
                                graph._drawRectangle(  Xleft,
                                                        (Yleft >= 0) ? Yleft : 0,
                                                        deltaX,
                                                        (Yleft > 0) ? Yleft : -(Yleft),
                                                        Color.Blue);
                                ins += deltaX * Yleft;
                            }
                        if (CBsup.Checked)
                        {
                            if (Yleft * Yright > 0 && ((Yleft > 0) ? Yleft : -(Yleft)) > ((Yright > 0) ? Yright : -(Yright)))
                            {
                                //rettangoli superiori su funzioni tendenti allo zero
                                graph._drawRectangle(Xleft, (Yleft >= 0) ? Yleft : 0, deltaX, (Yleft > 0) ? Yleft : -(Yleft), Color.Red);
                                cir += deltaX * Yleft;
                            }
                            else if (((Yleft > 0) ? Yleft : -(Yleft)) < ((Yright > 0) ? Yright : -(Yright)))
                            {
                                //rettangoli superiori su funzioni tendenti a valori diversi da zero
                                graph._drawRectangle(Xleft, (Yright >= 0) ? Yright : 0, deltaX, (Yright > 0) ? Yright : -(Yright), Color.Red);
                                cir += deltaX * Yright;
                            }
                        }
                        if (CBtra.Checked)
                        {
                            //TODO
                            PointD[] punti = new PointD[4];
                            punti[0] = new PointD(Xleft, 0);
                            punti[3] = new PointD(Xleft, Yleft);
                            punti[1] = new PointD(Xright, 0);
                            punti[2] = new PointD(Xright, Yright);
                            graph._drawPoligon(punti,Color.Yellow);
                            tra += ((Yleft + Yright) * deltaX) / 2;
                        }
                    }
                    catch (ClassGraph.GraphException ex) { MessageBox.Show(ex.Message); }
                    catch (OverflowException ex)
                    {

                        MessageBox.Show("La funzione molto probabilmente in uno dei punti non esiste!!!\n"+ex.Message);
                    }
                }
                //se i valori tendono allo zero vengono annullati.
                if (cir < VERY_LITTLE_NUMBER && -(cir) < VERY_LITTLE_NUMBER)
                    cir = 0;
                if (ins < VERY_LITTLE_NUMBER && -(ins) < VERY_LITTLE_NUMBER)
                    ins = 0;
                MessageBox.Show("Superirori: " + cir.ToString() + "\ninferiori: " + ins.ToString()+"\ntrapezi:"+tra.ToString());
            }
            else
            {
                MessageBox.Show("Se disegni qualcosa forse è meglio...");
            }
        }

        private void graph_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
