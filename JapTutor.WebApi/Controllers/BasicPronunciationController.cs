using JapTutor.WebApi.Models;
using JapTutor.WebApi.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JapTutor.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasicPronunciationController : ControllerBase
    {
        private readonly IBasicPronunciationRepository _basicPronunciationRepository;

        public BasicPronunciationController(IBasicPronunciationRepository basicPronunciationRepository)
        {
            _basicPronunciationRepository = basicPronunciationRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicPronunciation>>> GetAll()
        {
            var basicPronunciations = await _basicPronunciationRepository.GetAllAsync();
            if (basicPronunciations == null)
                return NotFound();
            return Ok(basicPronunciations);
        }

        [HttpGet]
        public async Task<ActionResult<BasicPronunciation>> GetByName(string name)
        {
            var basicPronunciation = await _basicPronunciationRepository.GetByNameAsync(name);
            if (basicPronunciation == null)
                return NotFound();
            return Ok(basicPronunciation);
        }
    }
}
