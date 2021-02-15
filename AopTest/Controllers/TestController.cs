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
        [HttpGet(nameof(Test))]
        public async Task<IActionResult> Test()
        {
            DoStuff();
            return new OkObjectResult(true);
        }


        [TestInterceptor]
        public void DoStuff()
        {
            Console.WriteLine("I do stuff");
        }
    }
}