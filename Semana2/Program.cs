using Semana2.exercicio6;

namespace main
{
    class Program
    {

        static void Main(string[] args)
        {

            // imprime As Progressoes 10x
            ProgressaoAritmetica pa = new ProgressaoAritmetica(3, 4);
            ProgressaoGeometrica pg = new ProgressaoGeometrica(3, 4);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("PA = {0}",
                    pa.ProximoValor);
                Console.WriteLine("PG = {0}",
                    pg.ProximoValor);
            }


        }

    }
}



