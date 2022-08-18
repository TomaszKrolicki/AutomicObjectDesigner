namespace AutomicObjectDesigner.Models.Objects;

public class SapSimple : Job
{
    //Entry sequence:
    // step 1

    //public enum SapSid { get; set; }
    //public enum SapClient { get; set; }
    public string? SapReport { get; set; }

    public string? SapVariant { get; set; }
    public bool RoutineJob { get; set; }
    public string? PorcessName { get; set; }
    public string? SapJobName { get; set; }
    public bool DeleteSapJob { get; set; }

    // step 2

    public string? ObjectName { get; set; }
    public string? SapReport2 { get; set; }
    public string? SapVariant1 { get; set; }

    //step 3
    public string? Docu1 { get; set; }

    //step 4
    public string? Title1 { get; set; }
    public string? Archive1 { get; set; }
    public string? Archive2 { get; set; }
    public string? InternalAccount1 { get; set; }

    //outcome
    //Fixed predefined fields:

    public string? Template { get; set; }
    public string? Process { get; set; }
    public string? PreProcess { get; set; }
    public string? PostProcess { get; set; }

    //Calculated fields:
    public string? Queue { get; set; }
    public string? Agent { get; set; }
    public string? Login { get; set; }

    // Multiline fields:
    public string? VariableKey { get; set; }
    public string? VariableValue { get; set; }

    public string? Docu { get; set; }

    //other fields

    public string Name { get; set; }
    public string Title { get; set; }

    public string JobName { get; set; }
    public bool NeverDeleteJob { get; set; }
    public string? ArchiveKey1 { get; set; }
    public string? ArchiveKey2 { get; set; }
    public string? InternalAccount { get; set; }
    //<folder>













}


//Name;Variable Key;Variable Value;Job Name;Never delete job;Title;Docu;Archive Key 1;Archive Key 2;Internal Account;Queue;Agent;Login;Folder;Template;Process;Pre-process;Post Process
