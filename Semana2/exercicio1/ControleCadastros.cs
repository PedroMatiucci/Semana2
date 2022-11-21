namespace Semana2.exercicio1
{
    internal class ControleCadastros
    {
        public List<AbstractCadastro> listaParametros = new List<AbstractCadastro>();
        public Dictionary<object, string> dadosColetados = new Dictionary<object, string>();
        public Dictionary<AbstractCadastro, string> dadosValidados = new Dictionary<AbstractCadastro, string>();
        public Dictionary<AbstractCadastro, string> erros = new Dictionary<AbstractCadastro, string>();
        public NomeCadastro cadastroNome = new NomeCadastro();
        public CpfCadastro cadastroCpf = new CpfCadastro();

        public void CadastraElementos()
        {
            listaParametros.Add(cadastroNome);
            listaParametros.Add(cadastroCpf);
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
            CadastraElementos();
            foreach (KeyValuePair<AbstractCadastro, string> ele in erros)
            {
                dadosColetados.Add(ele.Key, ele.Key.PedeDados());
                erros.Remove(ele.Key);
            }
            VerificaDadosErro();
        }

        public void VerificaDadosErro()
        {
            foreach (KeyValuePair<AbstractCadastro, string> ele in erros)
            {
                if (ele.Key.Verifica(ele.Value))
                {
                    Console.WriteLine(ele.Key);
                    dadosValidados.Add(ele.Key, ele.Value);
                }
                else
                {
                    erros.Add(ele.Key, ele.Value);
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
            Console.WriteLine(Nome, Cpf);
            //Cliente novo = new Cliente(Nome, Cpf)
        }

    }
}
