﻿using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2, criando variaveis");

            int idade = 32;
            Console.WriteLine(idade);
            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Execução finalizada, tecle 'enter' para sair.");
            Console.ReadLine();
        }
    }
}
