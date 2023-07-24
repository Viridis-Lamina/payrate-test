using System;

namespace payrate 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter your payrate");
            Console.WriteLine();

            Console.ReadLine();

            double Payrate = double.Parse(Console.ReadLine());

            if (Payrate < 7.50 || Payrate > 49.00) 
            {
                Console.WriteLine("Invalid rate");

            
            }
            else
            {
                Console.WriteLine("The rate is Valid");
            }



        }
    }
}