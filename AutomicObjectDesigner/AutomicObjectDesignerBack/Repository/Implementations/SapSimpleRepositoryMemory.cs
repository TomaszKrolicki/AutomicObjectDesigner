using System.Linq.Expressions;
using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Repository.Implementations;

public class SapSimpleRepositoryMemory : ISapSimpleRepository
{
    private static SapSimpleRepositoryMemory instance;
    public SapSimple SapSimple = new();
    private SapSimpleRepositoryMemory()
    {
    }

    public void Add(SapSimple item)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    IQueryable<SapSimple> IRepositoryBase<SapSimple>.GetAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<SapSimple> FindbyCondition(Expression<Func<SapSimple, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public void Create(SapSimple entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(SapSimple entity)
    {
        throw new NotImplementedException();
    }

    public void Update(SapSimple entity)
    {
        throw new NotImplementedException();
    }

    public SapSimple Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SapSimple> GetAll()
    {
        throw new NotImplementedException();
    }


    public static SapSimpleRepositoryMemory GetInstance()
    {
        if (instance == null) instance = new SapSimpleRepositoryMemory();

        return instance;
    }
}