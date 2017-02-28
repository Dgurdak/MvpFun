using System;
using System.Windows.Forms;
using UI.Pages.ScaleSetup;

namespace WinForms.Controls
{
    public partial class ScaleSetupControl : UserControl, IScaleSetupControl
    {
        public ScaleSetupControl()
        {
            InitializeComponent();
        }

        public event EventHandler SaveChangesButtonPressed
        {
            add { btnSaveChanges.Click += value; }
            remove { btnSaveChanges.Click -= value; }
        }

        public void BindToViewModel(ScaleSetupViewModel model)
        {
            cbUseScale.DataBindings.Add("Checked", model, nameof(model.UseScale));
        }
    }
}