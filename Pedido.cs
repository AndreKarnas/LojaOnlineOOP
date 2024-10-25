public class Pedido : ICarriavel
{
    public enum StatusDoPedido
    {
        EmProcessamento,
        Concluído,
        Cancelado

    }

    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; private set; }
    public StatusDoPedido Status { get; private set; }
    private List<Produto> Produtos { get; set; }

    public Pedido(Cliente cliente)
     {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = StatusDoPedido.EmProcessamento;
        Produtos = new List<Produto>();
    }

      public void AdicionarProduto(Produto produto)
      {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao pedido.");
      }

       public void RemoverProduto(Produto produto)
    {
         if (Produtos.Remove(produto))
        {
            Console.WriteLine($"Produto {produto.Nome} removido do pedido.");
        }
        else
        {
            Console.WriteLine($"Produto {produto.Nome} não encontrado no pedido.");
        }
    }
        public decimal CalcularTotal()
    {
        decimal total = 0;

        foreach (var produto in Produtos)
        {
            total += produto.CalcularPrecoFinal();
        }

        return total;
    }

    public void FinalizarPedido()
    {
        Status = StatusDoPedido.Concluído;
        Console.WriteLine("Pedido finalizado.");
       
    }
}


