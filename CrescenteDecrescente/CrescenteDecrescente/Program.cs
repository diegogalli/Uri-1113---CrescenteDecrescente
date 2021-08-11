using System;

namespace CrescenteDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] dados = Console.ReadLine().Split(' ');
            x = int.Parse(dados[0]);           
            y = int.Parse(dados[1]);           

            while ( x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                dados = Console.ReadLine().Split(' ');
                x = int.Parse(dados[0]);
                y = int.Parse(dados[1]);

            }

        }
    }
}
