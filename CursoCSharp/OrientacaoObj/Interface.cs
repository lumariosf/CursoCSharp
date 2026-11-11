using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObj {
    // dá pra fazer heranças múltiplas de interface mas n rola com herança
    // interfaces tbm pode herdar de interface 

    // todos os métodos são publicos e abstratos
    interface Teste {
        bool Bla(string a);
    }

    interface OperacaoBinaria {
        // por padrão publico
        // n podem ser implementados 
        int Operacao(int a, int b); 
    }

    // ao herdar a interface tem que obrigatoriamente definir o método
    // tem que ser public

    // a interface pode ter herança múltiplas mas tem que implementar todos os métodos de todas as interfaces
    class Soma : OperacaoBinaria, Teste {
        public int Operacao(int a, int b) {
            return a + b; 
        }
        
        public bool Bla(string a) {
            return true; 
        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b; 
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = ""; 
            
            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n"; 
            }

            return resultado; 
        }
    }

    internal class Interface { 
        public static void Executar() {
            Calculadora calc = new Calculadora();
            string resultado = calc.ExecutarOperacoes(20, 5);

            Console.WriteLine(resultado);
        }

    }
}
