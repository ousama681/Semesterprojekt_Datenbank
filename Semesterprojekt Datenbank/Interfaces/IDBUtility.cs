using System.Collections.Generic;
namespace Semesterprojekt_Datenbank.Interfaces
{
    public interface IDBUtility<T>
    {
        // CRUD Funktionen der Datenbank

        void Create(T customerVm);

        void Read(T item);

        void Update();

        void Delete();

    }
}
