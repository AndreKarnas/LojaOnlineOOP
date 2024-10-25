 /* var loja = new Loja();

        var dimensao = new Dimensao(40, 25, 70);
        var produtoFisico = new ProdutoFisico("Televisão", "RO234", 100.0m, 2.5, dimensao, "Eletrônicos");
        loja.CadastrarProduto(produtoFisico);

        var produtoDigital = new ProdutoDigital("E-book", "BP089", 50.0m, 1.5, "PDF");
        loja.CadastrarProduto(produtoDigital);

        
        var cliente = new Cliente("Rodrigo", "123456789", "Rua ab, 444", "Rodrigo@email.com");
        loja.CadastrarCliente(cliente);
        

        
        var pedido = loja.CriarPedido(cliente);
        if (pedido != null)
        {
            pedido.AdicionarProduto(produtoFisico);
            pedido.AdicionarProduto(produtoDigital);
            Console.WriteLine($"Total do pedido: {pedido.CalcularTotal():C}");
            loja.FinalizarPedido(pedido);
        }

        
        loja.ListarProdutos();
        loja.ListarClientes();
        loja.ListarPedidos();*/
    
var loja = new Loja();


var dimensao = new Dimensao(40, 25, 70);
var produtoFisico = new ProdutoFisico("Televisão", "RO234", 100.0m, 2.5, dimensao, "Eletrônicos");
loja.CadastrarProduto(produtoFisico);

var produtoDigital = new ProdutoDigital("E-book", "BP089", 50.0m, 1.5, "PDF");
loja.CadastrarProduto(produtoDigital);


var cliente1 = new Cliente("Rodrigo", "123456789", "Rua ab, 444", "Rodrigo@email.com");
loja.CadastrarCliente(cliente1);

var cliente2 = new Cliente("Luciano", "987654321", "Avenida gds, 123", "Luciano@email.com");
loja.CadastrarCliente(cliente2);


var pedido1 = loja.CriarPedido(cliente1);
if (pedido1 != null)
{
    pedido1.AdicionarProduto(produtoFisico);
    pedido1.AdicionarProduto(produtoDigital);
    Console.WriteLine($"Total do pedido: {pedido1.CalcularTotal():C}");
    loja.FinalizarPedido(pedido1);
}


var pedidoInvalido = loja.CriarPedido(null);
if (pedidoInvalido == null)
{
    Console.WriteLine("Não foi possível criar o pedido: Cliente inválido.");
}


var clienteInexistente = new Cliente("Patricia", "05253253253", "Rua dgr, 045", "Patricia@email.com");
var pedidoInexistente = loja.CriarPedido(clienteInexistente);
if (pedidoInexistente == null)
{
    Console.WriteLine("Não foi possível criar o pedido: Cliente não cadastrado.");
}


loja.ListarProdutos();
loja.ListarClientes();
loja.ListarPedidos();