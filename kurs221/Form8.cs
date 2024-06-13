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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Кнопка назад
            Form8 form8 = new Form8();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Очистка textbox по кнопке
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double p1 = double.Parse(textBox1.Text);//Давление
            double t1 = double.Parse(textBox2.Text);//Температура 1-го тела
            double t2 = double.Parse(textBox3.Text);//Температура 2-го тела
            // Вычисляем значение переменной P2 по формуле p1 * t2 / t1
            double P2 = p1 * t2 / t1;
            // Отображаем значения p1, t1, t2 в соответствующих textBox11, textBox12, textBox13
            textBox11.Text = p1.ToString();
            textBox12.Text = t1.ToString();
            textBox13.Text = t2.ToString();
            // Отображаем значение P2 в textBox14 и textBox4
            textBox14.Text = P2.ToString();
            textBox4.Text = P2.ToString();

        }
    }
}
