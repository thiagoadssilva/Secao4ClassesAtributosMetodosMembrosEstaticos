using System;
using System.Globalization;

namespace CorrecaoExerciciosFixacaoUm // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.ALtura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + retangulo.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERÍMETRO: " + retangulo.Perimentro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL: " + retangulo.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}