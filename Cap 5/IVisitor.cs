using DesignPatterns2.Cap_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_5
{
    interface IVisitor
    {
        void ImprimeSoma(Soma soma);

        void ImprimeSubtracao(Subtracao subtracao);

        void ImprimeNumero(Numero numero);
    }
}
