using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoGeral
{
    internal class Classes
    {
        public static string Letra()
        {
           /* public : O tipo ou membro pode ser acessado por qualquer 
            outro código no mesmo assembly ou outro assembly que faça
            referência a ele.O nível de acessibilidade de membros públicos
            de um tipo é controlado pelo nível de acessibilidade do próprio tipo.*/
            return "Letra";
        }
        private string Letra1()
        {
            /*private : O tipo ou membro pode ser acessado apenas pelo código no mesmo classou struct.*/
            return "Letra1";
        }
        protected string Letra2() 
        {
            /*protected : O tipo ou membro pode ser acessado apenas por código no mesmo class,
             * ou em um classque seja derivado(herdado) dele class.*/
            return "Letra2";
        }
        internal string Letra3() 
        {
            /*internal : o tipo ou membro pode ser acessado por qualquer código no mesmo assembly,
             * mas não de outro assembly. 
             * Em outras palavras,internaltipos ou membros podem ser acessados a partir do código que faz parte da mesma compilação.*/
            return "Letra3";
        }
        public virtual string Letra4()
        {
            /*Pode ser alterado com override*/
            return "letra4";
        }
    }
}
