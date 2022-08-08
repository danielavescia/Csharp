using System;

namespace Exercicio1159;
internal class Class1
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int somaPar = 5 * x + 20;
        int somaImpar = 5 * (x+1) + 20;

        while (x != 0)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(somaPar);
                break;
            }
            else
            {
                Console.WriteLine(somaImpar);
                break;
            }

        }
    }

}
