using Microsoft.AspNetCore.Mvc;
using System;

namespace Joyce_back_end_project_MSA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Testcontrollers : ControllerBase
    {

        /// <summary>
        /// Check input number
        /// </summary>
        /// <param name="input_number">Enter a number greater than 0 and smaller than 999</param>
       
        /// <returns>Input number ok to use</returns>
        [HttpGet]
        [Route("add")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult GetResult(int input_number)
        {
            if (input_number <= 0) return BadRequest("The inputs must be greater than zero");
            else if (input_number > 999 ) return BadRequest("The inputs must be smaller than 999");
            else return Ok("Your input number is " + input_number);
            //return Ok("Your input number is " + input_number);
        }

    }
}
