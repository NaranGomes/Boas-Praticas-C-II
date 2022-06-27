using DesignPatterns2.Cap_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_4
{
    internal class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int ValorEsquerda = Esquerda.Avalia();
            int ValorDireita = Direita.Avalia();
            return ValorEsquerda + ValorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
