using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios {

    public class Funcionario {
        private string Nome;
        private double Salario; 

        // talvez seja uma boa n ajustar logo no construtor
        public Funcionario(string nome, double salario) {
            this.Nome = nome;
            this.Salario = salario;
            reajuste(salario); 
        }

        public string getNome() {
            return Nome;
        }

        public double getSalario() {
            return Salario;
        }

        // pode mudar mas sem pedir reajuste?
        public void setNome(string nome) {
            this.Nome = nome; 
        }

        public void setSalario(double salario) {
            this.Salario = salario; 
        }

        // pessoa pode acabar chamando várias vezes. n daria problema?
        private void reajuste(double salario) {
            if (salario <= 300) {
                this.Salario = salario * 1.5; 
            }
            else {
                this.Salario = salario * 1.3; 
            }
        }

        public void printReajuste() {
            Console.WriteLine($"O funcionário {Nome} tem o novo salário com reajuste de {Salario}");
        }
    }

    internal class Ex4 {
        public static void Executar() {
            List<Funcionario> f = new List<Funcionario>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o nome do funcionário {i + 1}");
                string nome = Console.ReadLine();

                Console.WriteLine($"Insira o salário do funcionário {i + 1}");
                double salario = double.Parse(Console.ReadLine());
            }

            foreach (var atual in f) {
                atual.printReajuste();
            }
        }
    }
}
