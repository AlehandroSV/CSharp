﻿namespace CursoCSharp.Colecoes {
    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 98.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}