using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Semesterprojekt_Datenbank.Utilities
{
    public class ViewModelBase : INotifyPropertyChanged /// Interface implementieren
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
