namespace AutomicObjectDesignerBack.Models.Objects.Dto
{
    public class WindowsGeneralDto
    {
        public string WinServer { get; set; }
        public string WinLogin { get; set; }
        public string SapSid { get; set; }
        public string SapClient { get; set; }
        public string? SapReport { get; set; }
        public bool RoutineJob { get; set; }
        public string? PorcessName { get; set; }
        public string? NameSuffix { get; set; }
        public bool? DeleteSapJob { get; set; }
    }
}
