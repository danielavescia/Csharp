namespace exercicio1041
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double x, y;

            string[] valores = Console.ReadLine().Split(' ');
            x = double.Parse(valores[0], CultureInfo.InvariantCulture);    
            y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x > 0 && y < 0)            
                Console.WriteLine("Q4");
            else if (x > 0 && y > 0) 
                Console.WriteLine("Q1");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");               
            else
                Console.WriteLine("Origem");
        }
    }
}
