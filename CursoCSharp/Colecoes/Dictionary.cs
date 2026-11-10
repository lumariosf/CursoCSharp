using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Dictionary {
        public static void Executar() {
            Dictionary<int, string> filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque"); 

            // find
            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004 " + filmes[2004]);
            }

            // ver se está contido no array 
            Console.WriteLine(filmes.ContainsValue("Teste"));

            // remover
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            // pegar um valor, passa a chave e um valor out (passar parametro por referencia por uma direção)
            // achei meio estranho.
            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filmes[2006]}");

            // uso de for no dicionário
            // foreach (KeyValuePair<int, string> filme in filmes)
            // foreach (var filme in filmes)
        }
    }
}
