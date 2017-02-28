using System;
using System.Windows.Forms;
using UI.Pages.Login;

namespace WinForms.Controls
{
    public partial class LoginControl : UserControl, ILoginControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        public event EventHandler SubmitButtonPressed
        {
            add { btnSubmit.Click += value; }
            remove { btnSubmit.Click -= value; }
        }

        public void BindToViewModel(LoginViewModel model)
        {            
            txtName.DataBindings.Add("Text", model, nameof(model.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add("Text", model, nameof(model.Password), true, DataSourceUpdateMode.OnPropertyChanged);            
        }

        public bool LoginErrorVisible
        {
            get
            {
                return lblBadLogin.Visible;
            }
            set
            {
                lblBadLogin.Visible = value;                
            }
        }
    }
}