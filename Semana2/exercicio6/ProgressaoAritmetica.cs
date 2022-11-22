using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2.exercicio6
{
    internal class ProgressaoAritmetica: Progressao
    {
        int proximoValor;

        public override int  ProximoValor { get { return proximoValor; } }

        public override int TermoAt(int Termo)
        {
            //TermoAt é um método abstrato que retorna o termo da progressão que está na posição
            //indicada, iniciando na posição 1.
            return 1;
        }
    }
}
