using System;
using System.Globalization;


namespace exercicio1005
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double peso_A = 3.5;
            double peso_B = 7.5;


            double MEDIA_1 = (peso_A * A) + (peso_B * B);
            double MEDIA_2 = MEDIA_1 / (peso_A + peso_B);

            Console.WriteLine("MEDIA = " + MEDIA_2.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
