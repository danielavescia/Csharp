using System;
using System.Globalization;

namespace exercicio1061
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, notaexame, media, mediaexame;

            string[] notas = Console.ReadLine().Split(' ');
            nota1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = (nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4 * 1)/ 10;

            if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }

            else if (media >= 5.0 && media < 6.9)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                notaexame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaexame = (media + notaexame) / 2;
                Console.WriteLine("Nota do exame: " + notaexame.ToString("F1", CultureInfo.InvariantCulture));

                if (mediaexame < 5.0)
                {
                    Console.WriteLine("Aluno reprovado");
                    Console.WriteLine("Media final:" + mediaexame.ToString("F1", CultureInfo.InvariantCulture));
                    
                }
                else
                {
                    Console.WriteLine("Aluno aprovado");
                    Console.WriteLine("Media final:" + mediaexame.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        } 
    } 
}

            

