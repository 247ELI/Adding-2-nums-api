using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace adding2numsAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Adding2NumsController : ControllerBase
    {
        [HttpGet]
        [Route("adding2nums/{num1}/{num2}")]
        public string Adding2Nums(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            return $"The sum of {num1} and {num2} is {sum}";
        }
    }
}