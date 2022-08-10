using System;
using System.Globalization;

namespace Exercicio1159;
internal class Class1
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        int tabuada;

        for (i = 1; i <= 10; i++)
        {
            tabuada = i * n;
            Console.WriteLine(i + " x " + n + " = " + tabuada);

        }

    }
}
