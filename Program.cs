using System;

namespace Excercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exe-03 Aumento de salario para os funcionários");
            Console.WriteLine("");

            Console.WriteLine("Digite o salário do funcionário:");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("");

             if(salario >= 500.00) {
                double aumento = salario * 0.3;
                double novoSalario = salario + aumento;

                Console.WriteLine("O salário será reajustado para: " + novoSalario + " reais.");

             }else{
                 Console.WriteLine("O salárionão será reajustado.");
             }

           
        }
    }
}
