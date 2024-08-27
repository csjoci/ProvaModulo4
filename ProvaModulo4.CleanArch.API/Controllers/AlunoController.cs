﻿using Microsoft.AspNetCore.Mvc;
using ProvaModulo4.CleanArch.API.Dto;
using ProvaModulo4.CleanArch.Domain.Repository;
using ProvaModulo4.CleanArch.Domain.Model;

namespace ProvaModulo4.CleanArch.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlunoController  : ControllerBase
{
    private readonly IAlunoRepository _repository;

    public AlunoController(IAlunoRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Aluno>> GetAll()
    {
        var response = _repository.GetAll();
        return response == null? NotFound() : Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        var response = _repository.GetById(id);
        return response == null? NotFound(): Ok(response);
    }

    [HttpPost]
    public ActionResult<IEnumerable<Aluno>> Post([FromBody] AlunoDto alunoDto)
    {
        var entity = Aluno.NewAluno(alunoDto.Nome, alunoDto.Email);

        _repository.Add(entity);

        var response = _repository.GetAll();
        return response == null ? NotFound() : Ok(response);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] AlunoDto alunoDto)
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
