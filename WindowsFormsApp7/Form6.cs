using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp7.Form2;

namespace WindowsFormsApp7
{
    public partial class Form6 : Form
    {
        public class Molecule
        {
            public int glucoseNumb;
            public Molecule()
            {
                glucoseNumb = 0;
            }
        }
        Molecule molecule = new Molecule();
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(5, 310);
            molecule.glucoseNumb = number;
            textBox1.Text = $"Сколько молекул АТФ будет синтезироваться в клетках эукариот при окислении фрагмента молекулы крахмала, состоящего из {number} остатков глюкозы";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res1 = textBox2.Text;
            string res2 = textBox3.Text;
            string exp1 = (molecule.glucoseNumb * 2).ToString();
            string exp2 = (molecule.glucoseNumb * 38).ToString();
            if (res1 == exp1 && res2 == exp2)
            {
                textBox6.Text = "Верно!";
            }
            else
            {
                textBox6.Text = "Попробуй еще раз";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 metabolismTasks = this;
            Form1 menu = new Form1();
            menu.Show();
            metabolismTasks.Hide();
        }
    }
}
