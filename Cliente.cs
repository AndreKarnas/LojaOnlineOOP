public class Cliente
{
    public string NomeCliente { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public Cliente(string nomeCliente, string cpf, string endereco, string contato) 
    {
        NomeCliente = nomeCliente;
        Cpf = cpf;
        Endereco = endereco; 
        Contato = contato;
    }

    public void ExibirInformacoes() 
    {
        Console.WriteLine($"Nome do cliente: {NomeCliente}"); 
        Console.WriteLine($"CPF: {Cpf}"); 
        Console.WriteLine($"Endereço: {Endereco}"); 
        Console.WriteLine($"Contato: {Contato}"); 
    }
}
