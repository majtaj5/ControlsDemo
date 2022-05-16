using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace ControlsDemo
{
    public class ControlsDemoUntil
    {
        [CommandMethod("Demo")]
        public void Demo()
        {
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
