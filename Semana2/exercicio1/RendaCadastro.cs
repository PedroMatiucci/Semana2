using System.Text.RegularExpressions;

namespace Semana2.exercicio1
{
    internal class RendaCadastro : AbstractCadastro
    {
        public override string PedeDados()
        {
            Console.WriteLine("Digite Sua Renda:");
            return Console.ReadLine();
        }

        public override string MensagemErro()
        {
            return "Por Favor Digite Uma Renda Valida";

        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"^\d+,\d{2}$";
            Regex rg = new Regex(pattern);
            Match m = rg.Match(dadoVerifica);
            return m.Success;
        }

        public override string Nome()
        {
            return "Renda Mensal";
        }
    }
}
