using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num1 = null;
            //string num2 = null;
            //Button add = new Button();
            Console.WriteLine("Please enter your first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your operator(-,+,*,/) : ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter your second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //void  pageLoad(Object sender, EventArgs e)
            // {
            //     add.Click += new EventHandler(this.addClicked);
            // 
            operation(num1, num2, oper);
        }
        static void operation(int num1, int num2, char oper)
        {
            int answer = 0;
            if (oper == '-')
            {
                answer = num1 - num2;
            }
            else if (oper == '+')
            {
                answer = num1 + num2;
            }
            else if (oper == '*')
            {
                answer = num1 * num2;
            }
            else if (oper == '/')
            {
                answer = num1 / num2;
            }

            Console.WriteLine("The answer of this is : " + answer);
            CheckAnythingElse(num1, num2, oper, answer);
        }
        static void CheckAnythingElse(int num1, int num2, char oper, int answer)
        {
            Console.WriteLine("Do you want to perform anything else on the current answer?(y/n) ");
            string check = (Console.ReadLine());
            if (check == "Y" || check == "y")
            {
                NextOperation(num1, num2, oper, answer);
            }
        }
        static void NextOperation(int num1, int num2, char oper, int answer)
        {
            num1 = answer;
            Console.WriteLine("Enter the new operator you want to use ? ");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the new number want to use? ");
            num2 = Convert.ToInt32(Console.ReadLine());
            operation(num1, num2, oper);
        }
    }
}





 /*//InitializeComponent();
            int oper = 0;
            // if the operate has been choosen then if its 
                //*  divide oper = 4
                //*  multiply oper =3
                //*  subtract oper = 2
                //*  add oper = 1
                //*  if none oper will = 0


        }

        private void clear_Click(object sender, EventArgs e)
        {

        }




        private void zero_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "0";
            }
            else
            {
                num1 = num1 + "0";
            }

        }

        private void one_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "1";
            }
            else
            {
                num1 = num1 + "1";
            }


        }

        private void two_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "2";
            }
            else
            {
                num1 = num1 + "2";
            }
        }

        private void three_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "3";
            }
            else
            {
                num1 = num1 + "3";
            }
        }

        private void four_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "4";
            }
            else
            {
                num1 = num1 + "4";
            }

        }

        private void five_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "5";
            }
            else
            {
                num1 = num1 + "5";
            }

        }

        private void six_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "6";
            }
            else
            {
                num1 = num1 + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "7";
            }
            else
            {
                num1 = num1 + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "8";
            }
            else
            {
                num1 = num1 + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + "9";
            }
            else
            {
                num1 = num1 + "9";
            }
        }

        private void point_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            if (oper > 0)
            {
                num2 = num2 + ".";
            }
            else
            {
                num1 = num1 + ".";
            }
        }

        private void equal_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            Console.WriteLine("num 1 is " + num1 + " num 2 is " + num2);
            double num1New = Convert.ToDouble(num1);
            double num2New = Convert.ToDouble(num2);
            if (oper == 1)
            {
                addFunction(num1New, num2New);
            }
            else if (oper == 2)
            {
                subtractFunction(num1New, num2New);
            }
            else if (oper == 3)
            {

                multiplyFunction(num1New, num2New);
            }
            else if (oper == 4)
            {
                divideFunction(num1New, num2New);
            }
            else
            {
                Console.WriteLine("You havent inputted an operator. Please try again");
                // CalcForm1.MessageBox("You havent inputted an operator. Please try again");
            }
        }

        private void add_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            oper = 1;
        }

        private void subtract_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            oper = 2;
        }

        private void multiply_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            oper = 3;
        }

        private void divide_Click(object sender, EventArgs e, int oper, string num1, string num2)
        {
            oper = 4;

        }

        static void addFunction(double num1New, double num2New)
        {
            double answer = num1New + num2New;
        }
        static void subtractFunction(double num1New, double num2New)
        {
            double answer = num1New - num2New;
        }
        static void multiplyFunction(double num1New, double num2New)
        {
            double answer = num1New * num2New;
        }
        static void divideFunction(double num1New, double num2New)
        {
            double answer = num1New / num2New;
        }*/























    