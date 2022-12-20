using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\Users\matheus.silva\Documents\ProjetosPessoais\CSharp\DictionaryCsharp\DictionaryCsharp\doc1.csv";
            using (StreamReader sr = File.OpenText(path))
            {
                Dictionary<string, string> registro = new();

                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();

                    var arr = linha.Split(",");
                    var nome = arr[0];
                    string votos = arr[1];

                    int novoValor;

                    if (!registro.ContainsKey(nome))
                    {
                        registro.Add(nome, votos);
                    }
                    else
                    {
                        novoValor = int.Parse(registro[nome]) + int.Parse(votos);
                        registro[nome] = novoValor.ToString();
                    }

                }
                foreach (KeyValuePair<string, string> item in registro)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}