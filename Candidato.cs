using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCsharp
{
    public class Candidato
    {
        public Candidato(string nomeComVotos)
        {
            var arr = nomeComVotos.Split(",");
            var nome = arr[0];
            int votos = int.Parse(arr[1]);
            
            Nome = nome;
            NumeroDeVotos = votos;
        }

        public string Nome { get; set; }
        public int NumeroDeVotos { get; set; }
    }
}
