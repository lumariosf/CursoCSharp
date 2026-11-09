using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1; 
        string nome; 
        public string Nome { 
            get {
                return "Opicional: " + nome; 
            }
            set {
                // value palavra reservada 
                nome = value; 
            }
        }

        // propriedades autoimplementadas
        public double Preco { get; set; }
        
        // aq só de leitura
        public double PrecoComDesconto {
            // com função lambda
            get => Preco - (desconto * Preco); 
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            this.nome = nome;
            this.Preco = preco; 
        }
    
    }

    internal class Propriedades {
        public static void Executar() {
            CarroOpcional c1 = new CarroOpcional("Nome", 1902738);
            Console.WriteLine(c1.PrecoComDesconto);
        }
    }
}
    
