namespace Integrando
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.graph = new Mate.Graph.Graph();
            this.txtFunct = new System.Windows.Forms.TextBox();
            this.regexA = new Mate.TextRegex.TextRegex();
            this.regexB = new Mate.TextRegex.TextRegex();
            this.nbrIterazioni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CBinf = new System.Windows.Forms.CheckBox();
            this.CBsup = new System.Windows.Forms.CheckBox();
            this.CBtra = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nbrIterazioni)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph._enableZoomingPanning = true;
            this.graph._xMax = 10D;
            this.graph._xMin = -10D;
            this.graph._yMax = 10D;
            this.graph._yMin = -10D;
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(400, 400);
            this.graph.TabIndex = 0;
            this.graph.Load += new System.EventHandler(this.graph_Load);
            // 
            // txtFunct
            // 
            this.txtFunct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFunct.Location = new System.Drawing.Point(0, 548);
            this.txtFunct.Name = "txtFunct";
            this.txtFunct.Size = new System.Drawing.Size(400, 20);
            this.txtFunct.TabIndex = 1;
            this.txtFunct.Text = "sin(x)*x -2";
            this.txtFunct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // regexA
            // 
            this.regexA.Location = new System.Drawing.Point(101, 10);
            this.regexA.Name = "regexA";
            this.regexA.Regex = "^[-]?[0-9]+[,]?[0-9]*$";
            this.regexA.SafeText = "5";
            this.regexA.Size = new System.Drawing.Size(200, 20);
            this.regexA.TabIndex = 2;
            // 
            // regexB
            // 
            this.regexB.Location = new System.Drawing.Point(101, 37);
            this.regexB.Name = "regexB";
            this.regexB.Regex = "^[-]?[0-9]+[,]?[0-9]*$";
            this.regexB.SafeText = "-5";
            this.regexB.Size = new System.Drawing.Size(200, 20);
            this.regexB.TabIndex = 3;
            // 
            // nbrIterazioni
            // 
            this.nbrIterazioni.Location = new System.Drawing.Point(101, 64);
            this.nbrIterazioni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbrIterazioni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrIterazioni.Name = "nbrIterazioni";
            this.nbrIterazioni.Size = new System.Drawing.Size(200, 20);
            this.nbrIterazioni.TabIndex = 4;
            this.nbrIterazioni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valore A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valore B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Iterazioni";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Integra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBinf
            // 
            this.CBinf.AutoSize = true;
            this.CBinf.Location = new System.Drawing.Point(307, 24);
            this.CBinf.Name = "CBinf";
            this.CBinf.Size = new System.Drawing.Size(60, 17);
            this.CBinf.TabIndex = 9;
            this.CBinf.Text = "Inferiori";
            this.CBinf.UseVisualStyleBackColor = true;
            // 
            // CBsup
            // 
            this.CBsup.AutoSize = true;
            this.CBsup.Location = new System.Drawing.Point(307, 47);
            this.CBsup.Name = "CBsup";
            this.CBsup.Size = new System.Drawing.Size(67, 17);
            this.CBsup.TabIndex = 10;
            this.CBsup.Text = "Superiori";
            this.CBsup.UseVisualStyleBackColor = true;
            // 
            // CBtra
            // 
            this.CBtra.AutoSize = true;
            this.CBtra.Location = new System.Drawing.Point(307, 70);
            this.CBtra.Name = "CBtra";
            this.CBtra.Size = new System.Drawing.Size(61, 17);
            this.CBtra.TabIndex = 11;
            this.CBtra.Text = "Trapezi";
            this.CBtra.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 398);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 150);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.regexA);
            this.tabPage1.Controls.Add(this.CBtra);
            this.tabPage1.Controls.Add(this.regexB);
            this.tabPage1.Controls.Add(this.CBsup);
            this.tabPage1.Controls.Add(this.nbrIterazioni);
            this.tabPage1.Controls.Add(this.CBinf);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 124);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 568);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFunct);
            this.Controls.Add(this.graph);
            this.MaximumSize = new System.Drawing.Size(416, 606);
            this.MinimumSize = new System.Drawing.Size(416, 606);
            this.Name = "Form1";
            this.Text = "Integrando";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrIterazioni)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mate.Graph.Graph graph;
        private System.Windows.Forms.TextBox txtFunct;
        private Mate.TextRegex.TextRegex regexA;
        private Mate.TextRegex.TextRegex regexB;
        private System.Windows.Forms.NumericUpDown nbrIterazioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CBinf;
        private System.Windows.Forms.CheckBox CBsup;
        private System.Windows.Forms.CheckBox CBtra;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

