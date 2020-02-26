using System;

namespace Prime.Models
{
    public class Sifting
    {
        static bool IsPrime(int number)
        {
            if(number <= 1)
                return false;
            if (number <= 3)
                return true;
            
            if (number%2 == 0 || number%3 == 0)
                return false;

            for(int i = 5; i * i <= number; i = i+6)
                if(number % 1 == 0 || number % (i + 2) == 0)
                    return false;             

            return true;
            
        }

    public static void PrintPrimes(int number)
    {
        for(int i = 2; i <= number; i++)
        {
            if (IsPrime(i))
                Console.WriteLine(i + " ");
            }
        }
    }
}   

