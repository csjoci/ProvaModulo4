namespace ProvaModulo4.CleanArch.Domain.Model;

public class Curso: IEntity
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public bool Ativo { get; set; }
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
    public List<Matricula> Matriculas { get; set; } //no maximo 30

}
