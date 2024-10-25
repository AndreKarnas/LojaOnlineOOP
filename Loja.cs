public class Loja
{
    private List<Produto> Produtos { get; set; }
    private List<Cliente> Clientes { get; set; }
    private List<Pedido> Pedidos { get; set; }

    public Loja()
    {
        Produtos = new List<Produto>();
        Clientes = new List<Cliente>();
        Pedidos = new List<Pedido>();
    }

    
    public void CadastrarProduto(Produto produto)
    {
        if (produto != null && !Produtos.Any(p => p.Codigo == produto.Codigo))
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Produto já cadastrado ou inválido.");
        }
    }

    public Produto ConsultarProdutoPorCodigo(string codigo)
    {
        return Produtos.FirstOrDefault(p => p.Codigo == codigo);
    }


    
    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente != null && !Clientes.Any(c => c.Cpf == cliente.Cpf))
        {
            Clientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente.NomeCliente} cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Cliente já cadastrado ou inválido.");
        }
    }

    public Cliente ConsultarClientePorID(string cpf)
    {
        return Clientes.FirstOrDefault(c => c.Cpf == cpf);
    }

    public void ListarClientes()
    {
        foreach (var cliente in Clientes)
        {
            cliente.ExibirInformacoes();
        }
    }

    
    public Pedido CriarPedido(Cliente cliente)
    {
        if (cliente != null && Clientes.Contains(cliente))
        {
            var pedido = new Pedido(cliente);
            Pedidos.Add(pedido);
            Console.WriteLine("Pedido criado com sucesso.");
            return pedido;
        }
        Console.WriteLine("Cliente inválido.");
        return null;
    }

    public void FinalizarPedido(Pedido pedido)
    {
        if (pedido != null)
        {
            pedido.FinalizarPedido();
            Console.WriteLine($"Pedido para {pedido.Cliente.NomeCliente} finalizado.");
        }
    }
public void ListarProdutos()
{
    foreach (var produto in Produtos)
    {
        produto.ExibirInformacoes(); 
        Console.WriteLine(); 
    }
}

  public void ListarPedidos()
    {
        foreach (var pedido in Pedidos)
        {
            Console.WriteLine($"Pedido para {pedido.Cliente.NomeCliente} - Status: {pedido.Status} - Total: {pedido.CalcularTotal():C}");
        }
    }

}