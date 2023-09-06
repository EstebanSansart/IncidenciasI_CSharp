using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiIncidenciasI.Controllers;
public class IncidenceController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public IncidenceController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Incidence>>> Get()
    {
        var incidences = await _unitOfWork.Incidences.GetAllAsync();
        return Ok(incidences);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var incidence = await _unitOfWork.Incidences.GetByIdAsync(id);
        return Ok(incidence);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Incidence>> Post(Incidence incidencePO){
        this._unitOfWork.Incidences.Add(incidencePO);
        await _unitOfWork.SaveAsync();
        if (incidencePO == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id = incidencePO.Id}, incidencePO);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Incidence>> Put(int id, [FromBody]Incidence incidencePU){
        if(incidencePU == null)
        {
            return NotFound();
        }
        _unitOfWork.Incidences.Update(incidencePU);
        await _unitOfWork.SaveAsync();
        return incidencePU;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var incidenceD = await _unitOfWork.Incidences.GetByIdAsync(id);
        if(incidenceD == null)
        {
            return NotFound();
        }
        _unitOfWork.Incidences.Remove(incidenceD);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}