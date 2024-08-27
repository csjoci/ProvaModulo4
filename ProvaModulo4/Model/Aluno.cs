namespace ProvaModulo4.CleanArch.Domain.Model;

public class Aluno : IEntity
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Email { get; set; }
    public bool Ativo { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public static Aluno NewAluno(string nome, string email)
    {
        var aluno = new Aluno();
        aluno.Nome = nome;
        aluno.Email = email;
        aluno.Ativo = true;

        return aluno;
    }


}
