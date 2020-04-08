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
                            this.Input.Text = "NIE DZIEL PRZEZ 0!";
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
            isCommaClicked = false;
        }


        private void ButZnakClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            if (isOperatorClicked == true)
            {
                try
                {
                    num1 = Convert.ToDouble(this.Input.Text);
                    num2 = num1 * (-1);
                }
                catch { }
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
                        this.Input.Text = "NIE DZIEL PRZEZ 0!";
                        num1 = 0;
                        num2 = 0;
                        dzialanie = " ";
                        isCalculated = true;
                    }
                }
                this.Dzialanie.Text += dzialanie;
                this.Dzialanie.Text += num2;
                dzialanie = " ";
                isOperatorClicked = false;
                isCalculated = true;
            }
            else
            {
                try
                {
                    this.Input.Text = Convert.ToString(Convert.ToDouble(this.Input.Text) * (-1));
                    if (Convert.ToDouble(this.Input.Text) == 0.0)
                    {
                        this.Input.Text = "0";

                        isCommaClicked = false;
                    }
                }
                catch
                {
                }
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
            try
            {
                double oryginal = Convert.ToDouble(this.Input.Text);
                int doCalkowitej = (int)Convert.ToDouble(this.Input.Text);
                if (oryginal == doCalkowitej) //ucina kropkę na końcu liczby
                {
                    this.Input.Text = Convert.ToString(oryginal);
                }
                else if (Convert.ToString(oryginal) != this.Input.Text) //usuwa zbędne zera po przecinku
                {
                    this.Input.Text = Convert.ToString(oryginal);
                }
            }
            catch { }
            isCommaClicked = false;
            if (isOperatorClicked == true)
            {
                dzialanie = b.Content.ToString();
            }
            else
            {

                if (num1 == 0 && num2 == 0 && dzialanie != "/")
                {
                    dzialanie = b.Content.ToString();
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
                    try
                    {
                        num2 = Convert.ToDouble(this.Input.Text);
                    }
                    catch { num2 = 0; }
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
                            this.Input.Text = "NIE DZIEL PRZEZ 0!";
                            num1 = 0;
                            num2 = 0;
                            dzialanie = " ";
                            isCalculated = true;
                        }
                    }
                    if (this.Dzialanie.Text.Length >= 60)
                    {
                        this.Dzialanie.Text = Convert.ToString(num1);

                    }
                    dzialanie = b.Content.ToString();
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
            {   if(this.Dzialanie.Text!= "")
                this.Dzialanie.Text += dzialanie;
                this.Input.Text = "";
                isOperatorClicked = false;
                try
                {
                    if (Convert.ToDouble(this.Input.Text) == 0 && isCommaClicked == false)
                    {
                        this.Input.Text = b.Content.ToString();
                    }
                    else
                    {
                        this.Input.Text += b.Content.ToString();
                    }
                }
                catch
                {
                    this.Input.Text = b.Content.ToString();
                }
            }
            else
            {
                isOperatorClicked = false;
                try
                {
                    if (Convert.ToDouble(this.Input.Text) == 0.0 && isCommaClicked==false)
                    {
                        this.Input.Text = b.Content.ToString();
                    }
                    else
                    {
                        this.Input.Text += b.Content.ToString();
                    }
                }
                catch
                {
                    this.Input.Text = b.Content.ToString();
                }
            }
        }

        private void ButDotClicked(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            try
            {
                double oryginal = Convert.ToDouble(this.Input.Text);
                int doCalkowitej = (int)Convert.ToDouble(this.Input.Text);

                if (doCalkowitej != oryginal)
                {

                    isCommaClicked = true;
                }
                else
                {
                    isCommaClicked = false;
                    this.Input.Text = Convert.ToString(oryginal);
                }

            }
            catch
            {
                if (this.Input.Text == "NIE DZIEL PRZEZ 0!")
                {
                    isCommaClicked = true;
                }
            }

            if (isOperatorClicked == true)
            {
                this.Dzialanie.Text += dzialanie;
                this.Input.Text = "";
                isOperatorClicked = false;
                this.Input.Text = "0.";
                isCommaClicked = true;

            }
            else if (isCommaClicked == false)
            {
                if (this.Input.Text != "")
                {
                    this.Input.Text += ".";
                }
                else
                {
                    this.Input.Text = "0.";
                }
                isCommaClicked = true;
            }
        }
    }
}
