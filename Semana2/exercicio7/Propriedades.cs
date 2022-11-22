using System.Security.Cryptography;
using System.Text;
using System.IO;
using System;

namespace Semana2.exercicio7
{
    internal class Propriedades
    {
        Dictionary<string, string> dicPropriedades = new Dictionary<string, string>();
        string path;
        FileStream stream;

        public Propriedades(string path = "")
        {
            this.path = path;
            try
            {
                string i = "0";
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                foreach (string line in lines)
                {
                    int index = line.IndexOf("=");
                    string key = line.Substring(0, index);
                    string value = line.Substring(index + 1);
                    DicPropriedades.Add(key, value);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Path nao existente");
            }

        }
        public Dictionary<string, string> DicPropriedades { get { return dicPropriedades; } }

        public dynamic RetornaValor(string chave)
        {
            string value;
            if (DicPropriedades.TryGetValue(chave, out value))
            {
                return DicPropriedades[chave];
            }
            else
            {
                return null;
            }
        }

        public void AlterarValor(string chave, string valor)
        {
            if (DicPropriedades.ContainsKey(chave))
            {
                DicPropriedades[chave] = valor;
            }
            else
            {
                DicPropriedades.Add(chave, valor);
            }
        }

        public bool VerificaChave(string chave)
        {
            return DicPropriedades.ContainsKey(chave);
        }

        public void EscreveDados()
        {
            StreamWriter File = new StreamWriter(@"C:\\Users\\Carla\\Desktop\\teste\propriedades.txt");
            foreach(KeyValuePair<string,string> dado in DicPropriedades)
            {
                string texto = dado.Key + "=" + dado.Value;
                File.WriteLine(texto);
            }
            File.Close();

        }
    }
}



