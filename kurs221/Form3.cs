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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             double m = double.Parse(textBox1.Text);// Масса
            double u = double.Parse(textBox2.Text);// Скорость
            double T = double.Parse(textBox3.Text);// Температура
            double p = double.Parse(textBox4.Text);// Давление
            double R = 8.31;// Универсальная газовая постоянная

            double V = m * R * T / p * u;// Вычисляем объем V по формуле и сохраняем в переменную V
            textBox10.Text = V.ToString();// Дублирование результат в неизвестное поле 
            textBox5.Text = V.ToString();
            // Выводим значения переменных m, R, T, p, u соответственно в текстовые поля
            textBox6.Text = m.ToString();
            textBox7.Text = R.ToString();
            textBox8.Text = T.ToString();
            textBox9.Text = p.ToString();
            textBox11.Text = u.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //кнопка назад
            Form1 form1 = new Form1();
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
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }
    }
}
