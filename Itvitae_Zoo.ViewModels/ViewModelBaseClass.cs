using System.ComponentModel;

namespace Itvitae_Zoo.ViewModels
{
    public abstract class ViewModelBaseClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaiseProppertyChanged(string proppertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }
    }
}
