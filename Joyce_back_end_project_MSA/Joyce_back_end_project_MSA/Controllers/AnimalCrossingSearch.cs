using Microsoft.AspNetCore.Mvc;

namespace Joyce_back_end_project_MSA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalCrossingSearchController : ControllerBase
    {
        private readonly HttpClient _client;

        public AnimalCrossingSearchController(IHttpClientFactory clientFactory)
        {
            if (clientFactory is null)
            {
                throw new ArgumentNullException(nameof(clientFactory));
            }
            _client = clientFactory.CreateClient("animalCrossing");
        }


        /// <summary>
        /// User can input a number to search different information
        /// </summary>
        /// <returns>A JSON object representing the return infor</returns>
        [HttpGet(Name = "GetAnimalCrossingSearchInfor")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetInputInfor(int input)
        {
            var res1 = await _client.GetAsync(input.ToString());
            var content1 = await res1.Content.ReadAsStringAsync();
            if (input < 0) return BadRequest("Please input a number to get different API data.");
            return Ok(content1);
        }
    }
}
