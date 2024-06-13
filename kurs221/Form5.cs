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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка сброс
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double v = double.Parse(textBox1.Text);// объем
            double p = double.Parse(textBox2.Text);//давление
            double r = p * Math.Pow(v, 2)*2;// Вычисляем результат выражения p * v^2 * 2 и сохраняем его в переменную r
            textBox4.Text = p.ToString();// Вывод значения давления
            textBox5.Text = v.ToString();// Вывод значения объёма
            textBox7.Text = r.ToString(); //Вывод результата вычисления
            textBox3.Text = r.ToString();// Вывод результата вычисления в другое текстовое поле        
        }
    }
}
