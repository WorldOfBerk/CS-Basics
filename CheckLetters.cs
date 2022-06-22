using System;

namespace String
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string myInput = string.Empty;
            bool check = false; 
            
            while (check is false)
            {
                Console.WriteLine("Enter letters and numbers ONLY > ");
                myInput = Console.ReadLine();
                
                for (int i = 0; i < myInput.Length; i++)                  
                {
                    if (Char.IsLetter(myInput[i]))
                    {
                        check = true;
                    }

                    else if (Char.IsNumber(myInput[i]))
                    {
                        check = true;
                    }
                    
                    else if (myInput[i] == ' ')
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        Console.WriteLine("Wrong input. \"{0}\" is not the wanted!", myInput[i]);
                        Console.WriteLine("Please try again");
                        
                        break;        
                    } 
                    
                }
            } 
            Console.WriteLine("Input Approved: \"{0}\"", myInput);
            Console.WriteLine("Welcome: \"{0}\"", myInput);
        }
    }
}
