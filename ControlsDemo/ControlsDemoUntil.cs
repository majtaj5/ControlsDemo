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
                    LayerTableRecord ltr = trans.GetObject(ly, OpenMode.ForRead)as LayerTableRecord;
                    layers.Add(ltr.Name);
                }
            }
            return layers;
        }

        public ArrayList GetLineTypes()
        {
            ArrayList linetype = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LinetypeTable ltTab = trans.GetObject(db.LinetypeTableId, OpenMode.ForRead) as LinetypeTable;
                foreach (var lt in ltTab)
                {
                    LinetypeTableRecord lttr = trans.GetObject(lt, OpenMode.ForRead) as LinetypeTableRecord;
                    linetype.Add(lttr.Name);
                }
            }
            return linetype;
        }
        public ArrayList GetTextStyles()
        {
            ArrayList textstyles = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                TextStyleTable tsTab = trans.GetObject(db.LinetypeTableId, OpenMode.ForRead) as TextStyleTable;
                foreach (var ts in tsTab)
                {
                    TextStyleTableRecord sttr = trans.GetObject(ts, OpenMode.ForRead) as TextStyleTableRecord;
                    textstyles.Add(sttr.Name);
                }
            }
            return textstyles;
        }
    }
}
