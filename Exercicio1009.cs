using System;
using System.Globalization;


namespace exercicio1009
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            string Nome = Console.ReadLine();
            double Salario_Fixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Comissao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Salario_Final = Comissao * 15/100 + Salario_Fixo;

            Console.WriteLine("TOTAL = R$ " + Salario_Final.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
