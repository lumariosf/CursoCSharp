using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// faça um algoritmo que calcule e exiba o salário reajustado de 10 funcionários de acordo com a seguinte regra:
// salários até 300, reajuste de 50%
// salários maiores que 300, reajuste de 30%
namespace CursoCSharp.Exercicios {
    internal class Ex3 {
        public static void Executar() {
            List<(string, double)> funcionarios = new List<(string, double)> ();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o nome do funcionário {i + 1}");
                string nome = Console.ReadLine();

                Console.WriteLine($"Insira o salário do funcionário {i + 1}");
                double salario = double.Parse(Console.ReadLine());

                if (salario <= 300) {
                    salario *= 1.5; 
                }
                else {
                    salario *= 1.3; 
                }
                    funcionarios.Add((nome, salario)); 
            }

            Console.WriteLine("Os salários reajustados são: ");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Item1} | {funcionario.Item2}");
            }
        }

    }
}
