using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Models.Objects
{
    public class SapJobBwChain : Job
    {
        // step 1

        public enum SapSid { get; set; }
        public enum SapClient { get; set; }
        public string? Kette { get; set; }
        public bool RoutineJob { get; set; }
        public string? ProcessName { get; set; }
        public string? SapJobName { get; set; }
        public bool DeleteSapJob { get; set; }

        // step 2

        public string? ObjectName { get; set; }
        public string? Kette { get; set; }

        //step 3
        //<docu>

        //step 4
        public string? Title { get; set; }
        public string? Archive1 { get; set; }
        public string? Archive2 { get; set; }
        public string? InternalAccount { get; set; }
        // <folder>
    }
}
