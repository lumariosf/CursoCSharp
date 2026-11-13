using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {

    public class NegativoExpection : Exception {
        public NegativoExpection() { }

        public NegativoExpection(string message) : base(message) { }

        // dar a causa, origem do erro
        public NegativoExpection(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }

    internal class Personalisada {

        public static int PositivoPar() {
            Random rnd = new Random();
            int valor = rnd.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoExpection("Numero negativo");
            }

            if (valor % 2 == 1)
            {
                throw new ImparException("Valor impar"); 
            }

            return valor; 
        }

        public static void Executar() {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoExpection ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Feito");
            }
        }
    }
}
