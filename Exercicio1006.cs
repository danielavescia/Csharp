using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        
            double a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            int PESO_A = 2;
            int PESO_B = 3;
            int PESO_C = 5;

           double calculo_1 = (a * PESO_A) + (b * PESO_B) + (c * PESO_C);
           double calculo_2 = calculo_1 / (PESO_A + PESO_B + PESO_C);

           Console.WriteLine("MEDIA = " + calculo_2.ToString("F1", CultureInfo.InvariantCulture));

    }

}
