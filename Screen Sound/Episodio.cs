//class Episodio
//{
//minha solução
//    public int Duracao { get; set; }
//    public int Numero { get; set; }
//    public string Resumo { get; set; }
//    public string Titulo { get; set; }

//    private List<Convidado> convidados = new();

//    public Episodio(string titulo, string resumo, int numero, int duracao = 0)
//    {
//        Titulo = titulo;
//        Resumo = resumo;
//        Numero = numero;
//        Duracao = duracao;

//    }



//    public void AdicionarConvidados(Convidado convidado)
//    {
//        convidados.Add(convidado);
//    }
//}

class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get;}
    public int Duracao { get; }

                        // => lambda
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - " +
        $"{string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}