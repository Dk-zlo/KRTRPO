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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Очистка полей
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
            double m = double.Parse(textBox1.Text);// преобразование текста в поле textBox1 в число и сохранение в переменную m
            double V = double.Parse(textBox2.Text);//Объём
            double u = double.Parse(textBox3.Text);
            double P = double.Parse(textBox4.Text);
            double R = 8.31;// Задание значения для универсальной газовой постоянной

            double T = P * V * u / m * R;// Вычисление температуры по формуле и сохранение результата в переменную T
            textBox11.Text = T.ToString();// Отображение рассчитанного значения температуры в textBox11
            textBox5.Text = T.ToString();// Отображение рассчитанного значения температуры в textBox11
            textBox6.Text = P.ToString();// Отображение давления
            textBox7.Text = V.ToString();// Отображение объема
            textBox8.Text = u.ToString();// Отображение внутренней энергии
            textBox9.Text = m.ToString();// Отображение массы
            textBox10.Text = R.ToString();// Отображение универсальной газовой постоянной
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Объявление переменной для формы
            Form1 form1 = new Form1();
            //закрытие при нажатие кнопки
            this.Close();
            
        }
    }
}
