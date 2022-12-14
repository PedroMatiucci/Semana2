namespace Semana2.exercicio1
{
    public class Cliente
    {
        private string nome;
        private long cpf;
        private DateTime dataDeNascimento;
        private float rendaMensal;
        private char estadoCivil;
        private int dependentes;
        public Cliente(string nome, long cpf, DateTime dataDeNascimento, float rendaMensal, char estadoCivil, int dependentes)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataDeNascimento = dataDeNascimento;
            this.rendaMensal = rendaMensal;
            this.estadoCivil = estadoCivil;
            this.dependentes = dependentes;
        }

        public string Nome { get { return nome; } set { nome = Nome; } }

        public long Cpf { get { return cpf; } private set { } }

        public DateTime DataDeNascimento { get { return dataDeNascimento; } private set { } }

        public float RendaMensal { get { return rendaMensal; } private set { } }

        public char EstadoCivil { get { return estadoCivil; } private set { } }

        public int Dependentes { get { return dependentes; } private set { } }

        public void PrintDados()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Cpf);
            Console.WriteLine(DataDeNascimento);
            Console.WriteLine(RendaMensal);
            Console.WriteLine(EstadoCivil);
            Console.WriteLine(Dependentes);

        }

        public void Cadastrar()
        {

        }

    }

}
