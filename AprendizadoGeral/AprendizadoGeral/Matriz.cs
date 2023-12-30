using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoGeral
{
    internal class Matriz
    {
        public void Matrizes()
        {

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //Matriz no total
            Console.WriteLine(mat.Rank); //Priemira dimeção da matriz
            Console.WriteLine(mat.GetLength(0));// Aqui você pode escolher qual dimenção quer saber
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
