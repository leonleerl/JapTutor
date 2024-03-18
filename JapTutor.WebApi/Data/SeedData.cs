using JapTutor.Shared.Common;
using JapTutor.Shared.Enum;
using JapTutor.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JapTutor.WebApi.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new JapTutorDbContext(
                   serviceProvider.GetRequiredService<DbContextOptions<JapTutorDbContext>>()))
        {
            if (context.BasicPronunciations.Any())
                return;
            context.BasicPronunciations.AddRange(
                new BasicPronunciation()
                {
                    Name = "a",
                    Type = BasicPronunciationEnum.Hiragana,
                    ImgUrl = "https://cdn.goconqr.com/uploads/flash_card/image_question/243669/a.png",
                    PronunciationUrl = ""
                },
                new BasicPronunciation()
                {
                    Name = "i",
                    Type = BasicPronunciationEnum.Hiragana,
                    ImgUrl = Tools.BaseImgUrl + "243671/i.png",
                    PronunciationUrl = ""
                },
                new BasicPronunciation()
                {
                    Name = "u",
                    Type = BasicPronunciationEnum.Hiragana,
                    ImgUrl = Tools.BaseImgUrl + "243673/u.png",
                    PronunciationUrl = ""
                },
                new BasicPronunciation()
                {
                    Name = "e",
                    Type = BasicPronunciationEnum.Hiragana,
                    ImgUrl = Tools.BaseImgUrl + "243670/e.png",
                    PronunciationUrl = ""
                },
                new BasicPronunciation()
                {
                    Name = "o",
                    Type = BasicPronunciationEnum.Hiragana,
                    ImgUrl = Tools.BaseImgUrl + "243672/o.png",
                    PronunciationUrl = ""
                },
                new BasicPronunciation()
                {
                    Name = "ka",
                    Type = BasicPronunciationEnum.Hiragana,
                    ImgUrl = Tools.BaseImgUrl + "243680/ka.png",
                    PronunciationUrl = ""
                }
            );
            context.SaveChanges();
        }
    }
}