namespace ProvaModulo4.CleanArch.Domain.Model;

public class Curso: IEntity
{
    public int Id { get; set; }
    public string Título { get; set; }
    public string Descricao { get; set; }
    public bool Ativo { get; set; }
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
    public List<Matricula> Matriculas { get; set; } //no maximo 30

    public static Curso NewCurso(string titulo, int idProfessor)
    {
        var curso = new Curso();
        curso.Título = titulo;
        curso.ProfessorId = idProfessor;
        curso.Ativo = true;
        return curso;
    }

}
