
using JapTutor.Shared.Models;
using JapTutor.WebApi.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JapTutor.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasicInfoController : ControllerBase
    {
        private readonly IBasicInfoRepository _basicPronunciationRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string webRootPath;

        // public BasicInfoController(IBasicInfoRepository basicInfoRepository)
        // {
        //     _basicPronunciationRepository = basicInfoRepository;
        // }

        public BasicInfoController(IBasicInfoRepository basicPronunciationRepository,
                                   IWebHostEnvironment webHostEnvironment)
        {
            _basicPronunciationRepository = basicPronunciationRepository;
            _webHostEnvironment = webHostEnvironment;
            webRootPath = _webHostEnvironment.WebRootPath;
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
        public ActionResult<BasicInfo> GetAllKatakana()
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
        
        [HttpGet("image/{fileName}")]
        public IActionResult GetImage(string fileName)
        {
            string _imageFolderPath = "Images/hiragana";
            var imagePath = Path.Combine(webRootPath, _imageFolderPath, fileName+".png");
            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound();
            }
            var imageBytes = System.IO.File.ReadAllBytes(imagePath);
            return File(imageBytes, "image/png"); // Adjust content type as needed
        }

        [HttpGet]
        public IActionResult GetHiraganaImgByName(string name)
        {
            string hiraganaPath = "Images/hiragana";
            var imagePath = Path.Combine(webRootPath, hiraganaPath, name + ".png");
            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound();
            }
            var imageBytes = System.IO.File.ReadAllBytes(imagePath);
            return File(imageBytes, "image/png"); // Adjust content type as needed
        }
    }
}
