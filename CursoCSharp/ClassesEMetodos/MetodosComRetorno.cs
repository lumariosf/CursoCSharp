using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b; 
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class CalculadoraCadeia {
        int memoria; 

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this; 
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }


    internal class MetodosComRetorno {

        public static void Executar() {
            CalculadoraComum calculadora = new CalculadoraComum(); 
            int soma = calculadora.Somar(2, 3); 
            int subtracao = calculadora.Subtrair(5, 2);
            int multiplicacao = calculadora.Multiplicar(3, 4);

            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(multiplicacao);


            CalculadoraCadeia calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(2).Imprimir().Limpar().Imprimir();
        }
    }
}
