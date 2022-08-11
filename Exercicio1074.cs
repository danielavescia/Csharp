using System;

namespace exercicio1074
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;

            for (i = 0; i < n; i++){
                int x = int.Parse(Console.ReadLine());
                i = i + 0;

                if (x == 0)
                    Console.WriteLine("NULL");

                else if (x < 0 && x % 2 == 0)
                    Console.WriteLine("EVEN NEGATIVE");
                 
                else if (x > 0 && x % 2 == 0)
                    Console.WriteLine("EVEN POSITIVE");

                else if (x < 0 && x % 2 != 0)
                    Console.WriteLine("ODD NEGATIVE");

                else if (x > 0 && x % 2 != 0)
                    Console.WriteLine("ODD POSITIVE");
               
                }
        }

        }
    }
