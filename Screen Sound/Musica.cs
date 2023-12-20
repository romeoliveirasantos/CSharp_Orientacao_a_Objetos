//agrupamento por {} e nome exemplo: class Homem {}
internal class Musica
{
    //atributos da classe
    //tipo de dados primitivos
    //public deixa esse dado acessível

    //construtor - oferece a oportunidade de construir algo no momento da declaração - não tem retorno(void)

    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public string Nome { get; }

    public Banda Artista { get;}
    public int Duracao { get; set; }    
    public bool Disponivel { get; set; } //get leitura, set escrita e a partir de agora se torna uma propriedade

    public Genero Genero { get; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}"; //utilizando arrow function que no c# se chama lambda
    /*{
        get 
        {
            return $"A música {Nome} pertence a banda {Artista}";
        }
    } //criando propriedade com atalho prop e com construção obsoleta 
    */


    //metodos para centralizar acesso e garantir um pouco de segurança a aplicação
    public void EscreveDisponivel(bool value)
    {
        Disponivel = value;
    }
    public bool LeDisponivel()
    {
        return Disponivel;
    }
    //esse método representa o comportamento de qualquer objeto da classe música
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Genero: {Genero.Nome}");

        if (Disponivel)
        {
            Console.WriteLine($"Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        Console.WriteLine("\n\n");
    }
}