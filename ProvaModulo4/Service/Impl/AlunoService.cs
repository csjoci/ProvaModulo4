using ProvaModulo4.CleanArch.Domain.Dto;
using ProvaModulo4.CleanArch.Domain.Model;
using ProvaModulo4.CleanArch.Domain.Repository;

namespace ProvaModulo4.CleanArch.Domain.Service.Impl;

public class AlunoService : IAlunoService
{
    private readonly IAlunoRepository _repository;
    public AlunoService(IAlunoRepository repository)
    {
        _repository = repository;
    }
    public void Delete(int id)
    {
        _repository.Delete(id);
    }

    public Aluno Get(int id)
    {
        return _repository.GetById(id);
    }

    public IEnumerable<Aluno> GetAll()
    {
        return _repository.GetAll();
    }

    public IEnumerable<Aluno> Post(AlunoDto alunoDto)
    {
        var entity = Aluno.NewAluno(alunoDto.Nome, alunoDto.Email);
        _repository.Add(entity);
        return _repository.GetAll();
    }

    public Aluno Put(int id, AlunoDto alunoDto)
    {
        var entity = _repository.GetById(id);
        return entity;
    }
}
