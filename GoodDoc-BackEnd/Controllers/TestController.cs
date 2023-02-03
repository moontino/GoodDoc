using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoodDoc_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetTest()
        {
            string json = @"{
                      'Name': 'Bad Boys',
                      'ReleaseDate': '1995-4-7T00:00:00',
                      'Genres': [
                        'Action',
                     'Comedy'
                      ]
                    }";
            return new JsonResult(json);
        }
    }
}