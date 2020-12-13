using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Интегрирование
{
    public partial class Form1 : Form
    {
        private const double h = 0.05f; 

        private Func<double, double> function;
        private Func<double, double> derFunction;
        private double a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Functions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Info.Clear();
            int selectedFunction = Functions.SelectedIndex;
            switch(selectedFunction)
            {
                case 0:
                    SetFunction(Function_1);
                    SetTheSecondDerivative(DerFunction_1);
                    SetFunctionInfo(1.5,2.5);
                    SetImageOfFunction(0);
                    break;
                case 1:
                    SetFunction(Function_2);
                    SetTheSecondDerivative(DerFunction_2);
                    SetFunctionInfo(-1.4, -0.4);
                    SetImageOfFunction(1);
                    break;
                case 2:
                    SetFunction(Function_3);
                    SetTheSecondDerivative(DerFunction_3);
                    SetFunctionInfo(3, 4);
                    SetImageOfFunction(2);
                    break;
                case 3:
                    SetFunction(Function_4);
                    SetTheSecondDerivative(DerFunction_4);
                    SetFunctionInfo(1, 2);
                    SetImageOfFunction(3);
                    break;
                case 4:
                    SetFunction(Function_5);
                    SetTheSecondDerivative(DerFunction_5);
                    SetFunctionInfo(-2.5, -1.5);
                    SetImageOfFunction(4);
                    break;
            }
            Result.Clear();
            Error.Clear();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double integral = FindIntegral();
            double error = FindError();
            Result.Text = Math.Round(integral, 3).ToString();
            Error.Text = Math.Round(error, 5).ToString();
        }

        private double FindIntegral()
        {
            double alpha = a + h / 2;
            double n = (b - a) / h;
            double result = 0;
            double func = 0;

            for (double i = 0; i < n; i += 1)
            {
                func = function(alpha + i * h);
                result += func;
                if (Math.Abs(func) < 0.1 * Math.Pow(10, 1 - i)) break;
            }

            return result * h;
        }

        private double FindError()
        {
            double n = (b - a) / h;
            double maxDer = FindMaxDer(a,b);
            return Math.Pow(b - a, 3) * Math.Abs(maxDer) / (24 * Math.Pow(n, 2));
        }

        private double FindMaxDer(double min, double max)
        {
            double maxVal = double.NegativeInfinity;
            for (double i = min; i <= max; i += 0.1)
            {
                double func = derFunction(i);
                if (func > maxVal) maxVal = func;
            }
            return maxVal;
        }

        private void SetFunction(Func<double, double> function)
        {
            this.function = function;
        }

        private void SetTheSecondDerivative(Func<double, double> derivative)
        {
            derFunction = derivative;
        }

        private void SetFunctionInfo(double a, double b)
        {
            this.a = a; this.b = b;
            AddLine(Info, $"A = {a}");
            AddLine(Info, $"B = {b}");
            AddLine(Info, $"H = {h}");
        }

        private void SetImageOfFunction(int index)
        {
            FunctionIMG.Image = FunctionImages.Images[index];
        }

        private void AddLine(TextBox textBox, string line)
        {
            textBox.Text += line;
            textBox.Text += "\r\n";
        }

        private double Function_1(double x)
        {
            return 1 + Math.Sin(4 * x) / Math.Log(x);
        }

        private double DerFunction_1(double x)
        {
            return -(16 * Math.Sin(4 * x) / Math.Log(x)) - (8 * Math.Cos(4 * x) / (x * Math.Pow(Math.Log(x), 2))) + (Math.Sin(4 * x) / (Math.Pow(x, 2) * Math.Pow(Math.Log(x), 2))) + (2 * Math.Sin(4 * x) / (Math.Pow(x, 2) * Math.Pow(Math.Log(x), 3)));
        }

        private double Function_2(double x)
        {
            return -10 * Math.Sin(Math.Pow(x, 3)) * Math.Cos(-x);
        }

        private double DerFunction_2(double x)
        {
            return 90 * Math.Pow(x, 4) * Math.Sin(Math.Pow(x, 3)) * Math.Cos(x) + 60 * Math.Pow(x, 2) * Math.Sin(Math.Pow(x, 3)) - 60 * x * Math.Cos(x) * Math.Sin(Math.Pow(x, 3)) + 10 * Math.Cos(x) * Math.Sin(Math.Pow(x, 3));
        }

        private double Function_3(double x)
        {
            return Math.Exp(x) - 4 * Math.Exp(-x) - 1;
        }

        private double DerFunction_3(double x)
        {
            return (Math.Exp(2 * x) - 4) / Math.Exp(x);
        }

        private double Function_4(double x)
        {
            return Math.Cos(x) - Math.Sqrt(x + 2) + 1;
        }

        private double DerFunction_4(double x)
        {
            return -Math.Cos(x) + 1 / (4 * Math.Sqrt(x + 2) * (x + 2));
        }

        private double Function_5(double x)
        {
            return Math.Cos(1 + 0.2 * Math.Pow(x, 2)) - x;
        }

        private double DerFunction_5(double x)
        {
            return (2 * Math.Sin(1+0.2*Math.Pow(x,2)) / 5) + (4 * Math.Pow(x,2) * Math.Cos(1 + 0.2 * Math.Pow(x,2)) / 25);
        }
    }
}
