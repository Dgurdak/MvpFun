using System;
using System.Windows.Forms;
using UI.Constants;
using UI.MainForm;
using UI.Pages.Login;
using UI.Pages.ScaleSetup;
using UI.Pages.Ship;

namespace WinForms.Controls
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddControlToControlCollection(Control myControl)
        {
            this.Controls.Add(myControl);
        }

        public Pages ActivePage { get; set; }
        public ILoginControl LoginControl { get; }
        public IShipControl ShipControl { get; }
        public IScaleSetupControl ScaleControl { get; }
        public event EventHandler LogOut;
        public void BindToViewModel(MainFormViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void GotToPage(Pages page)
        {
            throw new NotImplementedException();
        }

        public event EventHandler Login;
        public void GoToPage(Pages page)
        {
            throw new NotImplementedException();
        }
    }
}
