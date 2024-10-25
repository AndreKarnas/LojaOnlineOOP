public class ProdutoFisico : Produto 
{

    public double Peso {get; set; }

    public Dimensao Dimensoes { get; set; }

    public string Categoria { get; set; }

     private const decimal Imposto = 0.07m; 
     private const decimal ValorPorKg = 8.0m;

     public ProdutoFisico(string nome, string codigo, decimal preco, double peso, Dimensao dimensoes, string categoria)
        : base(nome, codigo, preco)
    {
        Peso = peso;
        Dimensoes = dimensoes;
        Categoria = categoria;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal impostos = Preco * Imposto;
        decimal custoEnvio = (decimal)Peso * ValorPorKg;

        return Preco + impostos + custoEnvio;
    }

      public override void ExibirInformacoes() 
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Dimensões: {Dimensoes.Altura} x {Dimensoes.Largura} x {Dimensoes.Profundidade} cm");
        Console.WriteLine($"Categoria: {Categoria}");
    }
}
