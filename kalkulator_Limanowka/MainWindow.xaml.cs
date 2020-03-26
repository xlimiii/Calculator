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
        private char dzialanie=' ';
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


                    if (dzialanie == '+')
                    {

                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = ' ';

                    }
                    else if (dzialanie == '-')
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = ' ';

                    }
                    else if (dzialanie == '*')
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = ' ';

                    }
                    else if (dzialanie == '/')
                    {
                        if (num2 != 0)
                        {
                            num1 = num1 / num2;
                            this.Input.Text = Convert.ToString(num1);
                            num2 = 0;
                            dzialanie = ' ';

                        }
                        else
                        {
                            this.Input.Text = "NIE DZIEL PRZEZ ZERO!";
                            num1 = 0;
                            num2 = 0;
                            dzialanie = ' ';
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
            dzialanie = ' ';
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
            if (num2 == 0 && dzialanie == ' ' && this.Input.Text != "")
            {
                num1 = Convert.ToDouble(this.Input.Text)*(-1);
                this.Input.Text = Convert.ToString(num1);
            }
            else if (dzialanie != 0)
            {
                num2 = Convert.ToDouble(this.Input.Text) * (-1);
                this.Input.Text = Convert.ToString(num2);
            }
           
        }
        private void ButPlusClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            isCommaClicked = false;
            if (isOperatorClicked == true)
            {
                dzialanie = '+';
            }
            else
            {
                if (num1 == 0)
                {
                    dzialanie = '+';
                    try
                    {
                        num1 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num1;
                        isOperatorClicked = true;

                    }
                    catch
                    {
                        dzialanie = ' ';
                        num1 = 0;
                    }

                }
                else
                {
                    isOperatorClicked = true;
                    num2 = Convert.ToDouble(this.Input.Text);
                    this.Dzialanie.Text += num2;

                    if (dzialanie == '+')
                    {

                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '-')
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '*')
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '/')
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
                            dzialanie = ' ';
                        }
                    }
                    dzialanie = '+';
                    num2 = 0;
                }
            }
        }
        private void ButMinusClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            isCommaClicked = false;
            if (isOperatorClicked == true)
            {
                dzialanie = '-';
            }
            else
            {
                if (num1 == 0)
                {
                    dzialanie = '-';
                    try
                    {
                        num1 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num1;
                        isOperatorClicked = true;

                    }
                    catch
                    {
                        dzialanie = ' ';
                        num1 = 0;
                    }

                }
                else
                {
                    isOperatorClicked = true;
                    num2 = Convert.ToDouble(this.Input.Text);
                    this.Dzialanie.Text += num2;

                    if (dzialanie == '+')
                    {

                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '-')
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '*')
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '/')
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
                            dzialanie = ' ';
                        }
                    }
                    dzialanie = '-';
                    num2 = 0;
                }
            }
        }
        private void ButMnozClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            isCommaClicked = false;
            if (isOperatorClicked == true)
            {
                dzialanie = '*';
            }
            else
            {
                if (num1 == 0 )
                {
                    dzialanie = '*';
                    try
                    {
                        num1 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num1;
                        isOperatorClicked = true;

                    }
                    catch
                    {
                        dzialanie = ' ';
                        num1 = 0;
                    }

                }
                else
                {
                    isOperatorClicked = true;
                    num2 = Convert.ToDouble(this.Input.Text);
                    this.Dzialanie.Text += num2;
                    if (dzialanie == '+')
                    {

                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '-')
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '*')
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '/')
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
                            dzialanie = ' ';
                        }
                    }
                    dzialanie = '*';
                    num2 = 0;
                }
            }
        }
        private void ButDzielClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            isCommaClicked = false;
            if (isOperatorClicked == true)
            {
                dzialanie = '/';
            }
            else
            {
                if (num1 == 0)
                {
                    dzialanie = '/';
                    try
                    {
                        num1 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num1;
                        isOperatorClicked = true;

                    }
                    catch
                    {
                        dzialanie = ' ';
                    }

                }
                else
                {
                    isOperatorClicked = true;
                    num2 = Convert.ToDouble(this.Input.Text);
                    this.Dzialanie.Text += num2;

                    if (dzialanie == '+')
                    {

                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '-')
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '*')
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);


                    }
                    else if (dzialanie == '/')
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
                            dzialanie = ' ';
                        }
                    }
                    dzialanie = '/';
                    num2 = 0;
                }
            }
        }
        private void But1Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "1";
            }
            else
            {
                this.Input.Text += "1";
                isOperatorClicked = false;
            }

        }
        private void But2Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "2";
            }
            else
            {
                this.Input.Text += "2";
                isOperatorClicked = false;
            }

        }
        private void But3Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "3";
            }
            else
            {
                this.Input.Text += "3";
                isOperatorClicked = false;
            }

        }
        private void But4Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "4";
            }
            else
            {
                this.Input.Text += "4";
                isOperatorClicked = false;
            }

        }
        private void But5Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "5";
            }
            else
            {
                this.Input.Text += "5";
                isOperatorClicked = false;
            }
        }
        private void But6Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "6";
            }
            else
            {
                this.Input.Text += "6";
                isOperatorClicked = false;
            }

        }
        private void But7Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "7";
            }
            else
            {
                this.Input.Text += "7";
                isOperatorClicked = false;
            }
        }
        private void But8Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "8";
            }
            else
            {
                this.Input.Text += "8";
                isOperatorClicked = false;
            }

        }
        private void But9Clicked(object s, RoutedEventArgs e)
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
                this.Input.Text += "9";
            }
            else
            {
                this.Input.Text += "9";
                isOperatorClicked = false;
            }
        }
        private void But0Clicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            if (isOperatorClicked == true)
            {
                this.Input.Text = "";
                isOperatorClicked = false;
                this.Input.Text += "0";
            }
            else
            {
                this.Input.Text += "0";
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
