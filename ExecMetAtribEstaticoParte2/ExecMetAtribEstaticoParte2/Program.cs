﻿using System;
using System.Globalization;

namespace ExecMetAtribEstaticoParte2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);


            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}