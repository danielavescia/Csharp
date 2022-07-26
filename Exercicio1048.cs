using System;
using System.Globalization;

namespace exercicio1048
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double salario, novosalario, reajuste, porcentual;            

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00){
                porcentual = 15.0;
            } else if (salario <= 800.0){
                porcentual = 12.0;    
            } else if (salario <= 1200.0){
                porcentual = 10.0;
            } else if (salario <= 2000.0){ 
                porcentual = 7.0;
            } else {
                porcentual = 4.0;
            }

            reajuste = (porcentual / 100.0) * salario;
            novosalario = reajuste + salario;

            Console.WriteLine("Novo salario: " + novosalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + porcentual.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}
