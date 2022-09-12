namespace AutomicObjectDesignerBack.Models.Objects.Dto
{
    public class WindowsSimpleDto
    {
        public string WinServer { get; set; }
        public string WinLogin { get; set; }
        public string SapSid { get; set; }
        public string SapClient { get; set; }
        public bool RoutineJob { get; set; }
        public string ProcessName { get; set; }
        public string NameSuffix { get; set; }
        public bool DeleteSapJob { get; set; }
    }
}
