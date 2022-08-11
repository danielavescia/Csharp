using System;

namespace exercicio1073
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int i = 2;

            for (i= 2;i <= n; i++) { 

            if(i%2 == 0){

                 Console.WriteLine(i + "^" + "2 = " + Math.Pow(i, 2));
            }

            }
        }
    }
}
