
using DesignPatterns2.Cap_3;

Historico historico = new Historico();

Contrato contrato = new Contrato(DateTime.Now, "Naran", TipoContrato.Novo);
historico.Adiciona(contrato.SalvaEstado());

contrato.Avanca();
historico.Adiciona(contrato.SalvaEstado());

contrato.Avanca();
historico.Adiciona(contrato.SalvaEstado());

Console.WriteLine(historico.Pega(0).Contrato.Tipo);