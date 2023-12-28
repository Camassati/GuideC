using System;

namespace AprendizadoGeral
{
    internal class Lops
    {
        public void Loops()
        {
            var argumento = false;
            var contagem = 2;
            //if = Se
            if (argumento == true)
            {
                Console.WriteLine("Bom");
                Console.WriteLine("Vivencias vivencias{0}", contagem);
            }
            else
                Console.WriteLine("Vivencias vivencias{0}", contagem);
            //While = Enquanto 
            while (argumento == false)
            {
                /*
                 == Atribuição
                 != Diferente de
                 && i
                 OR OU
                 */
            }
            Console.WriteLine("Vivencias vivencias");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            //Foreach para vetores 
            string[] vect = new string[] { "Gustavo", "Eneas", "Marisa" };
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
