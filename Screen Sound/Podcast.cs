//class Podcast
//{
//minha solução
//    public Podcast(string host, string nome)
//    {
//        Host = host;
//        Nome = nome;
//    }

//    public string Host { get; set; }
//    public string Nome { get; set; }
//    public int TotalEpisodios { get;}
//    private int totalEpisodios;

//    private List<Episodio> epsodios = new List<Episodio>();


//    public void AdicionarEpisodio(Episodio epsodio)
//    {
//        epsodios.Add(epsodio);
//    }

//    public void ExibirDetalhes()
//    {
//        Console.WriteLine($"Podcast: {this.Nome}\nHost: {this.Host}\n\n");
//        Console.WriteLine("Episódios:");
//        foreach (var episodio in epsodios)
//        {
//            totalEpisodios = episodio.Numero;
//            Console.WriteLine($"N° {episodio.Numero} - Título: {episodio.Titulo} - Resumo: {episodio.Resumo} - Duração: {episodio.Duracao} horas.");
//        }
//        Console.WriteLine($"\n\nTotal de episódios: {totalEpisodios}");

//    }


//}

class PodCast
{
    private List<Episodio> episodios = new();
    public PodCast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcaste{Nome} apresentado por {Host}\n");

        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episódios.");
    }
}