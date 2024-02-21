using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                     $" Площадь куба: {S} {cmbS.Text}";
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
                String message = $"Время падения: {t} сек";
                MessageBox.Show(message, "Результат");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x3 = Convert.ToDouble(textBox2.Text);
            double S2 = (Math.PI/4)*Math.Pow(x3, 2);
            String message = $"Площадь круга: {S2} {cmbS.Text}";
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
                MessageBox.Show("Некорректные занчения!", "Результат");
            }
            else
            {
                Double Perimetr1 = (a1 + b1 + c1) / 2;
                Double S3 = ((x11 - x31) * (y21 - y31) - (x21 - x31) * (y11 - y31)) / 2;
                String message = $"Площадь трегольника: {S3} {cmbS.Text}   " +
                     $" Периметр треугольника: {Perimetr1} {cmbS.Text}";
                MessageBox.Show(message, "Результат");
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double R1 =Convert.ToDouble(txbR1.Text);
            Double R2 = Convert.ToDouble(txbR2.Text);
            Double R3 = Convert.ToDouble(txbR3.Text);
            if (R1<= 0| R2<= 0| R2<=0)
            {
                MessageBox.Show("Некорректные занчения!", "Результат");
            }
            else
            {
                Double R0 = 1/(1/R1 + 1/R2 + 1/R3);
                String message = $"Сопротивление соединения: {R0}";
                MessageBox.Show(message, "Результат");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(txba.Text);
            Double b = Convert.ToDouble(txbb.Text);
            Double P = 2 * (a + b);
            Double S = a * b;
            Double d = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
            String message = $"Периметр: {P} {cmbS.Text} " + $"Площадь: {S} {cmbS.Text} " + $"Длинна диагонали: {d} {cmbS.Text}";
            MessageBox.Show(message, "Результат");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(txba7.Text);
            Double b = Convert.ToDouble(txbb7.Text);
            Double c = Convert.ToDouble(txbc7.Text);
            if (a<= 0)
            {
                MessageBox.Show("Некорректные занчения!", "Результат");
            }
            else
            {
                Double x = -b / (2 * a);
                Double y = a * Math.Pow(x, 2) + b * x + c;
                String message = $"X: {x}  "+ $"Y: {y}";
                MessageBox.Show(message, "Результат");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txbA8.Text);
            double B = Convert.ToDouble(txbB8.Text);
            double C = Convert.ToDouble(txbC8.Text);
            double P = (A + B + C) / 2;
            double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            String message = $"Площадь треугольника: {S} {cmbS.Text}";
            MessageBox.Show(message, "Результат");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double V0 = Convert.ToDouble(txbV0.Text);
            double a = Convert.ToDouble(txba9.Text);
            double t = Convert.ToDouble(txbt9.Text);
            double v = V0+a*t;
            double S = Convert.ToDouble(V0+((a*Math.Pow(t,2))/2));
            String message = $"Скорость: {v}  "+ $"Расстояние: {S} {cmbS.Text}";
            MessageBox.Show(message, "Результат");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txbr10.Text);
            double h = Convert.ToDouble(txbh10.Text);
            double V = Math.PI * Math.Pow(r, 2) * h;
            double S = 2 * Math.PI * r * h;
            String message = $"Объём цилиндра: {V}  " + $"Площадь цилиндра: {S} {cmbS.Text}";
            MessageBox.Show(message, "Результат");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txba11.Text);
            double b = Convert.ToDouble(txbb11.Text);
            double c = Convert.ToDouble(txbc11.Text);
            double p = (a + b + c) / 2;
            double H = 2/a*(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
            String message = $"Объём цилиндра: {H}  ";
            MessageBox.Show(message, "Результат");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txbc12.Text);
            double d = Convert.ToDouble(txbd12.Text);
            double n = Convert.ToDouble(txbn12.Text);
            double m = Convert.ToDouble(txbm12.Text);
            double a = Convert.ToDouble(txba12.Text);
            double b = Convert.ToDouble(txbb12.Text);
            double S1 = c * d;
            double S2 = n * m;
            double S = 4 * a * b - S1 - S2;
            String message = $"Площадь стен: {S} {cmbS.Text} ";
            MessageBox.Show(message, "Результат");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txba13.Text);
            double b = Convert.ToDouble(txbb13.Text);
            double c = Convert.ToDouble(txbc13.Text);
            double d = Convert.ToDouble(txbd13.Text);
            if (a-b == 0 )
            {
                MessageBox.Show("Некорректные занчения!", "Результат");
            }
            else
            {
                double S = ((a + b) / 2) * Math.Sqrt(Math.Pow(c, 2) - ((Math.Pow((b - a), 2)) + Math.Pow(c, 2) - Math.Pow(d, 2))/(2*(b-a)));
                String message = $"Площадь трапеции: {S} {cmbS.Text}  ";
                MessageBox.Show(message, "Результат");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txbV14.Text.Length< 1| txbV114.Text.Length < 1| txbt114.Text.Length < 1| txbt214.Text.Length < 1)
            {
                MessageBox.Show("Введите все данные!");
            }
            else
            {
                double v = Convert.ToDouble(txbV14.Text);
                double v1 = Convert.ToDouble(txbV114.Text);
                double t1 = Convert.ToDouble(txbt114.Text);
                double t2 = Convert.ToDouble(txbt214.Text);
                double S = (v * t1) + (t2 * (v - v1));
                String message = $"Путь лодки: {S} {cmbS.Text}  ";
                MessageBox.Show(message, "Результат");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txbv115.Text.Length < 1 | txbv215.Text.Length < 1 | txbt115.Text.Length < 1 | txbt215.Text.Length < 1)
            {
                MessageBox.Show("Введите все данные!");
            }
            else
            {
                double v1 = Convert.ToDouble(txbv115.Text);
                double v2 = Convert.ToDouble(txbv215.Text);
                double t1 = Convert.ToDouble(txbt115.Text);
                double t2 = Convert.ToDouble(txbt215.Text);
                double V = v1 + v2;
                double T = (v1 * t1 + v2 * t2) / (v1 + v2);
                String message = $"Объём смеси: {V}  "+ $"Температура смеси: {T} ";
                MessageBox.Show(message, "Результат");
            }
        }
    }
}
