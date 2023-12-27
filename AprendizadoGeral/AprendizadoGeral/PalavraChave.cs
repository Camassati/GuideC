using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoGeral
{
    internal class PalavraChave
    {
        public void PalavraChaves()
        {
            //Mostrar no Console
            string fala = "Toma";

            //Converção 
            Console.WriteLine("\nEscreva um numero");
            int entrada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(entrada);

            Console.WriteLine(fala);
            string entrada2 = Console.ReadLine();
            int numeroDeFala = entrada2.Length;
            Console.WriteLine(numeroDeFala);
        }
    }
}
