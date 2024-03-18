using Avalonia.Media.Imaging;
using JapTutor.Shared.Enum;

namespace JapTutor.Avalonia.Models;

public class BasicInfoWithImage
{
    public string Id { get; set; } = string.Empty;
    public string? Name { get; set; }
    public BasicInfoEnum Type { get; set; }
    public Bitmap? ImageUrl { get; set; }
    public string? AudioUrl { get; set; }
}