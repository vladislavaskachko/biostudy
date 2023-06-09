using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp7
{
    public partial class Form4 : Form
    {
        public class Gene
        {
            public string gene;
            public Gene()
            {
                gene = string.Empty;
            }
        }
        Gene gene = new Gene();
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] genes = new int[12];;
            for (int i = 0; i < genes.Length; i++)
            {
                genes[i] = rand.Next(1, 5);
                if (genes[i] == 1)
                {
                    gene.gene += "A";
                }
                else if (genes[i] == 2)
                {
                    gene.gene += "C";
                }
                else if (genes[i] == 3)
                {
                    gene.gene += "G";
                }
                else
                {
                    gene.gene += "T";
                }
            }
            textBox1.Text = $"Фрагмент одной из цепей ДНК имеет следующее строение {gene.gene}. Постройте на ней и-РНК";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userStr = textBox2.Text;
            string baseStr = gene.gene;
            string result = string.Empty;
            for (int i = 0; i < 12; i++)
            {
                if (baseStr[i] == 'A')
                {
                    result += "U";
                }
                else if (baseStr[i] == 'C')
                {
                    result += "G";
                }
                else if (baseStr[i] == 'G')
                {
                    result += "C";
                }
                else
                {
                    result += "A";
                }
            }
            if (userStr == result)
            {
                textBox6.Text = "Верно!";
            }
            else
            {
                textBox6.Text = "Неверно! Должно быть так " + result;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 transcriptionTasks = this;
            Form1 menu = new Form1();
            menu.Show();
            transcriptionTasks.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
