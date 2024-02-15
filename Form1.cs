using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formaewbbb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbData.Text.Length < 1)
            {
                MessageBox.Show("Значение не задано");
            }
            else
            {
                Double x1 = Convert.ToDouble(txbData.Text);
                Double V = Math.Pow(x1, 3);
                Double S = Math.Pow(x1, 2);
                String message = $"Объём куба: {V}; " +
                     $" Площадь куба: {S}";
                MessageBox.Show(message, "Результат");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1) 
            {
                MessageBox.Show("Значение не задано");
            }
            else
            {
                Double x2 = Convert.ToDouble(textBox1.Text);
                Double t = Math.Sqrt((2 * x2) / (9.81523));
                String message2 = $"Время падения: {t}";
                
            }
        }
    }
}
