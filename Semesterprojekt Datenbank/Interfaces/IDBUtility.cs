using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using Semesterprojekt_Datenbank.Utilities;

namespace Semesterprojekt_Datenbank.Interfaces
{
    public interface IDBUtility<T>
    {
        // CRUD Funktionen der Datenbank

        void Create(T item);

        List<T> Read();
        T ReadSingle(T customerVm);

        void Update(T item);

        bool Delete(T item);

    }
}
