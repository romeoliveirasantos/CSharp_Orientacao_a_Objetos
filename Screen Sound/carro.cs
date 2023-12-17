/*
solução do instrutor
4-Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int quantidadePortas;
    public int velocidade = 0;

    public void exibirInformacoes(){
        Console.WriteLine($"Informações do carro: {this.fabricante} {this.modelo}, {this.quantidadePortas} portas, {this.ano}");
    }
    
    public void acelerar(){
        Console.WriteLine("Acelerando...");
        if(velocidade < 100){
            velocidade = velocidade + 5;
        }
    }

    public void frear(){
        Console.WriteLine("Freando...");
        if(velocidade > 0){
            velocidade = velocidade - 5;
        }
    }

    public void buzinar(){
        Console.WriteLine("Bi Bi");
    }
}

 */
class carro
{
    private int ano;
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano {
        get => ano;
        set 
        {
            if(value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor Inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade {  get; set; }

    public string DescricaoDetalhada => $"Fabricante: {Fabricante}\nModelo: {Modelo}\nAno: {Ano}\nQuantidade de portas: {QuantidadePortas}";

    public void exibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: \nFabricante: {this.Fabricante}\nModelo: {this.Modelo}\nAno de fabricação:{this.Ano}\nQuantidade de portas:{this.QuantidadePortas}\nVelocidade: {this.Velocidade}");
    }

    public void acelerar()
    {
        Console.WriteLine("Acelerando...");
        if(Velocidade < 100)
        {
            Velocidade += 5;
        }
    }

    public void frear(int subvelo) 
    {
        Console.WriteLine("Freando...");
        if(Velocidade > 0)
        {
            int veloAtual = Velocidade - subvelo;
            Console.WriteLine($"{Velocidade} - {subvelo}: velocidade atual: {veloAtual}");
        }
    }

    public void buzinar()
    {
        Console.WriteLine("BI BI");
    }
}