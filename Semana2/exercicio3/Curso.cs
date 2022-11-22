namespace Semana2.exercicio3
{
    internal class Curso
    {
        string nome;
        List<Aluno2> listaAlunos = new List<Aluno2>();
        List<Turma2> listaTurmas = new List<Turma2>();
        public Curso(string nome)
        {
            this.nome = nome;
        }

        public void MatriulaAluno(Aluno2 aluno)
        {
            listaAlunos.Add(aluno);
        }

        public void RemoveAluno(Aluno2 aluno)
        {
            if (aluno.Turma == null)
            {
                listaAlunos.Remove(aluno);
            }
        }

        public void NovaTurma(int codigo)
        {
            Turma2 novaTurma = new Turma2(codigo);
            bool adicionar = true;
            foreach(Turma2 turma in listaTurmas)
            {
                if(turma.Codigo == codigo)
                {
                    adicionar = false;
                }
            }
            if (adicionar)
            {
                listaTurmas.Add(novaTurma);
            }
        }

        public void RemoveTurma(Turma2 turma)
        {
            if (turma.ListaAlunos.Count == 0)
            {
                listaTurmas.Remove(turma);
            }
        }

        public void ListarTurmas()
        {
            listaTurmas.Sort((t1, t2) => t1.Codigo.CompareTo(t2.Codigo));
            foreach (Turma2 turma in listaTurmas)
            {
                if(turma.ListaAlunos.Count > 0)
                {
                    Console.WriteLine(turma.Codigo);
                    turma.ListarAlunos();
                }
            }
        }
    }
}
