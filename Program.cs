﻿using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentario - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação em Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais  - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos  - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição  - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários  - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário  - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If  - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else  - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If  - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch  - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While  - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While  - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For  - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach  - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break  - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue  - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membros  - Classes e Métodos", Membros.Executar},
                {"Construtores  - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributos.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClass.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro Com Valor Padrão - Classes e Métodos", ParametrosPorReferencia.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", List.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar },
                { "Stack - Coleções", ColecoesStack.Executar },
                { "Dicrionary - Coleções", ColecoesDictionary.Executar },

                // Orientação a Objetos
                { "Herança - Orientação a Objetos", Heranca.Executar },
                { "Construtor This - Orientação a Objetos", ConstrutorThis.Executar },
                { "Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
