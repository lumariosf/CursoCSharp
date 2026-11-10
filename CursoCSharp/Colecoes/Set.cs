using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Set {
        public static void Executar() {
            Produto livro = new Produto("GOT", 80);

            HashSet<Produto> carro = new HashSet<Produto>();
            carro.Add(livro); // insert 

            // se quiser dizer o que já tem
            HashSet<Produto> combo = new HashSet<Produto> {
               new Produto("camisa", 90),
               new Produto("algo", 10),
            };

            // adicionar agora em carro oq está em combo
            carro.UnionWith(combo);
            carro.Add(livro);

            // count para pegar o tamanho da lista
            foreach (var item in carro)
            {
                Console.WriteLine(item.nome);
            }
        }
    }
}
