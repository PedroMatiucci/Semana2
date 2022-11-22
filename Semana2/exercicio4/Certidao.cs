namespace Semana2.exercicio4

{
    internal class Certidao
    {
        DateTime dataEmissao;
        Pessoa dono;

        public Certidao(DateTime dataEmissao, Pessoa dono)
        {
            this.dataEmissao = dataEmissao;
            this.dono = dono;
        }

        public DateTime DataEmissao { get { return dataEmissao; } private set { } }

        public Pessoa Dono { get { return dono; } private set { } }
    }
}
