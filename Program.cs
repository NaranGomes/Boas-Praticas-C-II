using DesignPatterns2.Cap_6;

IMensagem mensagem = new MensagemAdministrativa("vitor");
IEnviador enviador = new EnviaPorEmail();

mensagem.Enviador = enviador;
mensagem.Envia();