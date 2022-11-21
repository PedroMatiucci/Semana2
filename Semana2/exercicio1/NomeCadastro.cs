using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2.exercicio1
{
    internal class NomeCadastro: AbstractCadastro
    {
        public override string PedeDados()
        {
            Console.WriteLine("Digite Seu Nome:");
            return Console.ReadLine();
        }

        public override string PedeDadosErros()
        {
            Console.WriteLine("Erro Seu Nome Precisa Ter Mais de 5 Caracteres");
            Console.WriteLine("Digite Seu Nome:");
            return Console.ReadLine();
        }

        public override bool Verifica(string dadoVerifica)
        {
            if (dadoVerifica.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
