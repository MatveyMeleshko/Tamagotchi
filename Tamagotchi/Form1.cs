using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            progressBar3.Value = 100;
            progressBar4.Value = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar4.Value!=0)
            {
                Random random = new Random();
                switch (random.Next(1,4))
                {
                    case 1:
                        if (progressBar1.Value != 0)
                        {
                            progressBar1.Value-=2;
                        }
                        else
                        {
                            progressBar4.Value--;
                        }
                        break;
                    case 2:
                        if (progressBar2.Value != 0)
                        {
                            progressBar2.Value-=5;
                        }
                        else
                        {
                            progressBar4.Value--;
                        }
                        break;
                    case 3:
                        if (progressBar3.Value != 0)
                        {
                            progressBar3.Value-=8;
                        }
                        else
                        {
                            progressBar4.Value--;
                        }
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Ваши петомцы погибли/n" +
                                "Вывод:/n" +
                                "Вы плохо заботелись");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value+=5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Value += 3;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value < 100)
            {
                progressBar3.Value += 4;
            }
        }

        private void играToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            progressBar3.Value = 100;
            progressBar4.Value = 100;

            timer1.Enabled = true;
        }

        private void окончитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
