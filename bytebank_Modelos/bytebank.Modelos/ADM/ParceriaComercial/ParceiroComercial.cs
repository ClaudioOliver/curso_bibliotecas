using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        private AutenticacaoUtil autenticacao { get; set; }
        
        public bool Autenticar(string senha)
        {
            return autenticacao.ValidarSenha(this.Senha, senha);
        }
    }
}
