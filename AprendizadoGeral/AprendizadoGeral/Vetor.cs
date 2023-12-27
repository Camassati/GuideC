using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoGeral
{
    public class Vetor:VetorComClasse
    {
        public void Vetores()
        {
            /*
            int[] vetor = new int[4];
            vetor[0] = 1;
            vetor[1] = 2;
            vetor[2] = 3;
            vetor[3] = 4;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                Console.Write(vetor[i]);
            }
            /*O numero de pessoas que vai ser pego a altura
             * pegando cada altura
             * Somando e dividindo para conseguir a média
             */
            int n = int.Parse(Console.ReadLine());
            /*
            double[] vect = new double[n];
            
            for (int i = 0;i < n;i++) 
            {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0;i < n;i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("Average height = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            */
            VetorComClasse[] vetorComClasses = new VetorComClasse[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetorComClasses[i] = new VetorComClasse { Name = name, Price = price };
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = vetorComClasses[i].Price;
            }
            double avg = soma / n;
            Console.WriteLine("Average height = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            /*Outro Programa*/

        }
    }
}
