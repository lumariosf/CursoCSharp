using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string nome;
        public int preco; 

        public Produto(string nome, int preco) {
            this.nome = nome;
            this.preco = preco;
        }
    }
   
    internal class List {
        public static void Executar() {
            Produto livro = new Produto("GOT", 80);

            List<Produto> carro = new List<Produto>(); 
            carro.Add(livro); // push_back 

            // se quiser dizer o que já tem
            List<Produto> combo = new List<Produto> {
               new Produto("camisa", 90),
               new Produto("algo", 10),
            };

            // adicionar agora em carro oq está em combo
            carro.AddRange(combo);
            // apagar no indice
            carro.RemoveAt(3); 

            // count para pegar o tamanho da lista
            for (int i = 0; i < carro.Count; i++) {
                Console.WriteLine(carro[i].nome);
                Console.WriteLine(carro[i].preco);
            }
        }

    }
}
