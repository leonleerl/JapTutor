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
            if (context.BasicInfos.Any())
                return;
            context.BasicInfos.AddRange(
                new BasicInfo()
                {
                    Name = "a",
                    Type = BasicInfoEnum.Hiragana,
                    ImageUrl = "https://cdn.goconqr.com/uploads/flash_card/image_question/243669/a.png",
                    AudioUrl = ""
                },
                new BasicInfo()
                {
                    Name = "i",
                    Type = BasicInfoEnum.Hiragana,
                    ImageUrl = Tools.BaseImgUrl + "243671/i.png",
                    AudioUrl = ""
                },
                new BasicInfo()
                {
                    Name = "u",
                    Type = BasicInfoEnum.Hiragana,
                    ImageUrl = Tools.BaseImgUrl + "243673/u.png",
                    AudioUrl = ""
                },
                new BasicInfo()
                {
                    Name = "e",
                    Type = BasicInfoEnum.Hiragana,
                    ImageUrl = Tools.BaseImgUrl + "243670/e.png",
                    AudioUrl = ""
                },
                new BasicInfo()
                {
                    Name = "o",
                    Type = BasicInfoEnum.Hiragana,
                    ImageUrl = Tools.BaseImgUrl + "243672/o.png",
                    AudioUrl = ""
                },
                new BasicInfo()
                {
                    Name = "ka",
                    Type = BasicInfoEnum.Hiragana,
                    ImageUrl = Tools.BaseImgUrl + "243680/ka.png",
                    AudioUrl = ""
                }
            );
            context.SaveChanges();
        }
    }
}