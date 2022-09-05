using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Daos;

public interface IDao<T>
{
    void Add(T item);
    void Remove(int id);

    T Get(int id);
}