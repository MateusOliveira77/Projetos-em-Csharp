using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.00;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1.ToString("F2")}.");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}.");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {preco3}.");
            Console.WriteLine($"Arredondado (três casas decimais): {preco3.ToString("F3")}.");
            Console.WriteLine($"Separador decimal invariant culture: {preco3.ToString("F3", CultureInfo.InvariantCulture)}.");

        }
    }
}
