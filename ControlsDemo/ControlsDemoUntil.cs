using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System.Collections;

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

        public ArrayList GetLeyers()
        {
            ArrayList layers = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LayerTable lyTab = trans.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach(var ly in lyTab)
                {
                    LayerTableRecord layer = trans.GetObject(ly, OpenMode.ForRead)as LayerTableRecord;
                    layers.Add(layer.Name);
                }
            }
            return layers;
        }
    }
}
