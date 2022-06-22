﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_4
{
    internal class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            this.expressao = expressao;
        }

        public int Avalia()
        {
            return (int) Math.Sqrt(expressao.Avalia());
        }
    }
}