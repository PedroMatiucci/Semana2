namespace Semana2.exercicio6
{
    internal class ProgressaoAritmetica : Progressao
    {
        int proximoValor;

        public ProgressaoAritmetica(int primeiro, int razao) : base(primeiro, razao)
        {
            proximoValor = primeiro;
        }

        public override int ProximoValor
        {
            get
            {
                proximoValor += Razao;
                return proximoValor;
            }
        }

        public override int TermoAt(int Termo)
        {
            Reinicializar();
            for (int i = 1; i > Termo; i++)
            {
                if (ProximoValor == Termo)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
