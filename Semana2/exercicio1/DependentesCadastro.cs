using System.Text.RegularExpressions;

namespace Semana2.exercicio1
{
    internal class DependentesCadastro : AbstractCadastro
    {
        public override string PedeDados()
        {
            Console.WriteLine("Digite O Numero de Dependentes");
            return Console.ReadLine();
        }

        public override string MensagemErro()
        {
            return "Por Favor Digite Um Numero Entre 0 e 10";

        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"\b([0-9]|10)\b";
            Regex rg = new Regex(pattern);
            Match m = rg.Match(dadoVerifica);
            return m.Success;
        }

        public override string Nome()
        {
            return "Dependentes";
        }
    }
}
