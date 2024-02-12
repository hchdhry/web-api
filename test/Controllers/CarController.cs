using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Test.models;
using Test.Data;

namespace test.Controller
{
    [ApiController]
    [Route("api/test")]

    public class testController : ControllerBase
    {
        private readonly AppDBContext _DBcontext;
        public testController(AppDBContext context)
        {
            _DBcontext = context;
        }
 


        [HttpPost(Name = "GetCarDetails")]
        public IActionResult Post(string registration)
        {
            Car ? car = _DBcontext.cars.FirstOrDefault(u=>u.registration==registration);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);

        }

    }
}