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
            /// Gets the raw JSON for the hot feed in XXXXXXX
            /// </summary>
            /// <returns>A JSON object representing the hot feed in XXXXXX</returns>
            [HttpGet(Name = "GetAnimalCrossingInfor")]
            [Route("raw")]
            [ProducesResponseType(200)]
            public async Task<IActionResult> GetRawRedditHotPosts()
            {
                var res = await _client.GetAsync("/hot");
                var content = await res.Content.ReadAsStringAsync();
                return Ok(content);
            }

        }
}
