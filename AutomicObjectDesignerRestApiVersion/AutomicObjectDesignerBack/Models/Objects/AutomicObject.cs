using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesigner.Models.Objects;

[Keyless]
public abstract class AutomicObject
{
    [Required]
    [RegularExpression(@"[A-Z0-9,._$#]")]
    [MaxLength(160)]
    string Name { get; set; }
    
    [Required]
    [MaxLength(256)]
    public string Folder { get; set; }

    [MaxLength(2000)]
    string? Description { get; set; }

    string VariableKey { get; set; }

    string VariableValue { get; set; }
}