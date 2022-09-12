using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;

namespace AutomicObjectDesignerBack.Repository.Implementations;

public class SapSimpleRepository : RepositoryBase<SapSimple>, ISapSimpleRepository
{
    public SapSimpleRepository(AppDatabaseContext databaseContext) : base(databaseContext)
    {
    }
}