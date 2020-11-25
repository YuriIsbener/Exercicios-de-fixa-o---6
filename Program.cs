using System;

namespace Exercicios_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            for (var i = 0; i < 10; i++)
            {
                Console.Write("Insira um nome: ");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Que nome gostaria de consultar?");
            string comparacao = Console.ReadLine().ToLower();
            int contador = 0;

            while (contador<10)
            {
                contador++;
            if (nomes[contador] == comparacao)
            {
                Console.WriteLine("Achei");
            }
            else
            {
                Console.WriteLine("Não achei");
            }
            }
        }
    }
}
