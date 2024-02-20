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
                double x2 = Convert.ToDouble(textBox1.Text);
                double t = Math.Sqrt((2 * x2) / (9.81523));
                String message = $"Время падения: {t}сек";
                MessageBox.Show(message, "Результат");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x3 = Convert.ToDouble(textBox2.Text);
            double S2 = (Math.PI/4)*Math.Pow(x3, 2);
            String message = $"Площадь круга: {S2}";
            MessageBox.Show(message, "Результат");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double x11 = Convert.ToDouble(txbX1.Text);
            Double x21 = Convert.ToDouble(txbX2.Text);
            Double x31 = Convert.ToDouble(txbX3.Text);
            Double y11 = Convert.ToDouble(txbY1.Text);
            Double y21 = Convert.ToDouble(txbY2.Text);
            Double y31 = Convert.ToDouble(txbY3.Text);
            Double a1 = Math.Sqrt(Math.Pow((x21-x11),2) + Math.Pow((y21-y11),2));
            Double b1 = Math.Sqrt(Math.Pow((x31 - x21), 2) + Math.Pow((y31 - y21), 2));
            Double c1 = Math.Sqrt(Math.Pow((x11 - x31), 2) + Math.Pow((y11 - y31), 2));
            if( a1+b1<c1|a1+c1<b1|b1+c1<a1)
            {
                MessageBox.Show("Некорректные данные!!","Результат");
            }
            else
            {
                Double Perimetr1 = (a1 + b1 + c1) / 2;
                Double S3 = ((x11 - x31) * (y21 - y31) - (x21 - x31) * (y11 - y31)) / 2;
                String message = $"Площадь трегольника: {S3}  " +
                     $" Периметр треугольника: {Perimetr1}";
                MessageBox.Show(message, "Result");
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double R1 =Convert.ToDouble(txbR1.Text);
            Double R2 = Convert.ToDouble(txbR2.Text);
            Double R3 = Convert.ToDouble(txbR3.Text);
            if (R1<= 0| R2<= 0| R2<=0)
            {
                MessageBox.Show("Incorrect data");
            }
            else
            {
                Double R0 = 1/(1/R1 + 1/R2 + 1/R3);
                String message = $"Сопротивление соединения: {R0}";
                MessageBox.Show(message, "Result");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(txba.Text);
            Double b = Convert.ToDouble(txbb.Text);
            Double P = 2 * (a + b);
            Double S = a * b;
            Double d = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
            String message = $"Периметр: {P}  " + $"Площадь: {S}  " + $"Длинна диагонали: {d}";
            MessageBox.Show(message, "Result");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(txba7.Text);
            Double b = Convert.ToDouble(txbb7.Text);
            Double c = Convert.ToDouble(txbc7.Text);
            if (a<= 0)
            {
                MessageBox.Show("Incorrect data");
            }
            else
            {
                Double x = -b / (2 * a);
                Double y = a * Math.Pow(x, 2) + b * x + c;
                String message = $"X: {x}  "+ $"Y: {y}";
                MessageBox.Show(message, "Result");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txbA8.Text);
            double B = Convert.ToDouble(txbB8.Text);
            double C = Convert.ToDouble(txbC8.Text);
            double P = (A + B + C) / 2;
            double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            String message = $"Площадь треугольника: {S}";
            MessageBox.Show(message, "Result");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int V0 = Convert.ToInt32(txbV0.Text);
            int a = Convert.ToInt32(txba9.Text);
            int t = Convert.ToInt32(txbt9.Text);
            int v = V0+a*t;
            int S = Convert.ToInt32(V0+((a*Math.Pow(t,2))/2));
            String message = $"Скорость: {v}  "+ $"Расстояние: {S}";
            MessageBox.Show(message, "Result");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txbr10.Text);
            double h = Convert.ToDouble(txbh10.Text);
            double V = Math.PI * Math.Pow(r, 2) * h;
            double S = 2 * Math.PI * r * h;
            String message = $"Объём цилиндра: {V}  " + $"Площадь цилиндра: {S}";
            MessageBox.Show(message, "Result");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txba11.Text);
            double b = Convert.ToDouble(txbb11.Text);
            double c = Convert.ToDouble(txbc11.Text);
            double p = (a + b + c) / 2;
            double H = 2/a*(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
            String message = $"Объём цилиндра: {H}  ";
            MessageBox.Show(message, "Result");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txbc12.Text);
        }
    }
}
