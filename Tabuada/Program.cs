using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor: ");
            int valor = int.Parse(Console.ReadLine());
            int resul;

            for (int i = 1; i <= valor; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    resul = i * j;
                    Console.WriteLine(j + " x " + i + " = " + resul);
                }
            }

        }
    }
}
