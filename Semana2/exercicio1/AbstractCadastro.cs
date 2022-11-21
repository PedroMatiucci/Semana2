namespace Semana2.exercicio1
{
    abstract class AbstractCadastro
    {
        public abstract string PedeDados();
        
        public abstract string PedeDadosErros();

        public abstract bool Verifica(string dadoVerifica);

    }
}
