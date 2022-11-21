namespace Semana2.exercicio4
{
    internal class Certidao
    {
        DateTime dataEmissao;
        Pessoa pessoa;

        public Certidao(DateTime dataEmissao, Pessoa pessoa)
        {
            this.dataEmissao = dataEmissao;
            this.pessoa = pessoa;
        }

        public DateTime DataEmissao { get { return dataEmissao; } private set { } }
    }
}
