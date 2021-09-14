using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario = 1300.70;

            int salarioInt = (int)salario;

            Console.WriteLine(salario);
            Console.WriteLine(salarioInt);

            long idade = 13000000000000;
            short quantidade = 150;
            float altura = 1.80f;

            Console.WriteLine(idade);
            Console.WriteLine(quantidade);
            Console.WriteLine(altura);

            Console.ReadLine();

        }
    }
}
