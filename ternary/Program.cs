using System;
using System.Collections.Generic;
using System.Linq;

namespace ternary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listas = new List<string>();
            List<int> listasinteiras = new List<int>();

            Random aleatorio = new Random();
            string[] nomes = new string[] { "janelton", "vieira", "thokozile", "tunilson", "samuel", "gemima" };


            for (int i = 0; i < 10; i++)
            {
                int indexealeatyorio = aleatorio.Next(nomes.Length);
                listas.Add(nomes[indexealeatyorio]);
                listasinteiras.Add(indexealeatyorio);
            }

            foreach (var item in listas)
            {
                //exibir a lista
                Console.WriteLine(item);
            }
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            string finditem = listas.Find(janelton => janelton == "9");
            Console.WriteLine("\n" + finditem);


            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            // Contar quantas vezes "elemento2" aparece na lista
            int contagem = listas.Count(item => item == "vieira");
            Console.WriteLine(contagem);  // Isto irá imprimir o número de vezes que "elemento2" aparece na lista





        }
    }
}
