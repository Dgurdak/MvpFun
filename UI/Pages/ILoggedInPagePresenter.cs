using System;
using UI.Constants;

namespace UI.Pages
{
    public interface ILoggedInPagePresenter
    {
        event EventHandler<Constants.Pages> PageChangeRequested;
    }
}
