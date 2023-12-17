//número da conta
//titular
//saldo
//senha

internal class ContaBancaria
{
    public int Id { get; set; }
    public int NumContaBancaria { get; set; }

    public int Agencia {  get; set; }

    public Titular Titular;
    public string Senha { get; set; }
    public double Saldo { get; set; }

    public double limite { get; set; }

    public string informacoes => $"Conta nº {this.NumContaBancaria}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}

    


/*
 solução do instrutor
1-Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
class Conta{
    public string titular;
    public int idConta;
    public float saldo;
    public int senha;
}
2-Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
Conta conta = new Conta();
conta.titular = "Gui Lima";
conta.id = 1;
conta.saldo = 20.00;
conta.senha = 1234;

Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {conta.titular}"); 
Console.WriteLine($"Saldo atual: {conta.saldo}");

3-Desenvolver um método da classe Conta que exibe suas informações.
public void exibirInformacoes(){
    Console.WriteLine("INFORMAÇÕES DA CONTA:");
    Console.WriteLine($"Titular: {this.titular}"); 
    Console.WriteLine($"Saldo atual: {this.saldo}");
}


 */