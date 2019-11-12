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

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        decimal num1 = 0;
        decimal num2 = 0;

        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numAppend(int btnNum)
        {

            if (operation == "")
            {
                num1 = (num1 * 10) + btnNum;
                txtDisplay.Text = num1.ToString();
                labelCurrentOperation.Content = num1;
            }
            else
            {
                num2 = (num2 * 10) + btnNum;
                txtDisplay.Text = num2.ToString();
                labelCurrentOperation.Content = num1 + operation + num2;
            }
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            numAppend(0);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            numAppend(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            numAppend(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            numAppend(3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            numAppend(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            numAppend(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            numAppend(6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            numAppend(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            numAppend(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            numAppend(9);
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = 0;
                txtDisplay.Text = "0";
                labelCurrentOperation.Content = "";
            }
            else
            {
                num2 = 0;
                txtDisplay.Text = num1.ToString();
                labelCurrentOperation.Content = num1;
            }
            operation = "";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            operation = "c";
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";

            labelCurrentOperation.Content = "";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "+";

            labelCurrentOperation.Content = num1 + operation;
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "-";
            labelCurrentOperation.Content = num1 + operation;
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "*";
            labelCurrentOperation.Content = num1 + operation;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "/";
            labelCurrentOperation.Content = num1 + operation;
        }

        private void btnPlusMin_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = num1 * -1;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * -1;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btncomma_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ",";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                num1 = decimal.Parse(num1.ToString().Remove(num1.ToString().Length - 1, 1));

                labelCurrentOperation.Content = labelCurrentOperation.Content.ToString().Remove(labelCurrentOperation.Content.ToString().Length - 1, 1);
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                num2 = decimal.Parse(num2.ToString().Remove(num2.ToString().Length - 1, 1));

                labelCurrentOperation.Content = labelCurrentOperation.Content.ToString().Remove(labelCurrentOperation.Content.ToString().Length - 1, 1);
            }

        }

        private void txtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (num1 + num2).ToString();
                    labelCurrentOperation.Content = num1 + operation + num2;

                    break;

                case "c":
                    txtDisplay.Text = "0";

                    break;

                case "-":
                    txtDisplay.Text = (num1 - num2).ToString();
                    labelCurrentOperation.Content = num1 + operation + num2;
                    break;

                case "*":
                    txtDisplay.Text = (num1 * num2).ToString();
                    labelCurrentOperation.Content = num1 + operation + num2;
                    break;

                case "/":
                    txtDisplay.Text = (num1 / num2).ToString();
                    labelCurrentOperation.Content = num1 + operation + num2;
                    break;

                case "ce":
                    txtDisplay.Text = num2.ToString();
                    break;

                default:
                    break;

            }

            num1 = 0;
            num2 = 0;
            
            operation = "";

        }

    }
}
