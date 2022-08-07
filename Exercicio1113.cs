using System;

namespace Exercicio1113;

internal class Class1
{
    static void Main(string[] args)
    {

    string[] input = Console.ReadLine().Split(' ');
    int x = int.Parse(input [0]);
    int y = int.Parse(input [1]);

        while (x != y) {
            if (x < y) { 
            Console.WriteLine("Crescente"); 
            }
                else {
                Console.WriteLine("Decrescente"); 
            }

            input = Console.ReadLine().Split(' ');
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);
        }
        
    }
}
