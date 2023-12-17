class Album
{
    private List<Musica> musicas = new(); //campo privado, só está disponível dentro do bloco Album 
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void exibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {this.Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de: {DuracaoTotal}");
    }
}
/*
 * No C#, podemos criar um relacionamento entre classes utilizando a composição, que é uma forma de relacionamento em que uma classe possui uma instância de outra classe como um de seus membros. Isso permite que a classe tenha acesso aos membros e comportamentos da classe relacionada, como ilustra o código abaixo:
 */