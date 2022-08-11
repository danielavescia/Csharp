using System;
using System.Globalization;

namespace exercicio1010
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int Qnt1, Qnt2, Peca1, Peca2;
            double Preco1, Preco2, ValorTotal;

            string [] valores = Console.ReadLine().Split(' ');
            Peca1 = int.Parse(valores[0]);
            Qnt1 = int.Parse(valores[1]);
            Preco1 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            Peca2 = int.Parse(valores[0]);
            Qnt2 = int.Parse(valores[1]);
            Preco2 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            ValorTotal = Qnt1 * Preco1 + Qnt2 * Preco2;


            Console.WriteLine("VALOR A PAGAR: R$ " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));

        } 
    } 
}
