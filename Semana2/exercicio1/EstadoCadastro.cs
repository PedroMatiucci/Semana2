using System.Text.RegularExpressions;

namespace Semana2.exercicio1
{
    internal class EstadoCadastro : AbstractCadastro
    {
        public override string PedeDados()
        {
            Console.WriteLine("C - Casado, S- Solteiro, V - Viuvo, D - Divorciado");
            Console.WriteLine("Digite Seu estado Civil");
            return Console.ReadLine();
        }

        public override string MensagemErro()
        {
            return "Por Favor Digite Um Estado Valido";

        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"^[CSVD]$";
            Regex rg = new Regex(pattern);
            Match m = rg.Match(dadoVerifica);
            return m.Success;
        }

        public override string Nome()
        {
            return "Estado Civil";
        }
    }
}
