using System;

namespace exercicio1046
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int inicio;
            int fim;
            int duracao;

            string[] vet = Console.ReadLine().Split(' ');
            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            if (inicio >= fim)
            {
                duracao = 24 - inicio + fim;
                Console.WriteLine("O JOGO DUROU " + duracao + "HORA(S)");
            }
            else if (fim > inicio)
            {
                duracao = fim - inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }

        }

    }
}
