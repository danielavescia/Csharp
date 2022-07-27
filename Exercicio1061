using System;

namespace exercicio1061
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int diasI, horasI, minutosI, segundosI, diasF, horasF, minutosF, segundosF, inicio, fim,total, dias, horas, minutos, segundos, resto1, resto2;

            string[] data = Console.ReadLine().Split(' ');
            diasI = int.Parse(data[1]);

            string[] horario = Console.ReadLine().Split(" : ");
            horasI = int.Parse(horario[0]);
            minutosI = int.Parse(horario[1]);
            segundosI = int.Parse(horario[2]);

            string[] dataf = Console.ReadLine().Split(' ');
            diasF = int.Parse(dataf[1]);

            string[] horariof = Console.ReadLine().Split(" : ");
            horasF = int.Parse(horariof[0]);
            minutosF = int.Parse(horariof[1]);
            segundosF = int.Parse(horariof[2]);

            inicio = diasI * 86400 + horasI * 3600 + minutosI * 60 + segundosI;
            fim = diasF * 86400 + horasF * 3600 + minutosF * 60 + segundosF;
            total = fim - inicio;

            dias = total / (86400);
            resto1 = total % 86400;
            resto2 = resto1 % (60 * 60);
            horas = resto1 / 3600;
            minutos = resto2 / 60;
            segundos = resto2 % 60;


            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");
        }
    }
}
