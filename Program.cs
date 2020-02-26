using System;
using Prime.Models;

namespace Prime 
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            int result = Int32.Parse(number);
            // Console.WriteLine(Sifting.IsPrime(result));
            Sifting.PrintPrimes(result);
            // Console.WriteLine(Sifting.PrintPrimes(result));
        }
    }
}