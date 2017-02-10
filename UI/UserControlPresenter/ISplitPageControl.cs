using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.UserControlPresenter
{
    public interface ISplitPageControl
    {
        event EventHandler<PackagesToSplitEventArgs> SubmitPressed;
        event EventHandler ResetPressed;
    }

    public class PackagesToSplitEventArgs : EventArgs
    {
        public string Contents { get; }

        public PackagesToSplitEventArgs(string strContents)
        {
            Contents = strContents;
        }
    }
}
