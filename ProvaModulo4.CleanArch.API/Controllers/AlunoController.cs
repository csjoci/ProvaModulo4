using Microsoft.AspNetCore.Mvc;
using ProvaModulo4.CleanArch.Domain.Dto;
using ProvaModulo4.CleanArch.Domain.Model;
using ProvaModulo4.CleanArch.Domain.Service;

namespace ProvaModulo4.CleanArch.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlunoController  : ControllerBase
{
    private readonly IAlunoService _service;

    public AlunoController(IAlunoService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Aluno>> GetAll()
    {
        var response = _service.GetAll();
        return response == null? NotFound() : Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        var response = _service.Get(id);
        return response == null? NotFound(): Ok(response);
    }

    [HttpPost]
    public ActionResult<IEnumerable<Aluno>> Post([FromBody] AlunoDto alunoDto)
    {
        var response = _service.Post(alunoDto);
        return response == null ? NotFound() : Ok(response);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] AlunoDto alunoDto)
    {
        var entity = _service.Get(id);

        //alunoEntidade.AlterarNome(alunoDto.Nome);

        //_service.Alterar(alunoEntidade);

        return entity == null ? NotFound() : Ok(entity);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _service.Delete(id);
    }

}
