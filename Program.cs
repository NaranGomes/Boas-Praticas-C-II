



using DesignPatterns2.Cap_4;
using DesignPatterns2.Cap_5;

IExpressao direita = new Soma(new Numero(1), new Numero(10));
IExpressao esquerda = new Subtracao(new Numero(20), new Numero(10));
IExpressao soma = new Soma(esquerda, direita);

Console.WriteLine(soma.Avalia());
ImpressoraVisitor impressora = new ImpressoraVisitor();
soma.Aceita(impressora);
