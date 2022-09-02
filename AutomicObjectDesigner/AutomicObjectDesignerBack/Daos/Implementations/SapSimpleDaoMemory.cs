using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Daos.Implementations;

public class SapSimpleDaoMemory : ISapSimpleDao
{
    private static SapSimpleDaoMemory instance;
    public SapSimpleDetailDTO SapSimple = new();
    private SapSimpleDaoMemory()
    {
    }

    public void Add(SapSimpleDetailDTO item)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public SapSimpleDetailDTO Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SapSimpleDetailDTO> GetAll()
    {
        throw new NotImplementedException();
    }


    public static SapSimpleDaoMemory GetInstance()
    {
        if (instance == null) instance = new SapSimpleDaoMemory();

        return instance;
    }
}