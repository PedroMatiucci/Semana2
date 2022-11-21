using Semana2.exercicio2;
namespace main
{
    class Program
    {

        static void Main(string[] args)
        {
            Aluno teste = new Aluno("a", 1);
            Aluno teste2 = new Aluno("b", 3);
            Turma turma = new Turma();
            turma.AdicionaAluno(teste2);
            turma.AdicionaAluno(teste);
            turma.DefineNotaP1(teste2, 5.00); 
            turma.DefineNotaP2(teste2, 6.00);
            turma.DefineNotaP1(teste, 8.00);
            turma.DefineNotaP2(teste, 6.00);
            turma.EstatisticasTurma();
            turma.OrdemAlfabetica();

        }

    }
}



