using System;

namespace UI.Pages.Ship
{
    public interface IShipControl
    {
        event EventHandler SubmitIdInventoryButtonPressed;
        event EventHandler SubmitWeightButtonPressed;
        event EventHandler CancelButtonPressed;
        event EventHandler GoToCustomizeScalePageButtonPressed;
        void BindToViewModel(ShipViewModel model);
    }    
}