namespace Semana2.exercicio1
{
    abstract class AbstractCadastro
    {
        public abstract string PedeDados();
        
        public abstract string MensagemErro();

        public abstract bool Verifica(string dadoVerifica);

        public abstract string Nome();

    }
}
