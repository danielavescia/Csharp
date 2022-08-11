using System;

namespace exercicio1020
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int ano, mes, dias, resto;

            int x = int.Parse(Console.ReadLine());

            ano = x / 365;
            resto = x % 365;
            mes = resto / 30;
            dias = resto % 30;

            Console.WriteLine(ano.ToString() + " ano(s)");
            Console.WriteLine(mes.ToString() + " mes(es)");
            Console.WriteLine(dias.ToString() + " dias");
        }
    }
}
