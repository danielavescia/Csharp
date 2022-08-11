using System;
using System.Globalization;


namespace exercicio1010
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            double r, PI, C, volume;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PI = 3.14159;
            C = (4.0 / 3);
            volume = (C) * PI * (Math.Pow(r, 3));

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
