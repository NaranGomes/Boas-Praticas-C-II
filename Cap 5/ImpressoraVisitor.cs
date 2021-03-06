using DesignPatterns2.Cap_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_5
{
    internal class ImpressoraVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");

            soma.Esquerda.Aceita(this);

            Console.Write("+");

            soma.Direita.Aceita(this);

            Console.Write(")");
        }
        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");

            subtracao.Esquerda.Aceita(this);

            Console.Write("-");

            subtracao.Direita.Aceita(this);

            Console.Write(")");
        }
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
