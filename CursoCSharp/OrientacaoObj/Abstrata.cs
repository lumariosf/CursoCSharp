using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObj {
    // só vale a pena se tem uma classe herda dessa classe
    public abstract class Celular {

        // todas as classes concretas vão ter que herdar esse método
        // n define o corpo do método
        public abstract string Assistente(); 

        // virtual deixa ser subscrito
        public virtual string Tocar() {
            return "piririm piririm";
        }
    }

    public class Samsung : Celular {

        // tem que usar o override 
        public override string Assistente() {
            return "Bixby"; 
        }
    }

    public class Apple : Celular {
        public override string Assistente() {
            return "Siri";
        }
    }

    internal class Abstrata {
        public static void Executar() {
            // classe n abstrata    = Celular c = new Celular(); 
            // classe abstrata      = n pode ser inicializada 

            // tem como fazer sem var?
            var c = new List<Celular> {
               new Apple(),
               new Samsung(),
            };

            foreach (var celular in c)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
