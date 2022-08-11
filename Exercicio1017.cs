using System;
using System.Globalization;

namespace exercicio1017
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int distancia;
            double litros;
            double consumo = 12.0;

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            distancia = x * y;
            litros = distancia / consumo;
            
            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
