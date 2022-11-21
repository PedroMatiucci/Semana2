namespace Semana2.exercicio3
{
    internal class Aluno2
    {
        System.Random random = new System.Random();
        string nome;
        int matricula;
        Turma2 turma;

        public Aluno2(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            private set { }
        }
        public int Matricula
        {
            get { return matricula; }
            set
            {
                matricula = random.Next();
            }
        }

        public Turma2 Turma
        {
            get
            {
                return turma;
            }
            set { 
                turma = value;
            }
        }



    }
}