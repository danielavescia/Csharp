using System;
using System.Globalization;

namespace exercicio1008
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int id_funcionario = int.Parse(Console.ReadLine());
            int horas_trabalhadas = int.Parse(Console.ReadLine());
            double valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valor_hora * horas_trabalhadas;

            Console.WriteLine("NUMBER = " + id_funcionario.ToString());
            Console.WriteLine("SALARY = $ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
