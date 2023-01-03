using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace Semesterprojekt_Datenbank.Interfaces
{
    public interface IDBUtility<T>
    {
        // CRUD Funktionen der Datenbank

        void Create(T customerVm);

        List<T> Read();
        T ReadSingle(T customerVm);

        void Update(T item);

        void Delete(T item);

    }
}
