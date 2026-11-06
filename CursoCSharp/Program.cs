using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Resumo - Fundamentos", Resumo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}