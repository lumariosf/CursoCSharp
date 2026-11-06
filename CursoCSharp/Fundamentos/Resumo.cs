using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Resumo {
        public static void Executar() {

            // inferência de tipos
            // precisa sempre atribuir um valor para o compilador conseguir inferir o tipo
            var nome = "Luma";
            var idade = 23;
            var altura = 1.70;


            // interpolação de strings
            Console.WriteLine($"Meu nome é {nome} e eu {idade} anos.");
            Console.WriteLine($"Também pode fazer operações nas chaves {idade *5}");


            // notação de ponto
            // para acessar métodos igual c++
            // engraçado que coloca a letra maiúscula
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.Length);


            // lendo dados do console
            Console.Write("Digite o nome: ");  // retorna strings
            string nome2 = Console.ReadLine();
            Console.WriteLine($"Oi, {nome2}");

            Console.Write("Digite a idade: ");  // retorna numeros
            int idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você tem {idade2} anos");


            // formatando números
            double valor = 1234.5678;
            Console.WriteLine($"{valor:F2}"); // duas casas decimais


            // conversões de tipos
            string texto = "25";
            int numero = int.Parse(texto);
            Console.WriteLine(numero * 5);

            texto = "100";
            numero = Convert.ToInt32(texto); 
            valor = Convert.ToDouble("10.5");

            texto = idade.ToString();


            // operador ternário
            // condição ? valor_se_vdd : valor_se_fal
            string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade"; 
            Console.WriteLine(resultado);
        }
    }
}
