class Episodio
{
    public int Duracao { get; set; }
    public int Numero { get; set; }
    public string Resumo { get; set; }
    public string Titulo { get; set; }

    private List<Convidado> convidados = new();

    public Episodio(string titulo, string resumo, int numero, int duracao = 0)
    {
        Titulo = titulo;
        Resumo = resumo;
        Numero = numero;
        Duracao = duracao;

    }



    public void AdicionarConvidados(Convidado convidado)
    {
        convidados.Add(convidado);
    }
}