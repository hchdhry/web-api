using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Test.models;

namespace test.Controller
{
    [ApiController]
    [Route("api/test")]

    public class testController : ControllerBase
    {



        [HttpGet(Name = "GetCarDetails")]
        public IEnumerable<Car> Get()
        {
            return new List<Car>{
                new Car()
                {
                    name="test",
                    weight = 123,
                    registration = "t3st"
                },
                   new Car()
                {
                    name="test1",
                    weight = 1234,
                    registration = "t3st1"
                }
            };

        }

    }
}