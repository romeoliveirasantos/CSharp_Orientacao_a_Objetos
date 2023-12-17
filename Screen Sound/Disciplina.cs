

class Disciplina
{
    public string NomeDisciplina { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new();
}