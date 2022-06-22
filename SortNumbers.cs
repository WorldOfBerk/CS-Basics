using System;

namespace SortNumbers
{
    internal class Program
    { 
        static void MySort(int[] arr, int n)
            {
                int k, i;

                for (k = 0; k < n; k++)
                {
                    for (int l = k + 1; l < n; l++)
                    {
                        if (arr[k] > arr[l])
                        { 
                            int temp = arr[k];
                            arr[k] = arr[l];
                            arr[l] = temp;
                        }
                    }
                }

                Console.WriteLine("Ascending order > ");
                for(i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            static void MyDescending(int[] arr, int n)
            {
                int k, i;

                for (k = 0; k < n; k++)
                {
                    for (int l = k + 1; l < n; l++)
                    {
                        if (arr[k] < arr[l])
                        {
                            int temp = arr[k];
                            arr[k] = arr[l];
                            arr[l] = temp;
                        }
                    }
                }
                Console.WriteLine("Descending order > ");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            
            public static void Main(string[] args)
            {
                Console.Write("How many elements do you want to enter > ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
            
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter " + i + ". number >");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            
                MySort(arr, n);
            
                MyDescending(arr, n);

                Console.ReadKey();
            }
        }
    }
