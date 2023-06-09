using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
  
    public partial class Form2 : Form
    {
        public class DNA
        {
            public int percentage1;
            public int percentage2;
            public int percentage3;
            public int percentage4;
           
            public DNA()
            {
                percentage1 = 0;
                percentage2 = 0;
                percentage3 = 0;
                percentage4 = 0;
            }
        }

        DNA dna = new DNA();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 5);
            string nucl = string.Empty;
            int percentage = rnd.Next(10, 25);
            if (num == 1)
            {
                nucl = "аденин";
                dna.percentage1 = percentage;
                dna.percentage2 = percentage;
                dna.percentage3 = 50 - percentage;
                dna.percentage4 = 50 - percentage;
            }
            if (num == 2)
            {
                nucl = "тимин";
                dna.percentage1 = percentage;
                dna.percentage2 = percentage;
                dna.percentage3 = 50 - percentage;
                dna.percentage4 = 50 - percentage;
            }
            if (num == 3)
            {
                nucl = "гуанин";
                dna.percentage3 = percentage;
                dna.percentage4 = percentage;
                dna.percentage1 = 50 - percentage;
                dna.percentage2 = 50 - percentage;
            }
            else
            {
                nucl = "цитозин";
                dna.percentage3 = percentage;
                dna.percentage4 = percentage;
                dna.percentage1 = 50 - percentage;
                dna.percentage2 = 50 - percentage;
            }
            
            textBox1.Text = $"В молекуле ДНК содержится {percentage}% {nucl}а. Определите, сколько процентов других нуклеотидов содержится в молекуле";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            string res1 = textBox2.Text;
            string res2 = textBox5.Text;
            string res3 = textBox4.Text;
            string res4 = textBox3.Text;
            string exp1 = dna.percentage1.ToString();
            string exp2 = dna.percentage2.ToString();
            string exp3 = dna.percentage3.ToString();   
            string exp4 = dna.percentage4.ToString();
            if (res1 == exp1 && res2 == exp2 && res3 ==  exp3 && res4 == exp4)
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
            textBox6.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 percentageTasks = this;
            Form1 menu = new Form1();
            menu.Show();
            percentageTasks.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
