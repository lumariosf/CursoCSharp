using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Resumo - Fundamentos", Resumo.Executar},

                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar}, 
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar}, 
                {"Estrutura DO WHILE - Estruturas de Controle", EstrutruraDoWhile.Executar}, 
                {"Estrutura FOR EACH - Estruturas de Controle", EstruturaForEach.Executar}, 

                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Parametros Variaveis - Classes e Métodos", ParametrosVariaveis.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get and Set - Classes e Métodos", GetSet.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}