using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObj {

    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            this.Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }
        public Cachorro(string nome) : base(nome) {}

        public Cachorro(string nome, double altura) : this(nome) {
            this.Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura"; 
        }
    
    }


    internal class ConstrutorThis {
        public static void Executar() {
            Cachorro bilu = new Cachorro("Bilu");
            Cachorro monicao = new Cachorro("Monicão", 60);

            // massa pq subscreve o to string e sai a menssagem lá de cima
            Console.WriteLine(bilu);
            Console.WriteLine(monicao);
        }
    }
}
