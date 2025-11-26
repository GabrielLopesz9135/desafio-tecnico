using System;
using System.Globalization;

public static class Questao3
{
    public static void Executar()
    {
        Console.Write("Digite o valor original: ");
        decimal valorOriginal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de vencimento (dd/mm/aaaa): ");
        string dataTexto = Console.ReadLine();

        DateTime dataVencimento;

        // Força o formato brasileiro dd/MM/yyyy
        try
        {
            dataVencimento = DateTime.ParseExact(dataTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        catch
        {
            Console.WriteLine("Data inválida! Use exatamente o formato dd/mm/aaaa.");
            return;
        }

        DateTime hoje = DateTime.Today;

        if (hoje <= dataVencimento)
        {
            Console.WriteLine("\nNão há atraso. Valor final: " + valorOriginal);
            return;
        }

        int diasAtraso = (hoje - dataVencimento).Days;

        Console.WriteLine($"\nDias de atraso: {diasAtraso}");

        Console.WriteLine("\nSelecione o tipo de juros:");
        Console.WriteLine("1 - Juros Simples (padrão)");
        Console.WriteLine("2 - Juros Compostos");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        decimal valorFinal;
        decimal taxa = 0.025m; // 2,5% ao dia

        if (opcao == "2")
        {
            // Juros compostos: ValorFinal = ValorOriginal * (1 + taxa)^dias
            valorFinal = valorOriginal * (decimal)Math.Pow((double)(1 + taxa), diasAtraso);
            Console.WriteLine("\nJuros compostos aplicados.");
        }
        else
        {
            // Juros simples: Juros = Valor * taxa * dias
            decimal juros = valorOriginal * taxa * diasAtraso;
            valorFinal = valorOriginal + juros;
            Console.WriteLine("\nJuros simples aplicados.");
        }

        Console.WriteLine($"\nValor final atualizado: {valorFinal:F2}");
    }
}
