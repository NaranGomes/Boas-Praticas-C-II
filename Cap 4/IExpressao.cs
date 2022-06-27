using DesignPatterns2.Cap_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_4
{
    internal interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }

}
