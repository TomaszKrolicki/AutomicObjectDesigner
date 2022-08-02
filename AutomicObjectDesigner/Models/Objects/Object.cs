using System.ComponentModel.DataAnnotations;

namespace AutomicObjectDesigner.Models.Objects;

public abstract class Object
{
    [Required]
    [RegularExpression(@"[A-Z0-9,._$#]")]
    [MaxLength(200)]
    string Name { get; set; }
    [Required]
    [MaxLength(200)]
    string Title { get; set; }
    [MaxLength(2000)]
    string? Description { get; set; }

    string VariableKey { get; set; }
    string VariableValue { get; set; }
}