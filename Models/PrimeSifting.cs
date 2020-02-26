using System;

namespace Prime.Models
{
    public class Sifting
    {
        public static void IsPrime(int n)
        {
            bool[] prime = new bool[n+1]; 
          
            for(int i = 0; i < n; i++) 
              prime[i] = true; 

            // Console.WriteLine("-----first loop-----");
            // foreach(bool i in prime)
            // Console.WriteLine(i);
            // Console.WriteLine("-----first loop-----");

            for(int p = 2; p*p <= n; p++) 
            { 
              // If prime[p] is not changed, 
              // then it is a prime 
              if(prime[p] == true) 
              
              // Console.WriteLine("-----second loop-----");
              // foreach(bool i in prime)
              // Console.WriteLine(i);
              // Console.WriteLine("-----second loop-----"); 
              { 
                  // Update all multiples of p 
                  for(int i = p*p; i <= n; i += p) 
                      
                      prime[i] = false;
                      // Console.WriteLine("---p----");
                      // Console.WriteLine(p);

                  // Console.WriteLine("-----third loop-----");
                  // foreach(bool i in prime)
                  // Console.WriteLine(i);
                  // Console.WriteLine("-----third loop-----"); 
              } 
          } 
        //Print all primes
        for(int i = 2; i <= n; i++) 
        { 
            if(prime[i] == true) 
                Console.WriteLine(i); 
        } 
} }  
}
