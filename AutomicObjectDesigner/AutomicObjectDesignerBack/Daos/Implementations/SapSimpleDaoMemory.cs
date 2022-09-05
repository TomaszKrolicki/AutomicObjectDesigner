using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Daos.Implementations;

public class SapSimpleDaoMemory : ISapSimpleDao
{
    private static SapSimpleDaoMemory instance;
    public SapSimple SapSimple = new();
    private SapSimpleDaoMemory()
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

    public SapSimple Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SapSimple> GetAll()
    {
        throw new NotImplementedException();
    }


    public static SapSimpleDaoMemory GetInstance()
    {
        if (instance == null) instance = new SapSimpleDaoMemory();

        return instance;
    }
}