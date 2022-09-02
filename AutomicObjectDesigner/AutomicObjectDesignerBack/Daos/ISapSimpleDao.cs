using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Daos;

public interface ISapSimpleDao : IDao<SapSimpleDetailDTO>
{
    IEnumerable<SapSimpleDetailDTO> GetAll();
}