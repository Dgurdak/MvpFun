﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using UI.Annotations;

namespace UI.Pages.Login
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private bool _blnBadLoginVisible;
        private string _strName;

        private string _strPassword;

        public string Name
        {
            get { return _strName; }
            set
            {
                _strName = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _strPassword; }
            set
            {
                _strPassword = value;
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