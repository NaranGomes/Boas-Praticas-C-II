using DesignPatterns2.Cap_8;
using System.Xml.Serialization;

Cliente cliente = new Cliente();
cliente.Nome = "victor";
cliente.Endereco = "Rua Vergueiro";
cliente.DataDeNascimento = DateTime.Now;

string xml = new GeradorDeXml().GeraXml(cliente);

Console.WriteLine(xml);