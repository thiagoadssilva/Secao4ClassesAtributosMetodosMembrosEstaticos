using System;
using System.Globalization;

namespace CorrecaoExerciciosFixacaoDois // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("informe o seu nome:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe seu salario:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o imposto");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Funcionário: " + funcionario.Nome + " $ " + funcionario.SalarioLiquido().ToString("F2"));
            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(percent);

            Console.Write("Dados atualizados: " + funcionario.Nome + ", $ " + funcionario.SalarioLiquido().ToString("F2"));
            

        }
    }
}