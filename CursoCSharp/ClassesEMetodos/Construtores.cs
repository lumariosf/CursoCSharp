using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo; 
        public string Fabricante;
        public int Ano;

        // construtor
        public Carro(string modelo, string fabricante, int ano) {
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }

        public Carro() {

        }
    }

    internal class Construtores {
        public static void Executar() {
            Carro carro1 = new Carro();
            carro1.Fabricante = "BYD";
            carro1.Modelo = "Dolphin Mini"; 
            carro1.Ano = 2024;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            Carro carro2 = new Carro("Dolphin Mini", "BYD", 2024);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            Carro carro3 = new Carro() { 
                Ano = 2019, 
                Fabricante = "Chevrolet",
                Modelo = "Onix"
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
