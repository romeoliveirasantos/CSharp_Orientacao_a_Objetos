class Podcast
{

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios { get;}
    private int totalEpisodios;

    private List<Episodio> epsodios = new List<Episodio>();
    

    public void AdicionarEpisodio(Episodio epsodio)
    {
        epsodios.Add(epsodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {this.Nome}\nHost: {this.Host}\n\n");
        Console.WriteLine("Episódios:");
        foreach (var episodio in epsodios)
        {
            totalEpisodios = episodio.Numero;
            Console.WriteLine($"N° {episodio.Numero} - Título: {episodio.Titulo} - Resumo: {episodio.Resumo} - Duração: {episodio.Duracao} horas.");
        }
        Console.WriteLine($"\n\nTotal de episódios: {totalEpisodios}");

    }
    
    
}