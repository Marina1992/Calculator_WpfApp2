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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        double num1 = 0;// поле (1 число)
        double num2 = 0;// поле (2 число)
        string op = "";// операция, которую ввел пользователь  
        public MainWindow()
        {
            InitializeComponent();
        }

        // 1 окно
        private void btn_num_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            String num = button.Content.ToString();

            if (txtValue.Text == "0")
                txtValue.Text = num;
            else
                txtValue.Text += num;


            if (op == "") // если операция отсутствовала, то работали с num1

            {

                num1 = Double.Parse(txtValue.Text);
            }

            else
            {
                num2 = Double.Parse(txtValue.Text);


            }
        }




        //2окно

        private void btn_num__Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            String num = button.Content.ToString();

            if (txtValue2.Text == "0")
                txtValue2.Text = num;
            else
                txtValue2.Text += num;


            if (op == "") // если операция отсутствовала, то работали с num1

            {

                num1 = Double.Parse(txtValue2.Text);
            }

            else
            {
                num2 = Double.Parse(txtValue2.Text);


            }
        }






       // 1 окно

        private void btn_op_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            op = button.Content.ToString();
            txtValue.Text = " ";
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "√x":
                    result = Math.Sqrt(num1);
                    break;

                case "1/x":
                    result = 1 / num1;
                    break;

                case "%":
                    result = num1 * num2 / 100;
                    break;

                case "x^2":
                    result = Pow(num1);
                    break;



            }





            txtValue.Text = result.ToString();
            op = ""; // обнулить операцию
            num1 = result;
            num2 = 0;
        }


        // 2 окно

        private void btn_op__Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            op = button.Content.ToString();
            txtValue2.Text = " ";


        }

        private void btn_eq__Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "√x":
                    result = Math.Sqrt(num1);
                    break;

                case "1/x":
                    result = 1 / num1;
                    break;

                case "%":
                    result = num1 * num2 / 100;
                    break;

                case "x^2":
                    result = Pow(num1);
                    break;
                case "x^y":
                    result = Math.Pow(num1, num2);
                    break;
                case "log":
                    result = Math.Log(num1, Math.E);
                    break;

                case "ln":
                    result = Math.Log(num1);
                    break;

                case "|x|":
                    result = Math.Abs(num1);
                    break;
                case "10^x":
                    result = Math.Pow(10, num1);
                    break;
                case "exp":
                    result = Math.Exp(num1);
                    break;

                case "n!":
                    result = Fact(num1);
                    break;

                case "sin":
                    result = SIN(num1);
                    break;

                case "cos":
                    result = COS(num1);
                    break;


                case "tg":
                    result = TG(num1);
                    break;

                case "ctg":
                    result = 1 / TG(num1);
                    break;


            }

            txtValue2.Text = result.ToString();
            op = ""; // обнулить операцию
            num1 = result;
            num2 = 0;
        }





        private double Pow(double x)
        {

            double result = 1;
            for (int i = 1; i <= 2; i++)
            {
                result = result * x;
            }
            return result;
        }

        private double Fact(double x)
        {
            double result = 1;
            for (int i = 2; i <= x; i++) 
            {
                result = result * i;
            }
            return result;

        }

        private double SIN(double x)

        {

            double gradus = x;
            double radian = gradus * Math.PI / 180;

            return Math.Sin(radian);
        }


        private double COS(double x)

        {

            double gradus = x;
            double radian = gradus * Math.PI / 180;

            return Math.Cos(radian);
        }

        private double TG(double x)

        {

            double gradus = x;
            double radian = gradus * Math.PI / 180;

            return Math.Tan(radian);
        }





        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            txtValue.Text = "0";
        }

        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = 0;
            }
            else
            {
                num2 = 0;
            }
            txtValue.Text = "0";
        }


        // 2 окно

        private void btn_CE__Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = 0;
            }
            else
            {
                num2 = 0;
            }
            txtValue2.Text = "0";
        }



        private void btn_backspc_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = DropLastChar(txtValue.Text);
            if (op == "")
            {
                num1 = Double.Parse(txtValue.Text);


            }

            else
            {
                num2 = Double.Parse(txtValue.Text);

            }
        }

        private string DropLastChar(string text)
        {
            if (text.Length == 1)
                text = "0";

            else
            {
                text = text.Remove(text.Length - 1, 1);
                if (text[text.Length - 1] == ',')

                    text = text.Remove(text.Length - 1, 1);

            }
            return text;
        }





        //2 окно

        private void btn_backspc__Click(object sender, RoutedEventArgs e)
        {
            txtValue2.Text = DropLastChar(txtValue2.Text);
            if (op == "")
            {
                num1 = Double.Parse(txtValue2.Text);


            }

            else
            {
                num2 = Double.Parse(txtValue2.Text);

            }
        }



        private void btn_plusminus_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = num1 * -1;
                txtValue.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * -1;
                txtValue.Text = num2.ToString();

            }
        }

        // 2 окно 

        private void btn_plusminus__Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = num1 * -1;
                txtValue2.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * -1;
                txtValue2.Text = num2.ToString();

            }
        }






        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                SetComma(num1);
            else
                SetComma(num2);
        }

        private void SetComma(double num)
        {


            if (txtValue.Text.Contains(','))
                return;

            txtValue.Text += ',';
        }

        //2 окно
        private void btn_comma__Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                SetComma2(num1);
            else
                SetComma2(num2);
        }
        private void SetComma2(double num)
        {


            if (txtValue2.Text.Contains(','))
                return;

            txtValue2.Text += ',';
        }


    }
}
