using System.ComponentModel;
using System.Runtime.CompilerServices;
using UI.Annotations;

namespace UI.Pages.ScaleSetup
{
    public class ScaleSetupViewModel : INotifyPropertyChanged
    {
        private bool _blnUseScale;

        public bool UseScale
        {
            get { return _blnUseScale; }
            set
            {
                _blnUseScale = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}