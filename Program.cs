using System;
using System.Globalization;

namespace FormulaBaskara
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            double b;
            double c;
            
            Console.WriteLine("Digite o valor de A:");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de B:");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de C");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2) - 4.0 * a * c; // Math.Pow(b, 2) se usa o "math.pow para calcular potencia;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);


            Console.Write($"O valor de A é {a.ToString("F2")}. ");
            Console.Write($"O valor de B é {b.ToString("F2")}. ");
            Console.Write($"O valor de C é {c.ToString("F2")}.");

            Console.WriteLine();

            Console.WriteLine($"O valor do Delta é {delta}.");
            Console.WriteLine($"O valor da primeira raiz é {x1}.");
            Console.WriteLine($"O valor da segunda raiz é {x2}.");





        }
    }
}
