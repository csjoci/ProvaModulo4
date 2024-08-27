using Microsoft.AspNetCore.Mvc;
using ProvaModulo4.CleanArch.API.Dto;
using ProvaModulo4.CleanArch.Domain.Model;
using ProvaModulo4.CleanArch.Domain.Repository;

namespace ProvaModulo4.CleanArch.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProfessorController : ControllerBase
{
    private readonly IProfessorRepository _repository;

    public ProfessorController(IProfessorRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Professor>> GetAll()
    {
        var response = _repository.GetAll();
        return response == null ? NotFound() : Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        var response = _repository.GetById(id);
        return response == null ? NotFound() : Ok(response);
    }

    [HttpPost]
    public ActionResult<IEnumerable<Professor>> Post([FromBody] ProfessorDto professorDto)
    {
        var entity = Professor.NewProfessor(professorDto.Nome, professorDto.Email);

        _repository.Add(entity);

        var response = _repository.GetAll();
        return response == null ? NotFound() : Ok(response);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] ProfessorDto professorDto)
    {
        var entity = _repository.GetById(id);

        //alunoEntidade.AlterarNome(alunoDto.Nome);

        //_repository.Alterar(alunoEntidade);

        return entity == null ? NotFound() : Ok(entity);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _repository.Delete(id);
    }
}
