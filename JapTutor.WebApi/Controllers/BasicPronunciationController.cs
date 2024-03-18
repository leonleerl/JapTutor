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
        public async Task<ActionResult<IEnumerable<BasicInfo>>> GetAll()
        {
            var basicPronunciations = await _basicPronunciationRepository.GetAllAsync();
            if (basicPronunciations == null)
                return NotFound();
            return Ok(basicPronunciations);
        }

        [HttpGet]
        public ActionResult<BasicInfo> GetByName(string name)
        {
            var basicPronunciation =  _basicPronunciationRepository.GetByName(name);
            if (basicPronunciation == null)
                return NotFound();
            return Ok(basicPronunciation);
        }

        [HttpGet]
        public async Task<ActionResult<BasicInfo>> GetById(string id)
        {
            var basicPronunciation = await _basicPronunciationRepository.GetById(id);
            if (basicPronunciation == null)
                return NotFound();
            return Ok(basicPronunciation);
        }

        [HttpGet]
        public ActionResult<BasicInfo> GetAllHiragana()
        {
            var hiraganas = _basicPronunciationRepository.GetAllHiragana();
            if (hiraganas == null)
                return NotFound();
            return Ok(hiraganas);
        }

        [HttpGet]
        public ActionResult<BasicInfo> GetAllKatagana()
        {
            var katakanas = _basicPronunciationRepository.GetAllKatakana();
            if (katakanas == null)
                return NotFound();
            return Ok(katakanas);
        }
        
        [HttpGet]
        public ActionResult<BasicInfo> GetAllKanji()
        {
            var kanjis = _basicPronunciationRepository.GetAllKanji();
            if (kanjis == null)
                return NotFound();
            return Ok(kanjis);
        }
    }
}
