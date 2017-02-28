using System;
using System.Windows.Forms;
using UI.Pages.Ship;

namespace WinForms.Controls
{
    public partial class ShipControl : UserControl, IShipControl
    {
        public ShipControl()
        {
            InitializeComponent();
        }

        public event EventHandler SubmitIdInventoryButtonPressed
        {
            add { btnSubmitId.Click += value; }
            remove { btnSubmitId.Click -= value; }
        }

        public event EventHandler SubmitWeightButtonPressed
        {
            add { btnSubmitWeight.Click += value; }
            remove { btnSubmitWeight.Click -= value; }
        }

        public event EventHandler CancelButtonPressed
        {
            add { btnCancel.Click += value; }
            remove { btnCancel.Click -= value; }
        }

        public event EventHandler GoToCustomizeScalePageButtonPressed
        {
            add { btnCustomizeScale.Click += value; }
            remove { btnCustomizeScale.Click -= value; }
        }

        public void BindToViewModel(ShipViewModel model)
        {
            tbId.DataBindings.Add("Text", model, nameof(model.IdInventory), true, DataSourceUpdateMode.OnPropertyChanged);
            tbId.DataBindings.Add("Enabled", model, nameof(model.IdInventoryInputEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
            tbWeight.DataBindings.Add("Text", model, nameof(model.Weight), true, DataSourceUpdateMode.OnPropertyChanged);
            tbWeight.DataBindings.Add("Enabled", model, nameof(model.WeightInputEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
            lblResult.DataBindings.Add("Text", model, nameof(model.Result), true, DataSourceUpdateMode.OnPropertyChanged);
            btnSubmitId.DataBindings.Add("Enabled", model, nameof(model.SubmitIdInventoryButtonEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
            btnSubmitWeight.DataBindings.Add("Enabled", model, nameof(model.SubmitWeightButtonEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
            btnCancel.DataBindings.Add("Enabled", model, nameof(model.CancelButtonEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
            lblShippedCount.DataBindings.Add("Text", model, nameof(model.ShippedCount), true, DataSourceUpdateMode.OnPropertyChanged);
            lblScaleStatus.DataBindings.Add("Text", model, nameof(model.ScaleStatus), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        
    }
}