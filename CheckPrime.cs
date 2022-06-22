using System;

namespace PrimeNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n, i;
            int m = 0;
            int test = 0;
            string ans = null;
            
            A:
            Console.Write("Enter the number to check Prime: ");    
            n = Convert.ToInt32(Console.ReadLine());  
            
            m=n/2;    
            
            for(i = 2; i <= m; i++)    
            {    
                if(n % i == 0)    
                {    
                    Console.WriteLine(n + " is not Prime!!");    
                    test = 1;
                    Console.WriteLine("Do you want to try another number? Y|N");
                    ans = Console.ReadLine();
                    if (ans == "Y")
                    {
                        goto A;
                    }
                    if (ans == "N")
                    {
                        Console.WriteLine("See you ^_^");
                    }
                }    
            }    
            
            if (test ==0) 
                Console.WriteLine(n + " is Prime!");
            
            Console.WriteLine("Do you want to try another number? Y|N");
            ans = Console.ReadLine();
           
            if (ans == "Y")
            {
                goto A;
            }
            
            else if (ans == "N")
            {
                Console.WriteLine("See you ^_^");
            }
        }
    }
}
