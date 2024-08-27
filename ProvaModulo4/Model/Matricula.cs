using ProvaModulo4.CleanArch.Domain.Model.Enum;

namespace ProvaModulo4.CleanArch.Domain.Model;

public class Matricula : IEntity
{
    public int Id { get; set; }
    public DateTime DataMatricula { get; set; }
    public StatusMatriculaEnum Status { get; set; }
    public int AlunoId { get; set; }  
    public Aluno Aluno { get; set; }
    public int CursoId { get; set; }  
    public Curso Curso { get; set; }

    public static Matricula NewMatricula(int idAluno, int idCurso)
    {
        var matricula = new Matricula();
        matricula.Status = Enum.StatusMatriculaEnum.Ativa;
        matricula.AlunoId = idAluno;
        matricula.CursoId = idCurso;
        matricula.DataMatricula = DateTime.Now;
        return matricula;

    }

}
