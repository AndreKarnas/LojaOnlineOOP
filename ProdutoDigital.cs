public class ProdutoDigital : Produto
{
    public double TamanhoArquivo{get; set; }
    public string Formato{get; set; }

    private const decimal TaxaDeDesconto = 0.10m;

    public ProdutoDigital(string nome, string codigo, decimal preco, double tamanhoArquivo, string formato )
        : base(nome, codigo, preco)
    {
        TamanhoArquivo = tamanhoArquivo;
        Formato = formato;
        
    }

    public override decimal CalcularPrecoFinal()
    {
         decimal desconto = Preco * TaxaDeDesconto;

        return Preco - desconto; 

    }

    public override void ExibirInformacoes() 
{
    base.ExibirInformacoes();
    Console.WriteLine($"Tamanho do Arquivo: {TamanhoArquivo} MB");
    Console.WriteLine($"Formato: {Formato}");
}
     

}