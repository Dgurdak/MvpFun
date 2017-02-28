using System.ComponentModel;
using System.Runtime.CompilerServices;
using UI.Annotations;

namespace UI.MainForm
{
    public class MainFormViewModel : INotifyPropertyChanged
    {
        private bool _blnScaleEnabled;
        private string _strCurrentUser;

        public string CurrentUser
        {
            get { return _strCurrentUser; }
            set
            {
                _strCurrentUser = value;
                OnPropertyChanged();
            }
        }

        public bool ScaleEnabled
        {
            get { return _blnScaleEnabled; }
            set
            {
                _blnScaleEnabled = value;
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