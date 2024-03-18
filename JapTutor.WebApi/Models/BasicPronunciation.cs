using System.ComponentModel.DataAnnotations;
using JapTutor.Shared.Enum;

namespace JapTutor.WebApi.Models;

public class BasicPronunciation
{
    [Key]
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public BasicPronunciationEnum Type { get; set; } = default!;
    public string ImgUrl { get; set; } = string.Empty;
    public string PronunciationUrl { get; set; } = string.Empty;
}