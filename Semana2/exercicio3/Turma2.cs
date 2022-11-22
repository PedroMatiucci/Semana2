namespace Semana2.exercicio3
{
    internal class Turma2
    {
        int codigo;
        List<Aluno2> listaAlunos = new List<Aluno2>();

        public Turma2(int codigo)
        {
            this.codigo = codigo;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }
            private set
            {
            }
        }

        public List<Aluno2> ListaAlunos
        {
            get
            {
                return listaAlunos;
            }
            private set { }
        }

        public void ListarAlunos()
        {
            listaAlunos.Sort((a1, a2) => a1.Nome.CompareTo(a2.Nome));
            foreach(Aluno2 aluno in listaAlunos)
            {
                Console.WriteLine(aluno.Nome);
            }
        }

        public void AddAluno(Aluno2 aluno)
        {
            if (!listaAlunos.Contains(aluno))
            {
                listaAlunos.Add(aluno);
            }
        }

        public void RemoveAluno(Aluno2 aluno)
        {
            listaAlunos.Remove(aluno);
        }
    
    }
}
