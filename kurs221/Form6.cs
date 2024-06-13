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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //кнопка назад
            Form1 form1 = new Form1();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка сбрс
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double V = double.Parse(textBox1.Text);// Объем
            double u = double.Parse(textBox2.Text);// Скорость
            double p = double.Parse(textBox3.Text);// Давление
            double T = double.Parse(textBox4.Text);// Температура
            double R = 8.31;// Универсальная газовая постоянная
            double m = p * V * u / R * T;// Вычисляем массу газа m по формуле p * V * u / R * T и сохраняем результат в переменной m
            textBox11.Text = m.ToString();// Выводим значение m в textBox11
            textBox5.Text = m.ToString();// Выводим значение m в textBox5
            textBox6.Text = p.ToString();// Выводим значение давления в textBox6
            textBox7.Text = V.ToString();// Выводим значение объема в textBox7
            textBox8.Text = u.ToString();// Выводим значение скорости в textBox8
            textBox9.Text = R.ToString();// Выводим значение в textBox9
            textBox10.Text = T.ToString();// Выводим значение температуры в textBox10
        }
    }
}
