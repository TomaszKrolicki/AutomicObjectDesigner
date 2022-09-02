namespace AutomicObjectDesignerBack.Models.Objects
{
    public class SapSimpleDTO
    {
        public string? SapClient { get; set; }
        public string? SapSid { get; set; }
        public string? SapReport { get; set; }

        public string? SapVariant { get; set; }
        public bool? RoutineJob { get; set; }
        public string? ProcessName { get; set; }
        public string? SapJobName { get; set; }
        public bool? DeleteSapJob { get; set; }
    }
}
