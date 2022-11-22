using System.Globalization;

namespace Semana2.exercicio1
{
    internal class ControleCadastros
    {
        public List<AbstractCadastro> listaParametros = new List<AbstractCadastro>();
        public Dictionary<AbstractCadastro, string> dadosColetados = new Dictionary<AbstractCadastro, string>();
        public Dictionary<AbstractCadastro, string> dadosValidados = new Dictionary<AbstractCadastro, string>();
        public Dictionary<AbstractCadastro, string> erros = new Dictionary<AbstractCadastro, string>();
        public NomeCadastro cadastroNome = new NomeCadastro();
        public CpfCadastro cadastroCpf = new CpfCadastro();
        public DataNascimentoCadastro cadastroData = new DataNascimentoCadastro();
        public RendaCadastro cadastroRenda = new RendaCadastro();
        public EstadoCadastro cadastroEstado = new EstadoCadastro();
        public DependentesCadastro cadastroDependentes = new DependentesCadastro();

        public void CadastraElementos()
        {
            listaParametros.Add(cadastroNome);
            listaParametros.Add(cadastroCpf);
            listaParametros.Add(cadastroData);
            listaParametros.Add(cadastroRenda);
            listaParametros.Add(cadastroEstado);
            listaParametros.Add(cadastroDependentes);
        }
        public void ColetarDados()
        {
            CadastraElementos();
            foreach (AbstractCadastro elemento in listaParametros)
            {
                dadosColetados.Add(elemento, elemento.PedeDados());
            }
            VerificaDados();
        }

        public void VerificaDados()
        {
            foreach (AbstractCadastro elemento in listaParametros)
            {
                if (elemento.Verifica(dadosColetados[elemento]))
                {
                    dadosValidados.Add(elemento, dadosColetados[elemento]);
                    dadosColetados.Remove(elemento);
                }
                else
                {
                    erros.Add(elemento, dadosColetados[elemento]);
                    dadosColetados.Remove(elemento);
                }
            }
            if (erros.Count == 0)
            {
                CriaCliente();
            }
            else
            {
                PrintErros();
            }
        }

        public void PrintErros()
        {
            foreach (KeyValuePair<AbstractCadastro, string> ele in erros)
            {
                Console.WriteLine("{0}: {1}",
                            ele.Key.Nome(), ele.Value);
                Console.WriteLine(ele.Key.MensagemErro());
            }
            ColetaDadosErros();
        }

        public void ColetaDadosErros()
        {
            foreach (KeyValuePair<AbstractCadastro, string> elemento in erros)
            {
                dadosColetados.Add(elemento.Key, elemento.Key.PedeDados());
                erros.Remove(elemento.Key);
            }
            VerificaDadosErro();
        }

        public void VerificaDadosErro()
        {
            foreach (KeyValuePair<AbstractCadastro, string> ele in dadosColetados)
            {
                if (ele.Key.Verifica(ele.Value))
                {
                    dadosValidados.Add(ele.Key, ele.Value);
                    dadosColetados.Remove(ele.Key);
                }
                else
                {
                    erros.Add(ele.Key, ele.Value);
                    dadosColetados.Remove(ele.Key);

                }
            }
            if (erros.Count == 0)
            {
                CriaCliente();
            }
            else
            {
                PrintErros();
            }
        }

        public void CriaCliente()
        {
            string Nome = dadosValidados[this.cadastroNome];
            long Cpf = long.Parse(dadosValidados[this.cadastroCpf]);
            DateTime Data = DateTime.ParseExact(dadosValidados[cadastroData], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            float Renda = float.Parse(dadosValidados[cadastroRenda]);
            char Estado = char.Parse(dadosValidados[cadastroEstado]);
            int Dependentes = int.Parse(dadosValidados[cadastroDependentes]);
            Console.WriteLine("Sucesso");
            Cliente novo = new Cliente(Nome, Cpf, Data, Renda, Estado, Dependentes);
        }

    }
}