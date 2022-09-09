using AutomicObjectDesignerBack.Models.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutomicObjectDesigner.Models.Objects;
public class SapSimpleStep1Dto
{
    public string SapClient { get; set; }
    public string SapSid { get; set; }
    public string SapReport { get; set; }

    public string SapVariant { get; set; }
    public bool RoutineJob { get; set; }
    public string ProcessName { get; set; }
    public string SapJobName { get; set; }
    public bool DeleteSapJob { get; set; }



}

public class SapSimpleStep2Dto : SapSimpleStep1Dto
{

    public string SapReport1 { get; set; }
    public string SapVariant1 { get; set; }
    public string ObjectName { get; set; }
}

public class SapSimpleStep3Dto
{

}

public class SapSimpleStep4Dto
{

}

public class SapSimpleStep5Dto
{

}