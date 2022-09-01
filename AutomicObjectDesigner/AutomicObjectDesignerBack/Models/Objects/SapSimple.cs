using AutomicObjectDesignerBack.Models.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutomicObjectDesigner.Models.Objects;

public class SapSimple : Job
{
    //Entry sequence:
    // step 1

    public string? SapClient { get; set; }
    public string? SapSid { get; set; }
    public string? SapReport { get; set; }

    public string? SapVariant { get; set; }
    public bool? RoutineJob { get; set; }
    public string? ProcessName { get; set; }
    public string? SapJobName { get; set; }
    public bool? DeleteSapJob { get; set; }

    public string GetRoutineJob()
    {
        if (RoutineJob == true)
            return "ZZZ";
        return "E1E";
    }

    public string GetDeleteSapJob()
    {
        if (DeleteSapJob == true)
            return "";
        return "X";
    }

    //// step 2

    //public string? ObjectName { get; set; }
    //public string? SapReport2 { get; set; }
    //public string? SapVariant1 { get; set; }

    ////step 3
    //public string? Docu1 { get; set; }

    ////step 4
    //public string? Title1 { get; set; }
    //public string? Archive1 { get; set; }
    //public string? Archive2 { get; set; }
    //public string? InternalAccount1 { get; set; }

    ////outcome
    ////Fixed predefined fields:

    //public string? Template { get; set; }
    //public string? Process1 { get; set; }
    //public string? PreProcess1 { get; set; }
    //public string? PostProcess1 { get; set; }

    ////Calculated fields:
    //public string? Queue1 { get; set; } 
    //public string? Agent1 { get; set; }
    //public string? Login1 { get; set; }

    //// Multiline fields:
    //public string? VariableKey { get; set; }
    //public string? VariableValue { get; set; }

    //public string? Docu { get; set; }

    ////other fields

    //public string Name1 { get; set; }
    //public string Title { get; set; }

    //public string JobName1 { get; set; }
    //public bool NeverDeleteJob { get; set; }
    //public string? ArchiveKey1 { get; set; }
    //public string? ArchiveKey2 { get; set; }
    //public string? InternalAccount { get; set; }
    ////<folder>













}


//Name;Variable Key;Variable Value;Job Name;Never delete job;Title;Docu;Archive Key 1;Archive Key 2;Internal Account;Queue;Agent;Login;Folder;Template;Process;Pre-process;Post Process
