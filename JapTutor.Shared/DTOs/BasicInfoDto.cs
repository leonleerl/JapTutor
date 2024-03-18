using JapTutor.Shared.Enum;

namespace JapTutor.Shared.DTOs;

public class BasicInfoDto
{
    public string Id { get; set; } = string.Empty;
    public string? Name { get; set; }
    public BasicInfoEnum Type { get; set; }
    public string? ImageUrl { get; set; }
    public string? AudioUrl { get; set; }
}