using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Models.Objects;

namespace AutomicObjectDesignerBack.Models.List;

public class ListObjects
{
    public List<WindowsGeneral>? WindowsGenerals { get; set; }
    public List<SapJobBwChain>? SapJobBwChains { get; set; }
    public List<UnixGeneral>? UnixGenerals { get; set; }
    public List<SapSimple>? SapSimples { get; set; }

}