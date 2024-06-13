using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs221
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Открывает Form2 при нажатии на кнопку
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //объявление переменной b
            Form3 b = new Form3();
            //после нажатия открывается другая форма
            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //объявление переменной с
            Form4 с = new Form4();
            //после нажатия открывается другая форма
            с.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //объявление переменной d
            Form5 d = new Form5();
            //после нажатия открывается другая форма
            d.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //объявление переменной s
            Form6 s = new Form6();
            //после нажатия открывается другая форма
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //объявление переменной t
            Form7 t = new Form7();
            //после нажатия открывается другая форма
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //объявление переменной q
            Form8 q = new Form8();
            //после нажатия открывается другая форма
            q.ShowDialog();
        }
    }
}
