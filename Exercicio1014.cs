using System;
using System.Globalization;

namespace exercicio1014
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            int distancia;
            double combustivel, consumo;


            distancia = int.Parse(Console.ReadLine());
            combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consumo = distancia / combustivel;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");



        }
    }
}

