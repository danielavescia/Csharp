using System;

namespace exercicio1072
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int contIn = 0;
            int contOut = 0;


            for (i = 0; i <= n; i++)
            {
               n = int.Parse(Console.ReadLine());

                if (n >= 10 && n <= 20)
                {
                    contIn = contIn+1;
                }
                else
                {
                    contOut = contOut+1;
                }
            }
            Console.WriteLine(contIn + "in");
            Console.WriteLine(contOut + "out");
        }
    }
}
