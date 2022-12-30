using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using taofitAPI.Data.Models;
using taofitAPI.Services;

namespace taofitAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodsController : ControllerBase
    {
        public FoodsService _foodsService;
        public FoodsController(FoodsService foodsService){
            _foodsService = foodsService;
        }

        [HttpPost("AddFood")]
        public IActionResult AddFood([FromBody]Food food)
        {
            _foodsService.AddFood(food);
            return Ok();
        }

    }
}