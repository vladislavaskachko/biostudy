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
    public partial class Form3 : Form
    {
        public class TRNA
        {
            public int molecules;
            public int aminoAcids;
            public int triplets;
            public int nucleotydes;
            public TRNA()
            {
                molecules = 0;
                aminoAcids = 0;
                triplets = 0;
                nucleotydes = 0;
            }
        }
        TRNA tRNA = new TRNA();
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(10, 100);
            tRNA.molecules = number;
            tRNA.aminoAcids = number;
            tRNA.triplets = number;
            tRNA.nucleotydes = number * 3;
            int type = rnd.Next(0, 5);
            if (type == 1)
            {
                textBox1.Text = $"В трансляции участвовало {number} молекул т-РНК. Определите количество аминокислот, входящих в состав образующегося белка, а также количество триплетов и нуклеотидов в гене, кодирующем этот белок";
            }
            if (type == 2)
            {
                textBox1.Text = $"В состав белка входит {number} аминокислот. Определите количество триплетов и нуклеотидов в гене, кодирующем этот белок, а также количество молекул т-РНК, участвовавших в трансляции";
            }
            if (type == 3)
            {
                textBox1.Text = $"В гене, кодирующем белок, {number * 3} нуклеотидов. Найдите количество триплетов в этом гене, количество аминокислот, входящих в состав этого белка, а также количество молекул т-РНК, участвовавших в трансляции";
            }
            else
            {
                textBox1.Text = $"Ген, кодирующий белок, состоит из {number} триплетов. Найдите количество нуклеотидов в этом гене, количество аминокислот, входящих в состав этого белка, а также количество молекул т-РНК, участвовавших в трансляции";
            }
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
            string exp1 = tRNA.molecules.ToString();
            string exp2 = tRNA.aminoAcids.ToString();
            string exp3 = tRNA.triplets.ToString();
            string exp4 = tRNA.nucleotydes.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 translationTasks = this;
            Form1 menu = new Form1();
            menu.Show();
            translationTasks.Hide();
        }
    }
}
