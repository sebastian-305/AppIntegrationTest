using System.Threading.Tasks;
using AppIntegrationTest.Domain.Models;
using AppIntegrationTest.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AppIntegrationTest.Api.Controller;

[ApiController]
[Route("api/lectures")]
public class LecturesController : ControllerBase
{

    private readonly ILectureRepository _repository;

    public LecturesController(ILectureRepository repository)
    {
        _repository = repository;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Lecture>>> GetAll()
    {
        var lectures = await _repository.FindAllAsync();

        return Ok(lectures);
    }


    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id}")]
    public async Task<ActionResult<Lecture>> GetAsync(int id)
    {
        var lecture = await _repository.FindByIdAsync(id);

        if (lecture == null)
            return NotFound();

        return Ok(lecture);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    
    [HttpPost]
    public async Task<ActionResult<Lecture>> Post(Lecture lecture)
    {
        var newLecture = await _repository.AddAsync(lecture);
        return Created(nameof(GetAsync),newLecture);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpPut("{id}")]
    public async Task<ActionResult<Lecture>> PutAsync(int id, Lecture putLecture)
    {
        var lecture = await _repository.FindByIdAsync(id);

        if (lecture == null)
            return NotFound();

        putLecture.Id = id;

        await _repository.UpdateAsync(putLecture);

        return Ok(putLecture);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpDelete("{id}")]
    public async Task<ActionResult<Lecture>> DeleteAsync(int id)
    {
        var lecture = await _repository.FindByIdAsync(id);

        if (lecture == null)
            return NotFound();

       await _repository.DeleteAsync(lecture);

        return Ok(lecture);
    }
}
