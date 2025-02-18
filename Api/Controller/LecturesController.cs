using AppIntegrationTest.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AppIntegrationTest.Api.Controller;

[ApiController]
[Route("api/lectures")]
public class LecturesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Lecture>> GetAll()
    {        

        return Ok(new Lecture[] { });
    }


    [HttpGet("{id}")]
    public ActionResult<Lecture> Get(int id)
    {
        if (id != 1)
        {
            return NotFound();
        }

        return Ok(new Lecture() { Id = 1 });
    }

    [HttpPost]
    public ActionResult<Lecture> Post(Lecture lecture)
    {
        return Ok(new Lecture() { });
    }


    [HttpPut("{id}")]
    public ActionResult<Lecture> Put(int id)
    {
        return Ok(new Lecture() { });
    }

    [HttpDelete("{id}")]
    public ActionResult<Lecture> Delete(int id)
    {
        return Ok(new Lecture() { });
    }
}
