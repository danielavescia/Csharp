using System;
using System.Globalization;

namespace exercicio1012
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;
            double A, B, C, a_triang, a_circ, a_trap, a_quad, a_ret;
          
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

          a_triang = A * C / 2;
          a_circ = PI * (Math.Pow(C, 2));
          a_trap = ((A + B) * C) / 2;
          a_quad = Math.Pow(B, 2);
          a_ret = A * B;

          Console.WriteLine("TRIANGULO: " + a_triang.ToString("F3", CultureInfo.InvariantCulture));
          Console.WriteLine("CIRCULO: " + a_circ.ToString("F3", CultureInfo.InvariantCulture));
          Console.WriteLine("CIRCULO: " + a_trap.ToString("F3", CultureInfo.InvariantCulture));
          Console.WriteLine("QUADRADO  " + a_quad.ToString("F3", CultureInfo.InvariantCulture));
          Console.WriteLine("RETANGULO: " + a_ret.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
