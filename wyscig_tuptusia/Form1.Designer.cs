namespace wyscig_tuptusia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chart1 = new System.Windows.Forms.PictureBox();
            this.trasa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.PictureBox();
            this.chart3 = new System.Windows.Forms.PictureBox();
            this.chart4 = new System.Windows.Forms.PictureBox();
            this.RBJohny = new System.Windows.Forms.RadioButton();
            this.RBBob = new System.Windows.Forms.RadioButton();
            this.RBAl = new System.Windows.Forms.RadioButton();
            this.LabelJohn = new System.Windows.Forms.Label();
            this.LabelBob = new System.Windows.Forms.Label();
            this.LabelAl = new System.Windows.Forms.Label();
            this.bettorLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chartNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Image = global::wyscig_tuptusia.Properties.Resources.jezyk;
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(54, 50);
            this.chart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chart1.TabIndex = 1;
            this.chart1.TabStop = false;
            // 
            // trasa
            // 
            this.trasa.Image = global::wyscig_tuptusia.Properties.Resources.Bez_tytułu;
            this.trasa.Location = new System.Drawing.Point(12, 12);
            this.trasa.Name = "trasa";
            this.trasa.Size = new System.Drawing.Size(732, 340);
            this.trasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trasa.TabIndex = 0;
            this.trasa.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(574, 377);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(170, 52);
            this.start.TabIndex = 2;
            this.start.Text = "Pedz Tuptusiu!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // chart2
            // 
            this.chart2.Image = global::wyscig_tuptusia.Properties.Resources.jezyk;
            this.chart2.Location = new System.Drawing.Point(12, 90);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(54, 50);
            this.chart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chart2.TabIndex = 3;
            this.chart2.TabStop = false;
            // 
            // chart3
            // 
            this.chart3.Image = global::wyscig_tuptusia.Properties.Resources.jezyk;
            this.chart3.Location = new System.Drawing.Point(12, 171);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(54, 50);
            this.chart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chart3.TabIndex = 4;
            this.chart3.TabStop = false;
            // 
            // chart4
            // 
            this.chart4.Image = global::wyscig_tuptusia.Properties.Resources.jezyk;
            this.chart4.Location = new System.Drawing.Point(12, 263);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(54, 50);
            this.chart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chart4.TabIndex = 5;
            this.chart4.TabStop = false;
            // 
            // RBJohny
            // 
            this.RBJohny.AutoSize = true;
            this.RBJohny.Location = new System.Drawing.Point(13, 377);
            this.RBJohny.Name = "RBJohny";
            this.RBJohny.Size = new System.Drawing.Size(54, 17);
            this.RBJohny.TabIndex = 6;
            this.RBJohny.TabStop = true;
            this.RBJohny.Text = "Janek";
            this.RBJohny.UseVisualStyleBackColor = true;
            // 
            // RBBob
            // 
            this.RBBob.AutoSize = true;
            this.RBBob.Location = new System.Drawing.Point(12, 412);
            this.RBBob.Name = "RBBob";
            this.RBBob.Size = new System.Drawing.Size(44, 17);
            this.RBBob.TabIndex = 7;
            this.RBBob.TabStop = true;
            this.RBBob.Text = "Bob";
            this.RBBob.UseVisualStyleBackColor = true;
            // 
            // RBAl
            // 
            this.RBAl.AutoSize = true;
            this.RBAl.Location = new System.Drawing.Point(13, 449);
            this.RBAl.Name = "RBAl";
            this.RBAl.Size = new System.Drawing.Size(47, 17);
            this.RBAl.TabIndex = 8;
            this.RBAl.TabStop = true;
            this.RBAl.Text = "Olek";
            this.RBAl.UseVisualStyleBackColor = true;
            // 
            // LabelJohn
            // 
            this.LabelJohn.AutoSize = true;
            this.LabelJohn.Location = new System.Drawing.Point(163, 379);
            this.LabelJohn.Name = "LabelJohn";
            this.LabelJohn.Size = new System.Drawing.Size(80, 13);
            this.LabelJohn.TabIndex = 9;
            this.LabelJohn.Text = "Janek obstawil:";
            // 
            // LabelBob
            // 
            this.LabelBob.AutoSize = true;
            this.LabelBob.Location = new System.Drawing.Point(163, 416);
            this.LabelBob.Name = "LabelBob";
            this.LabelBob.Size = new System.Drawing.Size(72, 13);
            this.LabelBob.TabIndex = 10;
            this.LabelBob.Text = "Bob obstawił:";
            // 
            // LabelAl
            // 
            this.LabelAl.AutoSize = true;
            this.LabelAl.Location = new System.Drawing.Point(162, 453);
            this.LabelAl.Name = "LabelAl";
            this.LabelAl.Size = new System.Drawing.Size(73, 13);
            this.LabelAl.TabIndex = 11;
            this.LabelAl.Text = "Olek obstawil:";
            // 
            // bettorLabel
            // 
            this.bettorLabel.AutoSize = true;
            this.bettorLabel.Location = new System.Drawing.Point(10, 510);
            this.bettorLabel.Name = "bettorLabel";
            this.bettorLabel.Size = new System.Drawing.Size(35, 13);
            this.bettorLabel.TabIndex = 12;
            this.bettorLabel.Text = "label1";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(86, 505);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 22);
            this.betButton.TabIndex = 13;
            this.betButton.Text = "Stawia";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(192, 507);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "zł na charta nr";
            // 
            // chartNumber
            // 
            this.chartNumber.Location = new System.Drawing.Point(353, 507);
            this.chartNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.chartNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chartNumber.Name = "chartNumber";
            this.chartNumber.Size = new System.Drawing.Size(51, 20);
            this.chartNumber.TabIndex = 17;
            this.chartNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.chartNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.bettorLabel);
            this.Controls.Add(this.LabelAl);
            this.Controls.Add(this.LabelBob);
            this.Controls.Add(this.LabelJohn);
            this.Controls.Add(this.RBAl);
            this.Controls.Add(this.RBBob);
            this.Controls.Add(this.RBJohny);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trasa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trasa;
        private System.Windows.Forms.PictureBox chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox chart2;
        private System.Windows.Forms.PictureBox chart3;
        private System.Windows.Forms.PictureBox chart4;
        private System.Windows.Forms.RadioButton RBJohny;
        private System.Windows.Forms.RadioButton RBBob;
        private System.Windows.Forms.RadioButton RBAl;
        private System.Windows.Forms.Label LabelJohn;
        private System.Windows.Forms.Label LabelBob;
        private System.Windows.Forms.Label LabelAl;
        private System.Windows.Forms.Label bettorLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown chartNumber;
    }
}

