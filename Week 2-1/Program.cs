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
            Console.WriteLine("Interest Calculator Program"); //Calculator

            double principal, rate, time, Intreast; // double

            Console.WriteLine("What is princaipal amount of the loan in dollars?"); // the amount of dollars
            principal = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("What is intrest rate (input 0.05 for 5%)?");// the intrest rate
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is period of loan in years?"); // loan period
            time = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(Intreast = principal * rate * time); // the calculation

            Console.WriteLine("Total intrest of loan is:" + Intreast + " dollars"); // the total of the intreast
        }
    }
}
