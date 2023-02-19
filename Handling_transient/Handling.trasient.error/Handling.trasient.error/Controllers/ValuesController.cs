using Microsoft.AspNetCore.Mvc;

namespace Handling.trasient.error.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{

    [HttpGet]
    public ActionResult<int> ReturnRandom()
    {
        Random rand = new Random();
        int gen = rand.Next(1, 11);

        if(gen > 5)
        {
            return StatusCode
        }
    }

}