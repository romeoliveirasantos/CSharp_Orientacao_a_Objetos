class Produto
{

    private double preco = 170;
    private int estoque;
    private double valorPromocao = 40;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    { get => preco;
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                Console.WriteLine("Valor inválido, insira um valor positivo.");
            }
        }
    }
    public int Estoque
    { get => estoque;
        set
        {
            if (value > 0)
            {
                estoque = value;
            }
            else
            {
                Console.WriteLine("Valor inválido, insira um valor positivo.");
            }
        }

    }

    public double ValorPromocao
    {
        get => valorPromocao;
        set
        {
            if (value > 0)
            {
                valorPromocao = value;
            }
            else
            {
                Console.WriteLine("Valor de promoção inválido insira um valor maior que 0");
            }
        }
    }
    
    public double PrecoPromocional
    {
        get
        {
            if (preco > ValorPromocao)
            {
                return ValorPromocao;
            }
            else
            {
                return Preco;
            }
        }
    }

    public void ExibirDesconto()
    {
        if(Preco > ValorPromocao)
        {
            double desconto = Preco - ValorPromocao;
            Console.WriteLine($"De: R${preco} para R${valorPromocao}");
            Console.WriteLine($"Desconto de R${desconto}");
        }
        else
        {
            Console.WriteLine("Ultimas unidades");
        }
    }
    public string DescricaoProduto => $"Produto: {this.Nome} Marca: {this.Marca} Preço: R${this.PrecoPromocional} Quantidade no estoque: {this.Estoque}";
}