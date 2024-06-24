using System;
using System.IO;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using JapTutor.Avalonia.Models;

namespace JapTutor.Avalonia.Common;

public class Tool
{

    public static async Task<BasicInfo?> GetHiraganaByName(string name)
    {
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana");
        BasicInfo basicInfo = null;
        foreach (string imagePath in files)
        {
            if (imagePath.EndsWith($"{name}.png"))
            {
                string[] audioFiles = Directory.GetFiles(DataBlock.AudioBasePath);
                foreach (string audioPath in audioFiles)
                {
                    if (audioPath.EndsWith($"{name}.mp3"))
                    {
                        basicInfo = new()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = $"{name}",
                            Type = BasicInfoEnum.Hiragana,
                            ImageUrl = await LoadImageAsync(imagePath),
                            AudioUrl = audioPath
                        };
                        return basicInfo;
                    }
                }
            }
        }
        return basicInfo;
    }
    
    
    private static async Task<Bitmap> LoadImageAsync(string imagePath)
    {
        try
        {
            using (var stream = File.OpenRead(imagePath))
            {
                return new Bitmap(stream);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image: {ex.Message}");
            return null;
        }
    }

}