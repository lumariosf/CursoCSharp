using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos, O algoritmo deve ler a idade de 10 pessoas
namespace CursoCSharp.Exercicios {

    public class Pessoa {
        string nome;
        int idade;
        bool maior_de_idade; 

        public Pessoa(string nome, int idade) {
            this.nome = nome; this.idade = idade;

            if (idade > 18) this.maior_de_idade = true;
            else this.maior_de_idade = false; 
        }

        public string getNome() { return nome; }

        public int getIdade() { return idade; }

        public bool getMaior() { return maior_de_idade; }
    }

    internal class Ex2 {

        public static void Executar() {
            Pessoa[] pessoas = new Pessoa[10];

            int resposta = 0; 
            List<Pessoa> pessoas_de_maior = new List<Pessoa>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o nome da Pessoa {i + 1}");
                string nome = Console.ReadLine();

                Console.WriteLine($"Insira a idade da Pessoa {i + 1}");
                int idade = int.Parse(Console.ReadLine());

                Pessoa p1 = new Pessoa(nome, idade);

                // ver como posso melhorar essa chamada 
                if (p1.getMaior()) {
                    resposta++;
                    pessoas_de_maior.Add(p1); 
                }
            }

            Console.WriteLine("Número de pessoas que possuem mais de 18 anos é {0}", resposta);
            foreach(Pessoa p in pessoas_de_maior)
            {
                Console.WriteLine($"{p.getNome()}, {p.getIdade()}");
            }
        }
    }
}
