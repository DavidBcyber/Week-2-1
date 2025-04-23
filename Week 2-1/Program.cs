using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interest Calculator Program"); //This a calculator to find the interest

            double principal, rate, time, Interest; // these are the objects to find the total intreast

            Console.WriteLine("What is the principal amount of the loan in dollars?"); // The amount for the principal that you are borrowing for the loan amount
            principal = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("What is interest rate (input 0.05 for 5%)?");//the amount of rate you enter turns into a percentage to find the interest
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the period of the loan in years?"); //this is the number of years that you have to pay
            time = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(Interest = principal * rate * time); // this is the equation that helps you to find the total interest

            Console.WriteLine("Total interest of loan is:" + Interest + " dollars"); // The display for the total interest that you have to pay
        }
    }
}
