using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = this;
            Form percentageTasks = new Form2();
            percentageTasks.Show();
            menu.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = this;
            Form translationTasks = new Form3();
            translationTasks.Show();
            menu.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menu = this;
            Form transcriptionTasks = new Form4();
            transcriptionTasks.Show();
            menu.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = this;
            Form mitosisAndMeiosisTasks = new Form5();
            mitosisAndMeiosisTasks.Show();
            menu.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 menu = this;
            Form metabolismTasks = new Form6();
            metabolismTasks.Show();
            menu.Hide();
        }
    }
}
