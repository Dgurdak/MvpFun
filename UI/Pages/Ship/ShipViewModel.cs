using System.ComponentModel;
using System.Runtime.CompilerServices;
using UI.Annotations;

namespace UI.Pages.Ship
{
    public class ShipViewModel : INotifyPropertyChanged
    {
        private string _strScaleStatus;

        public string ScaleStatus
        {
            get { return _strScaleStatus; }
            set
            {
                _strScaleStatus = value;
                OnPropertyChanged();
            }
        }

        private bool _blnIdInventoryInputEnabled;

        public bool IdInventoryInputEnabled
        {
            get { return _blnIdInventoryInputEnabled; }
            set
            {
                _blnIdInventoryInputEnabled = value;
                OnPropertyChanged();
            }
        }

        private string _strIdInventory;

        public string IdInventory
        {
            get { return _strIdInventory; }
            set
            {
                _strIdInventory = value;
                OnPropertyChanged();
            }
        }

        private bool _blnWeightInputEnabled;

        public bool WeightInputEnabled
        {
            get { return _blnWeightInputEnabled; }
            set
            {
                _blnWeightInputEnabled = value;
                OnPropertyChanged();
            }
        }

        private string _strWeight;

        public string Weight
        {
            get { return _strWeight; }
            set
            {
                _strWeight = value;
                OnPropertyChanged();
            }
        }

        private string _strResult;

        public string Result
        {
            get { return _strResult; }
            set
            {
                _strResult = value;
                OnPropertyChanged();
            }
        }

        private bool _blnSubmitIdInventoryButtonEnabled;

        public bool SubmitIdInventoryButtonEnabled
        {
            get { return _blnSubmitIdInventoryButtonEnabled;}
            set
            {
                _blnSubmitIdInventoryButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private bool _blnSubmitWeightButtonEnabled;

        public bool SubmitWeightButtonEnabled
        {
            get { return _blnSubmitWeightButtonEnabled; }
            set
            {
                _blnSubmitWeightButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private bool _blnCancelButtonEnabled;

        public bool CancelButtonEnabled
        {
            get { return _blnCancelButtonEnabled; }
            set
            {
                _blnCancelButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private string _strShippedCount;

        public string ShippedCount
        {
            get { return _strShippedCount; }
            set
            {
                _strShippedCount = value;
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
