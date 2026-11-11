using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObj {


    public class Carro {
        protected readonly int velocidadeMax;
        private int velocidadeAtual; 

        public Carro(int velocidadeMax) {
            this.velocidadeMax = velocidadeMax; 
        }

        protected int alterarVelocidade(int delta) {
            int novaVelocidade = velocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                velocidadeAtual = 0; 
            } else if (novaVelocidade > velocidadeMax)
            {
                velocidadeAtual = velocidadeMax; 
            } else
            {
                velocidadeAtual = novaVelocidade; 
            }

            return velocidadeAtual;
        }

        // virtual para avisar que pode ser subscrito
        public virtual int acelerar() {
            return alterarVelocidade(5); 
        }

        public int frear() {
            return alterarVelocidade(-5);
        }
    }

    public class Uno : Carro {

        public Uno() : base(200) {

        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }

        // formas de subscrever
        public override int acelerar() {
            return alterarVelocidade(15); 
        }

        public new int frear() {
            return alterarVelocidade(-15); 
        }
    }


    internal class Heranca {
        public static void Executar() {
            // c# n aceita herança multipla

            Console.WriteLine("Uno...");
            Uno c1 = new Uno();
            Console.WriteLine(c1.acelerar());
            Console.WriteLine(c1.acelerar());
            Console.WriteLine(c1.frear());
            Console.WriteLine(c1.frear());
            Console.WriteLine(c1.frear());

            Console.WriteLine("Ferrari...");
            Ferrari c2 = new Ferrari();
            Console.WriteLine(c2.acelerar());
            Console.WriteLine(c2.acelerar());
            Console.WriteLine(c2.frear());
            Console.WriteLine(c2.frear());
            Console.WriteLine(c2.frear());

            // o método frear está chamando o método carro n o de ferrari
            // ele pega sempre dento da instância
            Console.WriteLine("Ferrari com tipo carro...");
            Carro c3 = new Ferrari();
            Console.WriteLine(c3.acelerar());
            Console.WriteLine(c3.acelerar());
            Console.WriteLine(c3.frear());
            Console.WriteLine(c3.frear());
            Console.WriteLine(c3.frear());
        }
    }
}
