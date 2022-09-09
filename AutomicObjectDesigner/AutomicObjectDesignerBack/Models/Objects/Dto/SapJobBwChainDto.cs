namespace AutomicObjectDesigner.Models.Objects;

public class SapJobBwChainStep1Dto
{
    public string SapClient { get; set; }
    public string SapSid { get; set; }
    public string Kette { get; set; }
    public bool RoutineJob { get; set; }
    public string ProcessName { get; set; }
    public string SapJobName { get; set; }
    public bool DeleteSapJob { get; set; }
    public string ObjectName { get; set; }
}

public class SapJobBwChainStep2Dto
{

}
public class SapJobBwChainStep3Dto
{
    public string Documentation { get; set; }
}
public class SapJobBwChainStep4Dto
{

}