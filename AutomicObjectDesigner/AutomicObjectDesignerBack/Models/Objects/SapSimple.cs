namespace AutomicObjectDesigner.Models.Objects;

public class SapSimple : Job
{
    // step 1

    public enum SapSid { get; set; }
    public enum SapClient { get; set; }
    public string? SapReport { get; set; }

    public string? SapVariant { get; set; }
    public bool RoutineJob { get; set; }
    public string? PorcessName { get; set; }
    public string? SapJobName { get; set; }
    public bool DeleteSapJob { get; set; }

    // step 2

    public string? ObjectName { get; set; }
    public string? SapReport2 { get; set; }
    public string? SapVariant { get; set; }

    //step 3

    //step 4
    public string? Title { get; set; }
    public string? Archive1 { get; set; }
    public string? Archive2 { get; set; }
    public string? InternalAccount { get; set; }








}


//Name;Variable Key;Variable Value;Job Name;Never delete job;Title;Docu;Archive Key 1;Archive Key 2;Internal Account;Queue;Agent;Login;Folder;Template;Process;Pre-process;Post Process
