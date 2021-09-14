using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3, criando variaveis ponto flutuante.");

            double salario = 1200.70;
            Console.WriteLine(salario);

            double idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("Execução finalizada. Tecle 'enter' para sair.");
            Console.ReadLine();
        }
    }
}
