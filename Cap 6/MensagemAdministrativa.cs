using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap_6
{
    internal class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }
        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", nome);
        }
    }
}
