using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Daos;

public interface ISapSimpleDao : IDao<SapSimple>
{
    IEnumerable<SapSimple> GetAll();
}