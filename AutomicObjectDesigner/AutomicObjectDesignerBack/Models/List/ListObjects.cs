using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Models.Objects;

namespace AutomicObjectDesignerBack.Models.List;

public class ListObjects
{
    private List<WindowsGeneral>? WindowsGenerals { get; set; }
    private List<SapJobBwChain>? SapJobBwChains { get; set; }
    private List<UnixGeneral>? UnixGenerals { get; set; }
    private List<SapSimple>? SapSimples { get; set; }

    public ListObjects(List<WindowsGeneral> windowsGenerals, List<SapJobBwChain> sapJobBwChains, List<UnixGeneral> unixGenerals, List<SapSimple> sapSimples)
    {
        WindowsGenerals = windowsGenerals;
        SapJobBwChains = sapJobBwChains;
        UnixGenerals = unixGenerals;
        SapSimples = sapSimples;
    }

}