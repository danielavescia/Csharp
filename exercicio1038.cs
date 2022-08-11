using System;
using System.Globalization;

namespace exercicio1038
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double conta;
            int cod, qnt;

            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            qnt = int.Parse(vet[1]);

            

            if (cod == 1)
            {
                conta = 4.00 * qnt;
                Console.WriteLine("Total: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 2)
            {
                conta = 4.50 * qnt;
                Console.WriteLine("Total: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 3)
            {
                conta = 5.0 * qnt;
                Console.WriteLine("Total: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 4)
            {
                conta = 2.0 * qnt;
                Console.WriteLine("Total: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 5){ 
                conta = 1.50* qnt;
                Console.WriteLine("Total: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
        
        }
    }
}
