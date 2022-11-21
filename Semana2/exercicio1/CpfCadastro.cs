using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Semana2.exercicio1
{
    internal class CpfCadastro: AbstractCadastro
    {
        public override string PedeDados()
        {
            Console.WriteLine("Digite Seu Cpf:");
            return Console.ReadLine();
        }

        public override string PedeDadosErros()
        {
            Console.WriteLine("Erro Digite Um Cpf Valido");
            Console.WriteLine("Digite Seu Cpf:");
            return Console.ReadLine();
        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"^\d{11}$";
            Regex rg = new Regex(pattern);
            Match m = rg.Match(dadoVerifica);
            return m.Success;
        }
    }
}
