using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kalkulacka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Display.Text = number2.ToString();
            }

        }

        private void n2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Display.Text = number2.ToString();
            }
        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Display.Text = number2.ToString();
            }
        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Display.Text = number2.ToString();
            }
        }

        private void n5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Display.Text = number2.ToString();
            }
        }

        private void n6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Display.Text = number2.ToString();
            }
        }

        private void n7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Display.Text = number2.ToString();
            }
        }

        private void n8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Display.Text = number2.ToString();
            }
        }

        private void n9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Display.Text = number2.ToString();
            }
        }

        private void n0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Display.Text = number2.ToString();
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Display.Text = "0";
        }

        private void Nas_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Display.Text = "0";
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Display.Text = "0";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Display.Text = "0";
        }

        private void Rovno_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "/":
                    Display.Text = (number1 / number2).ToString();
                    break;

                case "*":
                    Display.Text = (number1 * number2).ToString();
                    break;

                case "-":
                    Display.Text = (number1 - number2).ToString();
                    break;

                case "+":
                    Display.Text = (number1 + number2).ToString();
                    break;
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
                Display.Text = "0";
            }
            else
            {
                number2 = 0;
                Display.Text = "0";
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            Display.Text = "0";
        }

        private void BS_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                Display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                Display.Text = number2.ToString();
            }
        }

        private void Zapor_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                Display.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                Display.Text = number2.ToString();
            }
        }
    }
}
