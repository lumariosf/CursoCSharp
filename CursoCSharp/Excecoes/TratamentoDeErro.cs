using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {

    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) { 
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente"); 
            }

            Saldo -= valor; 
        }

    }
    internal class TratamentoDeErro {
        public static void Executar() {
            Conta c = new Conta(1223.45);

            
            try {
                c.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
