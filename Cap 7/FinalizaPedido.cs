﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_7
{
    internal class FinalizaPedido : IComando
    {
        private Pedido pedido;
        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.Cliente);
            pedido.Finaliza();
        }
    }
}
