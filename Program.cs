using DesignPatterns2.Cap_7;

FilaDeTrabalho fila = new FilaDeTrabalho();
Pedido pedido1 = new Pedido("Mauricio", 100.0);
Pedido pedido2 = new Pedido("Marcelo", 200.0);

fila.Adiciona(new PagaPedido(pedido1));
fila.Adiciona(new PagaPedido(pedido2));

fila.Adiciona(new FinalizaPedido(pedido1));
fila.Adiciona(new FinalizaPedido(pedido2));

fila.Processa();
