using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIF {
        public static void Executar() {

            // funcionamento básico de if com leitura do console
            bool bomComportamento = false;
            string entrada; 

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N)? ");
            entrada = Console.ReadLine();

            // duas formas que aceita
            if (entrada == "S" || entrada == "s") {
                bomComportamento = true;
            } 
            bomComportamento = entrada == "S" || entrada == "s" ? true : false;

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
