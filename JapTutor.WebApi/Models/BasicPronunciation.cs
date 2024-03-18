using System.ComponentModel.DataAnnotations;
using JapTutor.Shared.Enum;

namespace JapTutor.WebApi.Models;

public class BasicInfo
{
    [Key]
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public BasicInfoEnum Type { get; set; } = default!;
    public string ImageUrl { get; set; } = string.Empty;
    public string AudioUrl { get; set; } = string.Empty;
}