using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyscig_tuptusia
{
    public partial class Form1 : Form
    {

        public chart[] tuptus = new chart[4];
        public guy[] goscie = new guy[3];
        private Random random = new Random();



        public Form1()
        {
            InitializeComponent();

            // psy wyscigowe
            tuptus[0] = new chart(chart1, trasa, chart1.Left, random);
            tuptus[1] = new chart(chart2, trasa, chart2.Left, random);
            tuptus[2] = new chart(chart3, trasa, chart3.Left, random);
            tuptus[3] = new chart(chart4, trasa, chart4.Left, random);

            // kumple od zakladow
            goscie[0] = new guy("Janek", 55, RBJohny, LabelJohn);
            goscie[1] = new guy("Bob", 30, RBBob, LabelBob);
            goscie[2] = new guy("Olek", 105, RBAl, LabelAl);
            foreach (guy guy in goscie)
            {
                guy.UpdateLabels();
                guy.UpdateRadios();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
 

        private void betButton_Click(object sender, EventArgs e)
        {
            int guyNumber = 3;
            if (RBJohny.Checked) guyNumber = 0;
            if (RBBob.Checked) guyNumber = 1;
            if (RBAl.Checked) guyNumber = 2;
            goscie[guyNumber].PlaceBet((int)numericUpDown1.Value, (int)chartNumber.Value);
            goscie[guyNumber].UpdateLabels();
            goscie[guyNumber].radioButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < tuptus.Length; i++)
            {
                tuptus[i].Run();
                if (tuptus[i].Meta())
                {
                    timer1.Stop();
                    i++;
                    MessageBox.Show("Tuptus nr " + i + " wygrał!");
                    for (int j = 0; j < goscie.Length; j++)
                    {
                        if (goscie[j].myBet == null)
                            break;
                        else
                        {
                            goscie[j].Collect(i);
                            goscie[j].UpdateRadios();
                            goscie[j].ClearBet();
                            goscie[j].radioButton.Enabled = true;
                            goscie[j].radioButton.Checked = false;
                        }
                        goscie[j].UpdateLabels();
                    }
                }
            }
        }
    }
}
