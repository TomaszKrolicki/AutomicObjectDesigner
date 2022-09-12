namespace AutomicObjectDesignerBack.Models.Objects.Dto
{
    public class UnixGeneralDto
    {
        public string? UnixServer { get; set; }
        public string? UnixLogin { get; set; }
        public string? SapClient { get; set; }
        public string? SapSid { get; set; }
        public string? SapReport { get; set; }

        public bool RoutineJob { get; set; }
        public string? ProcessName { get; set; }
        public string? NameSuffix { get; set; }
        public bool? DeleteSapJob { get; set; }
    }
}
