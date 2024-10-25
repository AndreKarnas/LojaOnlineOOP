public abstract class Produto
{
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public decimal Preco { get; set; }

    protected Produto(string nome, string codigo, decimal preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
    }

    public abstract decimal CalcularPrecoFinal();

    public virtual void ExibirInformacoes() 
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço: {Preco:C}");
    }
}
