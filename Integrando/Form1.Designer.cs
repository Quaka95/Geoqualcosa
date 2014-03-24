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
            this.graph1 = new Mate.Graph.Graph();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textRegex1 = new Mate.TextRegex.TextRegex();
            this.textRegex2 = new Mate.TextRegex.TextRegex();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // graph1
            // 
            this.graph1._enableZoomingPanning = true;
            this.graph1._xMax = 10D;
            this.graph1._xMin = -10D;
            this.graph1._yMax = 10D;
            this.graph1._yMin = -10D;
            this.graph1.Location = new System.Drawing.Point(0, 0);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(400, 400);
            this.graph1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 548);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "sin(x)*x -2";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textRegex1
            // 
            this.textRegex1.Location = new System.Drawing.Point(122, 425);
            this.textRegex1.Name = "textRegex1";
            this.textRegex1.Regex = "^[-]?[0-9]+[,]?[0-9]*$";
            this.textRegex1.SafeText = "5";
            this.textRegex1.Size = new System.Drawing.Size(200, 20);
            this.textRegex1.TabIndex = 2;
            // 
            // textRegex2
            // 
            this.textRegex2.Location = new System.Drawing.Point(122, 452);
            this.textRegex2.Name = "textRegex2";
            this.textRegex2.Regex = "^[-]?[0-9]+[,]?[0-9]*$";
            this.textRegex2.SafeText = "-5";
            this.textRegex2.Size = new System.Drawing.Size(200, 20);
            this.textRegex2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(122, 479);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valore A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valore B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Iterazioni";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Integra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textRegex2);
            this.Controls.Add(this.textRegex1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.graph1);
            this.MaximumSize = new System.Drawing.Size(416, 606);
            this.MinimumSize = new System.Drawing.Size(416, 606);
            this.Name = "Form1";
            this.Text = "Integrando";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mate.Graph.Graph graph1;
        private System.Windows.Forms.TextBox textBox1;
        private Mate.TextRegex.TextRegex textRegex1;
        private Mate.TextRegex.TextRegex textRegex2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

