using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace AutomicObjectDesigner.Models.Registration;

public abstract class People
{
    [Required]
    [StringLength(16)]
    [RegularExpression(@"[a-zA-Z]{2,16}", ErrorMessage = "Valid Charactors include (A-Z) (a-z), max length 16")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(32)]
    [RegularExpression("([a-zA-Z]{2,})?", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -), max length 32")]
    public string LastName { get; set; }
    public string Name => $"{FirstName} {LastName}";

    [Required]
    [StringLength(32)]
    [RegularExpression(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}")]
    public string Email { get; set; }

    public bool HasEmailConfirmed { get; set; }
    public bool IsAdministrator { get; set; }

}