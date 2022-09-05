using System.ComponentModel.DataAnnotations;

namespace AutomicObjectDesigner.Models.Objects;

public class WindowsSimple : Job
{
    //Step 1:
    public enum EnumWinServer { server1, server2 ,server3 }
    public enum EnumWinLogin { login1, login2, login3 }
    public enum EnumSapSid { sid1, sid2 , sid3 }
    public enum EnumSapClient { client1, client2 , client3 }
    public enum EnumRoutineJob { yes, no }
    [Required]
    [StringLength(7)]
    public string? ProcessName { get; set; }
    [Required]
    [MaxLength(40)]
    public string? NameSuffix { get; set; }
    //Step 2:
    public string? ObjectName { get; set; }
    //Step 3:
    public string? ProcessInfo { get; set; }
    //Step 4:
    public string? Docu { get; set; }
    //Step 5:
    [Required]
    [MaxLength(200)]
    public string? Title { get; set; }
    [Required]
    [MaxLength(60)]
    public string? Archive1 { get; set; }
    [Required]
    [MaxLength(20)]
    public string? Archive2 { get; set; }
    [Required]
    [MaxLength(16)]
    public string? InternalAccount { get; set; }
    public string? Floder { get; set; }
}