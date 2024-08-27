using ProvaModulo4.CleanArch.Domain.Model;
using ProvaModulo4.CleanArch.Domain.Dto;

namespace ProvaModulo4.CleanArch.Domain.Service;

public interface IAlunoService
{
    public IEnumerable<Aluno> GetAll();
    public Aluno Get(int id);
    public IEnumerable<Aluno> Post(AlunoDto alunoDto);
    public Aluno Put(int id, AlunoDto alunoDto);
    public void Delete(int id);
}
