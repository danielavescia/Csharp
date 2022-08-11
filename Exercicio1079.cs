using System;
using System.Globalization;
namespace exercicio1079
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            double soma;
            

            for (i=0; i < n; i++){
              string[] input = (Console.ReadLine().Split(' '));
              double x = double.Parse(input[0], CultureInfo.InvariantCulture);
              double y = double.Parse(input[1], CultureInfo.InvariantCulture);
              double z = double.Parse(input[2], CultureInfo.InvariantCulture);

              i = i ++;
              soma = (x*2 + y*3 + z*5)/10.0;

            Console.WriteLine(soma.ToString("F1"));
            }
            
        }
    }
}
