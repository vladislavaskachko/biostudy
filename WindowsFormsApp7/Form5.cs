using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static WindowsFormsApp7.Form2;

namespace WindowsFormsApp7
{
    public partial class Form5 : Form
    {
        public class Chromosome
        {
            public int beforeMitosis;
            public int afterMitosis;
            public int afterFirstMeyosis;
            public int afterSecondMeyosis;
            public Chromosome()
            {
                beforeMitosis = 0;
                afterMitosis = 0;
                afterFirstMeyosis = 0;
                afterSecondMeyosis = 0;
            }

        }
        Chromosome chromosome= new Chromosome();
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(10, 40);
            chromosome.beforeMitosis = number * 4;
            chromosome.afterMitosis = number * 2;
            chromosome.afterFirstMeyosis = number * 2;
            chromosome.afterSecondMeyosis = number;
            textBox1.Text = $"В клетке животного диплоидный набор хромосом равен {number * 2}. Определите количество молекул ДНК перед митозом, после митоза, после первого деления мейоза и после второго деления мейоза";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res1 = textBox2.Text;
            string res2 = textBox5.Text;
            string res3 = textBox4.Text;
            string res4 = textBox3.Text;
            string exp1 = chromosome.beforeMitosis.ToString();
            string exp2 = chromosome.afterMitosis.ToString();
            string exp3 = chromosome.afterFirstMeyosis.ToString();
            string exp4 = chromosome.afterSecondMeyosis.ToString();
            if (res1 == exp1 && res2 == exp2 && res3 == exp3 && res4 == exp4)
            {
                textBox6.Text = "Верно!";
            }
            else
            {
                textBox6.Text = "Попробуй еще раз";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form5 mitosisAndMeiosisTasks = this;
            Form1 menu = new Form1();
            menu.Show();
            mitosisAndMeiosisTasks.Hide();
        }
    }
}
