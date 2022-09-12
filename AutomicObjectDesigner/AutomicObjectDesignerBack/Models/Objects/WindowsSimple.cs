using System.ComponentModel.DataAnnotations;

namespace AutomicObjectDesigner.Models.Objects;

public class WindowsSimple : Job
{
    //Step 1:
    public string? WinServer { get; set; }
    public string? WinLogin { get; set; }
    public string? SapSid { get; set; }
    public string? SapClient { get; set; }
    public bool? RoutineJob { get; set; }
    public string? ProcessName { get; set; }
    public string? NameSuffix { get; set; }
    public bool? DeleteSapJob { get; set; }
    ////Step 2:
    //public string? ObjectName { get; set; }
    ////Step 3:
    //public string? ProcessInfo { get; set; }
    ////Step 4:
    //public string? Docu { get; set; }
    ////Step 5:
    //[Required]
    //[MaxLength(200)]
    //public string? Title { get; set; }
    //[Required]
    //[MaxLength(60)]
    //public string? Archive1 { get; set; }
    //[Required]
    //[MaxLength(20)]
    //public string? Archive2 { get; set; }
    //[Required]
    //[MaxLength(16)]
    //public string? InternalAccount { get; set; }
    //public string? Floder { get; set; }
}