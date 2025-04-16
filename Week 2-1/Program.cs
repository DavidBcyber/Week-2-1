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
            Console.WriteLine("Interest Calculator Program");

            double principal, rate, time, Intreast;

            Console.WriteLine("What is princaipal amount of the loan in dollars?");
            principal = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("What is intrest rate (input 0.05 for 5%)?");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is period of loan in years?");
            time = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(Intreast = principal * rate * time);

            Console.WriteLine("Total intrest of loan is:" + Intreast + " dollars");
        }
    }
}
