using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesigner.Models.Objects;

public abstract class AutomicObject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int OwnerId { get; set; }

    [RegularExpression(@"[A-Z0-9,._$#]")]
    [MaxLength(160)]
    string Name { get; set; }
    
    [MaxLength(256)]
    public string? Folder { get; set; }

    [MaxLength(2000)]
    string? Description { get; set; }

    string VariableKey { get; set; }

    string VariableValue { get; set; }
}