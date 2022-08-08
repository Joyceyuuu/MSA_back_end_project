using Microsoft.AspNetCore.Mvc;

namespace Joyce_back_end_project_MSA.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class AnimalCrossingController : ControllerBase
        {
            private readonly HttpClient _client;

            public AnimalCrossingController(IHttpClientFactory clientFactory)
            {
                if (clientFactory is null)
                {
                 throw new ArgumentNullException(nameof(clientFactory));
                }
                _client = clientFactory.CreateClient("animalCrossing");
            }

      


        /// <summary>
        /// Gets the raw JSON from API.
        /// </summary>
        /// <returns>A JSON object return as defualt data</returns>
        [HttpGet(Name = "GetAnimalCrossingInfor")]
            [ProducesResponseType(200)]
            public async Task<IActionResult> GetRawRedditHotPosts()
            {
                var res = await _client.GetAsync("");
                var content = await res.Content.ReadAsStringAsync();
                return Ok(content);
            }

            
            /// <summary>
            /// In the same Controller class, use two [HttpGet] is not allow, 
            /// so change one of the controller as [HttpPost] 
            /// to allow these two requests. 
            /// </summary>
            /// <param name="input"></param>
            /// <returns></returns>
            [HttpPost(Name = "GetAnimalCrossingInfor1")]
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
