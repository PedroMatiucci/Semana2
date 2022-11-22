using Semana2.exercicio6;
using Semana2.exercicio7;

namespace main
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
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
            */
            Propriedades teste = new Propriedades(@"C:\Users\Carla\\teste\propriedades.txt");
            string valor = teste.RetornaValor("teste");
            teste.AlterarValor("teste", "mudei o valor2");
            Console.WriteLine(valor);
            teste.EscreveDados();
            //teste.AlterarValor("teste", "teste1");
            //teste.AlterarValor("teste2", "teste2");
            //teste.EscreveDados();


        }

    }
}



