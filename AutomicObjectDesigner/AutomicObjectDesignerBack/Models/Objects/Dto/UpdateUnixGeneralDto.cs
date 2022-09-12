using AutomicObjectDesignerBack.Models.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutomicObjectDesigner.Models.Objects;
//TODO
public class UpdateUnixGeneralDto
{
    public string UnixLogin { get; set; }
    public string SapSUnixServerid { get; set; }
    public string SapReport { get; set; }

    public string Agent { get; set; }
    public bool Active { get; set; }
    public string ProcessName { get; set; }
    public string SapJobName { get; set; }
    public bool DeleteSapJob { get; set; }
}