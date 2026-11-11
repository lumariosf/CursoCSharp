using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObj {

    public class Comida {
        public double peso;
        public Comida(double peso) {
            this.peso = peso; 
        }

        public Comida() { }
    }

    public class Feijao : Comida {
        public Feijao(double peso) : base(peso) { }
    }

    public class Arroz : Comida {}

    public class Carne : Comida {}

    public class Pessoa {
        public double peso;

        //public void comer(Feijao feijao) {
        //    peso += feijao.peso; 
        //}

        //public void comer(Arroz arroz) {
        //    peso += arroz.peso; 
        //}

        //public void comer(Carne carne) {
        //    peso += carne.peso; 
        //}


        // substitui vários métodos por um 
        public void comer(Comida comida) {
            peso += comida.peso; 
        }
    }

    internal class Polimorfismo {
        public static void Executar() {
            Feijao i1 = new Feijao(0.3);

            Arroz i2 = new Arroz();
            i2.peso = 0.25; 

            Carne i3 = new Carne();
            i3.peso = 0.7;

            Pessoa p = new Pessoa();
            p.peso = 80.0;
            p.comer(i1); p.comer(i2); p.comer(i3);

            Console.WriteLine("Peso agora é {0}", p.peso);
        }
        // único método para multiplos objetos

        // estática: sobrecarga de métodos 

        // dinâmico: instânciar a classe herdada pela classe principal
        // ex: Carro c3 = new Uno(); 
    }
}
