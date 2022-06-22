using System;
using System.Collections.Generic;

namespace SomaImparesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a qtde N de casos: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 1; j <= n; j++)
            {

                List<int> list = new List<int>();

                Console.Write("Digite um inteiro X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Digite um inteiro Y: ");
                int y = int.Parse(Console.ReadLine());
           

                int inicioList = x + 1;
                int terminoList = (y - 1);

                for (int i = inicioList; i <= terminoList; i++)
                {
                    list.Add(i);
                }

                int soma = 0;
                foreach (int numero in list)
                {


                    if (numero % 2 != 0)
                    {
                        soma += numero;
                    }
                }

                Console.WriteLine($"A soma dos números ímpares neste intervalo aberto é: {soma}");


            }
        }
    }
}
