using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Models.Objects
{
    public class WindowsGeneral : Job
    {
        //Entry sequence:
        // step 1
        public string WinServer { get; set; }
        public string WinLogin { get; set; }
        public string SapSid { get; set; }
        public string SapClient { get; set; }
        public string? SapReport { get; set; }
        public bool RoutineJob { get; set; }
        public string? PorcessName { get; set; }
        public string? NameSuffix { get; set; }
        public bool? DeleteSapJob { get; set; }

        // step 2

        public string? ObjectName { get; set; }

        //step 3
        public string? Process1 { get; set; }

        //step 4
        public string? Docu1 { get; set; }

        //step 5

        public string? Title1 { get; set; }
        public string? Archive1 { get; set; }
        public string? Archive2 { get; set; }
        public string? InternalAccount1 { get; set; }
        //<folder>

        //step 6
        //up to 5 set's of variables
        public string? VariableKey1 { get; set; }
        public string? VariableValue1 { get; set; }
        public string? VariableKey2 { get; set; }
        public string? VariableValue2 { get; set; }
        public string? VariableKey3 { get; set; }
        public string? VariableValue3 { get; set; }
        public string? VariableKey4 { get; set; }
        public string? VariableValue4 { get; set; }
        public string? VariableKey5 { get; set; }
        public string? VariableValue5 { get; set; }

        //outcome
        //Fixed predefined fields:

        public string? Template { get; set; }
        public string? PreProcess1 { get; set; }
        public string? PostProcess1 { get; set; }

        //Calculated fields:
        public string? Queue1 { get; set; }

        // Multiline fields:
        public string? VariableKey { get; set; }
        public string? VariableValue { get; set; }

        public string? Process2 { get; set; }

        public string? Docu { get; set; }

        //other fields

        public string? Login1 { get; set; }
        public string? Agent1 { get; set; }
        public string Name1 { get; set; }
        public string Title { get; set; }

        public string JobName { get; set; }
        public bool NeverDeleteJob { get; set; }
        public string? ArchiveKey1 { get; set; }
        public string? ArchiveKey2 { get; set; }
        public string? InternalAccount { get; set; }
        //<folder>

    }
}
