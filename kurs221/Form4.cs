﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Кнопка сброс
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double T1 = double.Parse(textBox1.Text);// Исходная температура
            double p1 = double.Parse(textBox2.Text);// Исходное давление
            double p2 = double.Parse(textBox3.Text);// Конечное давление


            double T2 = T1 * p2 / p1;// Вычисляем конечную температуру T2 по формуле и сохраняем в переменную T2
            // Выводим значения переменных T1, p2, p1, T2 соответственно в текстовые поля
            textBox4.Text = T1.ToString();
            textBox5.Text = p2.ToString();
            textBox6.Text = p1.ToString();
            textBox7.Text = T2.ToString();
            textBox8.Text = T2.ToString();


        }
    }
}
