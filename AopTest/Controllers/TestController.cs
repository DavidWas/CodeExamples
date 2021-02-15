using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Norns.Urd.Interceptors;
using Norns.Urd.Attributes;

namespace AopTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [LogCall]
        [HttpGet(nameof(Test))]
        public async Task<IActionResult> Test()
        {
            Console.WriteLine("Running Controller Method...");
            return new OkObjectResult(true);
        }


        // [TestInterceptor]
        // public virtual void DoStuff()
        // {
        //     Console.WriteLine("I do stuff");
        // }
    }
}