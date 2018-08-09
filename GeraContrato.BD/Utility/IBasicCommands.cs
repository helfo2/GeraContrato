using System.Collections.Generic;

namespace GeraContrato.DB.Utility
{
    public interface IBasicCommands<T>
    {
        void Insert(T obj);
        void Delete(T obj);
        void Update(T obj);
        List<T> SelectAll();
        T Select(int id);
        List<T> Select(string name);
    }
}
