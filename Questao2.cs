using System;
using System.Collections.Generic;

public static class Questao2
{
    // Classe que representa cada item do estoque
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; } = "";
        public int Estoque { get; set; }
    }

    // Classe que representa uma movimentação
    public class Movimentacao
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; } = "";
        public int Quantidade { get; set; } // positivo = entrada, negativo = saída
    }

    private static List<Produto> estoque = new List<Produto>
    {
        new Produto { CodigoProduto = 101, DescricaoProduto = "Caneta Azul", Estoque = 150 },
        new Produto { CodigoProduto = 102, DescricaoProduto = "Caderno Universitário", Estoque = 75 },
        new Produto { CodigoProduto = 103, DescricaoProduto = "Borracha Branca", Estoque = 200 },
        new Produto { CodigoProduto = 104, DescricaoProduto = "Lápis Preto HB", Estoque = 320 },
        new Produto { CodigoProduto = 105, DescricaoProduto = "Marcador de Texto Amarelo", Estoque = 90 }
    };

    private static List<Movimentacao> movimentacoes = new List<Movimentacao>();
    private static int ultimoId = 1;

    public static void Executar()
    {
        Console.WriteLine("========== Movimentação de Estoque ==========");

        Console.Write("Digite o código do produto: ");
        int codigo = int.Parse(Console.ReadLine()!);

        Produto? prod = estoque.Find(p => p.CodigoProduto == codigo);

        if (prod == null)
        {
            Console.WriteLine("Produto não encontrado!");
            return;
        }

        Console.WriteLine($"Produto encontrado: {prod.DescricaoProduto} (Estoque atual: {prod.Estoque})");

        Console.Write("Digite a descrição da movimentação: ");
        string descricao = Console.ReadLine()!;

        Console.Write("Digite a quantidade (positiva para entrada, negativa para saída): ");
        int quantidade = int.Parse(Console.ReadLine()!);

        // Criar movimentação
        var mov = new Movimentacao
        {
            Id = ultimoId++,
            CodigoProduto = prod.CodigoProduto,
            Descricao = descricao,
            Quantidade = quantidade
        };

        movimentacoes.Add(mov);

        // Aplicar movimentação no estoque
        prod.Estoque += quantidade;

        Console.WriteLine("\nMovimentação registrada com sucesso!");
        Console.WriteLine($"ID: {mov.Id}");
        Console.WriteLine($"Produto: {prod.DescricaoProduto}");
        Console.WriteLine($"Quantidade movimentada: {quantidade}");
        Console.WriteLine($"Estoque final: {prod.Estoque}");
        Console.WriteLine("===============================================\n");
    }
}
