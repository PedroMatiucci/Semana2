namespace Semana2.exercicio2
{
    internal class Aluno
    {
        private string nome;
        private int matricula;
        private double p1;
        private double p2;
        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public int Matriula
        {
            get { return matricula; }
            private set { }
        }

        public string Nome
        {
            get { return nome; }
            private set { }
        }

        public double P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public double P2
        {
            get { return p2; }
            set { p2 = value; }
        }


    }
}
