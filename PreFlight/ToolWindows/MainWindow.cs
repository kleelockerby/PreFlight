using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace PreFlight
{
    [Guid("7faced34-46ca-465e-921d-0d984c10cdae")]
    public class MainWindow : ToolWindowPane
    {
        public MainWindow() : base(null)
        {
            this.Caption = "MainWindow";
            this.Content = new MainWindowControl();
        }
    }
}
