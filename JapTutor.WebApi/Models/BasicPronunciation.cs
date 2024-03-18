using System.ComponentModel.DataAnnotations;
using JapTutor.Shared.Enum;

namespace JapTutor.WebApi.Models;

public class BasicPronunciation
{
    [Key]
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public BasicPronunciationEnum Type = default!;
    public string PronunciationUrl = string.Empty;
}