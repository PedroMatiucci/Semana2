using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2.exercicio1
{
    internal class ControleCadastros
    {
        public List<AbstractCadastro> listaParametros = new List<object>();
        public List<string> dadosColetados = new List<string>();
        //definicoes das classes
        public NomeCadastro cadastroNome = new NomeCadastro();
        public CpfCadastro cadastroCpf = new CpfCadastro();

        public void CadastraElementos()
        {
            listaParametros.Add(cadastroNome);
            listaParametros.Add(cadastroCpf);
        }
        public void ColetarDados()
        {
            foreach(AbstractCadastro elemento in listaParametros)
            {
                dadosColetados.Add(elemento.PedeDados());
            }   
        }

        public void VerificaDados()
        {
        }
    }
}
