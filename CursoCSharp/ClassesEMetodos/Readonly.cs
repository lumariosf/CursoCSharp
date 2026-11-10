using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {

    public class Cliente {
        public string Nome;

        // atributo imutavel mas posso setar no construtor 
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            this.Nome = nome; 
            this.Nascimento = nascimento;
        }

        public string getNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year); 
        }

    }
    internal class Readonly {


        public static void Executar() {
            Cliente c1 = new Cliente("Vampiro", new DateTime(1679, 10, 21));
            Console.WriteLine(c1.Nome);
            Console.WriteLine(c1.getNascimento());
        }
    }
}
