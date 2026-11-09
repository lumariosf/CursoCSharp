using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class AtributosEstaticos {

        public class Produto {
            public string Nome;
            public double Preco;

            // agora é um atributo de classe, e não mais de instância, ou seja, é compartilhado entre todas as instâncias da classe
            // n posso colocar um valor arbitrário 
            public static double Desconto = 0.1;

            public Produto(string nome, double preco) {
                this.Nome = nome;
                this.Preco = preco;
                //this.Desconto = desconto; 
            }

            public Produto() {

            }

            public double PrecoComDesconto() {
                return Preco - (Preco * Desconto);
            }
        }
       
        public static void Executar() {
            Produto p1 = new Produto("Caneta", 3.45);
            Produto p2 = new Produto("Borracha", 5.45);

            Console.WriteLine("Preço com desconto: {0} ", p1.PrecoComDesconto());
            Console.WriteLine("Preço com desconto: {0} ", p2.PrecoComDesconto());

            Produto.Desconto = 0.5; // alterando o valor do atributo de classe

            Console.WriteLine("Preço com desconto: {0} ", p1.PrecoComDesconto());
            Console.WriteLine("Preço com desconto: {0} ", p2.PrecoComDesconto());
        }
    }
}
