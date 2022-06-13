using DesignPatterns2.Cap_1;
using System.Data;
using System.Data.SqlClient;

IDbConnection conexao = new ConnectionFactory().GetConnection();

IDbCommand comando = conexao.CreateCommand();
comando.CommandText = "select * from tabela";