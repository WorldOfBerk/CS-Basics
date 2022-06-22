using System;

namespace Alphabetic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int l, i, j;
            string temp;
            
            Console.WriteLine("How many student information do you want to enter > ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[size];
            int[] number = new int[size];
            
            for(i = 0; i < size; i++){
                Console.WriteLine("Enter the " + (i+1) + ". student name > ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter the "+ (i+1) + ". student number > ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            l = name.Length;	

            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l-1; j++)
                {
                    if (name[j].CompareTo(name[j + 1]) > 0)
                    {
                        temp = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = temp;
                    }
                }
            }
            Console.Write("\n\nAfter sorting the array : \n");
            for (i = 0; i < l; i++)
            {
                Console.WriteLine(name[i] + ", " + number[i]);
            }
        }
    }
}
