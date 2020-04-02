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

namespace kalkulator_Limanowka
{
    
    public partial class MainWindow : Window
    {
        private bool isOperatorClicked = false;
        private bool isCommaClicked = false;
        private bool isCalculated = false;
        private double num1 = 0;
        private double num2 = 0;
        private string dzialanie=" ";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButRownClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            else
            {
                isCommaClicked = false;
                if (isOperatorClicked == true)
                {

                    this.Input.Text = Convert.ToString(num1);
                }
                else
                {
                    try
                    {
                        num2 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num2;
                        this.Dzialanie.Text += "=";
                    }
                    catch
                    {
                        num2 = 0;
                    }


                    if (dzialanie == "+")
                    {

                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";

                    }
                    else if (dzialanie == "-")
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";

                    }
                    else if (dzialanie == "*")
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";

                    }
                    else if (dzialanie == "/")
                    {
                        if (num2 != 0)
                        {
                            num1 = num1 / num2;
                            this.Input.Text = Convert.ToString(num1);
                            num2 = 0;
                            dzialanie = " ";

                        }
                        else
                        {
                            this.Input.Text = "NIE DZIEL PRZEZ ZERO!";
                            num1 = 0;
                            num2 = 0;
                            dzialanie = " ";
                        }
                    }
                }
                isOperatorClicked = false;
                isCalculated = true;
                num1 = 0;
            }

        }
        private void ButOffClicked(object s, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void ButCeClicked(object s, RoutedEventArgs e)
        {
            this.Dzialanie.Text = "";
            this.Input.Text = "";
            num1 = 0;
            num2 = 0;
            dzialanie = " ";
            isOperatorClicked = false;
            isCalculated = false;
        }


        private void ButZnakClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            
            if (num2 == 0 && dzialanie == " " && this.Input.Text != "")
            {
                num1 = Convert.ToDouble(this.Input.Text)*(-1);
                this.Input.Text = Convert.ToString(num1);
            }
            else if (num1 == 0)
            {
                num1 = 0;
            }
            else if (dzialanie != " ")
            {
                num2 = Convert.ToDouble(this.Input.Text) * (-1);
                this.Input.Text = Convert.ToString(num2);
            }
           
        }
        private void ButOperatorClicked(object s, RoutedEventArgs e)
        {
            Button b = (Button)s;
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            isCommaClicked = false;
            if (isOperatorClicked == true)
            {
                dzialanie = b.Content.ToString();
            }
            else
            {
                if (num1 == 0)
                {
                    dzialanie = "+";
                    try
                    {
                        num1 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num1;
                        isOperatorClicked = true;

                    }
                    catch
                    {
                        dzialanie = " ";
                        num1 = 0;
                    }

                }
                else
                {
                    isOperatorClicked = true;
                    num2 = Convert.ToDouble(this.Input.Text);
                    this.Dzialanie.Text += num2;

                    if (dzialanie == "+")
                    {

                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == "-")
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == "*")
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == "/")
                    {
                        if (num2 != 0)
                        {
                            num1 = num1 / num2;
                            this.Input.Text = Convert.ToString(num1);

                        }
                        else
                        {
                            this.Input.Text = "NIE DZIEL PRZEZ ZERO!";
                            num1 = 0;
                            num2 = 0;
                            dzialanie = " ";
                        }
                    }
                    dzialanie = "+";
                    num2 = 0;
                }
            }
        }
        
        private void ButNumberClicked(object s, RoutedEventArgs e)
        {
            Button b = (Button)s;
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            if (isOperatorClicked == true)
            {
                this.Dzialanie.Text += dzialanie;
                this.Input.Text = "";
                isOperatorClicked = false;
                this.Input.Text += b.Content.ToString();

            }
            else
            {
                this.Input.Text += b.Content.ToString();
                isOperatorClicked = false;
            }
           

        }
      
        private void ButDotClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            if (isOperatorClicked == true)
            {
                this.Dzialanie.Text += dzialanie;
                this.Input.Text = "";
                isOperatorClicked = false;
            }
            if (isCommaClicked == false)
            {
                if (isOperatorClicked == true)
                {
                    this.Input.Text = "0.";
                    isOperatorClicked = false;
                }
                else if (this.Input.Text != "")
                {
                    this.Input.Text += ".";
                }
                else
                {
                    this.Input.Text += "0.";
                }
                isCommaClicked = true;

            }


        }
    }
}
