namespace Semana2.exercicio2
{
    internal class Turma
    {
        public List<Aluno> listaAlunos = new List<Aluno>();

        public void AdicionaAluno(Aluno aluno)
        {
            listaAlunos.Add(aluno);
        }

        public void RemoveAluno(Aluno aluno)
        {
            listaAlunos.Remove(aluno);
        }

        public void DefineNotaP1(Aluno aluno, double nota)
        {
            aluno.P1 = nota;
        }

        public void DefineNotaP2(Aluno aluno, double nota)
        {
            aluno.P2 = nota;
        }

        public void OrdemAlfabetica()
        {
            listaAlunos.Sort((a1, a2) => a1.Nome.CompareTo(a2.Nome));
            foreach (Aluno aluno in listaAlunos)
            {
                double nf = (aluno.P1 + aluno.P2) / 2;
                Console.WriteLine("{0}: {1}", aluno.Nome, nf);
            }
        }



        public void EstatisticasTurma()
        {
            double mediaP1 = 0;
            double mediaP2 = 0;
            double mediaNf = 0;
            double maiorNf = 0;
            Aluno melhorAluno = null;
            foreach (Aluno aluno in listaAlunos)
            {
                mediaP1 += aluno.P1;
                mediaP2 += aluno.P2;
                double nf = (aluno.P1 + aluno.P2) / 2;
                mediaNf += nf;
                if (maiorNf < nf)
                {
                    maiorNf = nf;
                    melhorAluno = aluno;
                }
            }
            Console.WriteLine(mediaP1 / listaAlunos.Count);
            Console.WriteLine(mediaP2 / listaAlunos.Count);
            Console.WriteLine(mediaNf / listaAlunos.Count);
            Console.WriteLine((melhorAluno.P1 + melhorAluno.P2) / 2);
            Console.WriteLine("{0},{1}", melhorAluno.Nome, melhorAluno.Matriula);
        }
    }
}
