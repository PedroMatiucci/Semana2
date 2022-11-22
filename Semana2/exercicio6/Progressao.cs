namespace Semana2.exercicio6
{
    abstract class Progressao
    {
        int primeiro;
        int razao;
        int proximoValor;

        public Progressao(int primeiro, int razao)
        {
            this.primeiro = primeiro;
            this.razao = razao;
        }

        public int Primeiro { get { return primeiro; } set { primeiro = value; } }
        public int Razao { get { return razao; } set { razao = value; } }
        public abstract int ProximoValor { get; }

        public void Reinicializar()
        {
            proximoValor = primeiro;
        }

        public abstract int TermoAt(int Termo);
    }
}
