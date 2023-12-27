using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoGeral
{
    internal class Palindromo
    {
        public void Palindromos()
        {
            string palavra = "banco";

            for (int idx = 0; idx < palavra.Length; idx++)
            {
                var caracterA = palavra[idx];

                for (int idxb = palavra.Length - 1; idxb >= 0; idxb--)
                {
                    var caracterB = palavra[idxb];
                    if (caracterA != caracterB)
                    {
                        Console.Write("Não é palindromo!");
                        return;
                    }
                }
            }
        }
    }
}
