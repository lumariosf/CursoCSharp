using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes; 
using CursoCSharp.Exercicios; 
using CursoCSharp.OrientacaoObj; 
using CursoCSharp.MetodosEFuncoes; 


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
                {"Propriedades - Classes e Métodos", Propriedades.Executar},
                {"Atributos Readonly - Classes e Métodos", Readonly.Executar},
                {"Enumeração - Classes e Métodos", Enumeracao.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Classe vc Struct - Classes e Métodos", ClasseVsStruct.Executar}, 
                {"Parametros Por Referência - Classes e Métodos", ParametrosRef.Executar}, 
                {"Parametros Por Valor - Classes e Métodos", ParametrosVal.Executar},

                {"Array - Coleções", Colecoes.Array.Executar}, 
                {"List - Coleções", Colecoes.List.Executar},  
                {"ArrayList - Coleções", Colecoes.ExArrayList.Executar},
                {"Set - Coleções", Colecoes.Set.Executar},
                {"Queue - Coleções", Colecoes.Queue.Executar},
                {"Equals - Coleções", Colecoes.Equals.Executar},
                {"Stack - Coleções", Colecoes.Stack.Executar},
                {"Dictionary - Coleções", Colecoes.Dictionary.Executar},

                {"Exercicio 1 - Exercícios", Ex1.Executar},
                {"Exercicio 2 - Exercícios", Ex2.Executar},
                {"Exercicio 3 - Exercícios", Ex3.Executar},
                
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OrientacaoObj.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Classe Abstrata - Orientação a Objetos", Abstrata.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                {"Lambda - Metodos e Funcoes", Lambda.Executar},
                {"Lambda Delegate - Metodos e Funcoes", LambdaDelegate.Executar},
                {"Usando Delegate - Metodos e Funcoes", UsandoDelegate.Executar},
                {"Delegate Funçoes Anônimas - Metodos e Funcoes", DelegateFuncAnonima.Executar},
                {"Delegate Como Parametro - Metodos e Funcoes", DelegateComoParametro.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}