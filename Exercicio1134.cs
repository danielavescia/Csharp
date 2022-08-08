using System;

namespace Exercicio1134;
internal class Class1
{
    static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        
        int input = int.Parse(Console.ReadLine());

        while(input != 4)
        {
            if (input == 1)
            {
                alcool = alcool + 1;
                input = int.Parse(Console.ReadLine());
            }
           else if (input == 2){
                gasolina = gasolina + 1;
                input = int.Parse(Console.ReadLine());
            }
            else if (input == 3)
            {
                diesel = diesel + 1;
                input = int.Parse(Console.ReadLine());
            }
            else if (input > 4)
            {
                input = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina:" + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }   

    }

