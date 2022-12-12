using System;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

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
                {"Estrutura If  - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else  - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If  - Estrutura de Controle", EstruturaIfElseIf.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}