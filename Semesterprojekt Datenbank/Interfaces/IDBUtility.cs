using System.Collections.Generic;
namespace Semesterprojekt_Datenbank.Interfaces
{
    public interface IDBUtility<T>
    {
        // CRUD Funktionen der Datenbank

        void Create(T item); // Create and Insert new Item

        void Read();        // Read == Find == Select Item

        void Update();      // update == bearbeiten Item

        void Delete();      // delete == item => Achtung kaskadierung!

      

    }
}
