using System.Drawing;
using System.Windows.Forms;

namespace CrystalDecisions
{
    internal class Windows
    {
        internal class Forms
        {
            internal class CrystalReportViewer
            {
                public CrystalReportViewer()
                {
                }

                public int ActiveViewIndex { get; internal set; }
                public BorderStyle BorderStyle { get; internal set; }
                public Cursor Cursor { get; internal set; }
                public DockStyle Dock { get; internal set; }
                public Point Location { get; internal set; }
                public string Name { get; internal set; }
                public Size Size { get; internal set; }
                public int TabIndex { get; internal set; }
            }
        }
    }
}