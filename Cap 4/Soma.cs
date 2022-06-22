using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_4
{
    internal class Soma : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int ValorEsquerda = esquerda.Avalia();
            int ValorDireita = direita.Avalia();
            return ValorEsquerda + ValorDireita;
        }
    }
}
