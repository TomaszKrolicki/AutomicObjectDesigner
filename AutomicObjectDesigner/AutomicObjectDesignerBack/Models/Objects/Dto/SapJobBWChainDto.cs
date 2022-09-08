namespace AutomicObjectDesignerBack.Models.Objects.Dto
{
    public class SapJobBWChainDto
    {
        public string SapSid { get; set; }
        public string SapClient { get; set; }
        public string SapKette { get; set; }
        public bool RoutineJob { get; set; }
        public bool DeleteSapJob { get; set; }
        public string ProcessName { get; set; }
        public string SapJobName { get; set; }
    }
}
