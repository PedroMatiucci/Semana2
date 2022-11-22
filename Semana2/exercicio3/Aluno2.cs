namespace Semana2.exercicio3
{
    internal class Aluno2
    {
        System.Random random = new System.Random();
        string nome;
        Guid matricula;
        Turma2 turma;

        public Aluno2(string nome)
        {
            this.nome = nome;
            matricula = Guid.NewGuid();
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            private set { }
        }
        public Guid Matricula
        {
            get { return matricula; }
            private set
            {

            }
        }

        public Turma2 Turma
        {
            get
            {
                return turma;
            }
            set
            {
                turma = value;
            }
        }



    }
}