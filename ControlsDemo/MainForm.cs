using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string choice = "";

            //Using Combobox
            choice = cboOptions.SelectedIndex.ToString();
            ControlsDemoUntil cutil = new ControlsDemoUntil();
            switch (choice)
            {
                case "1":
                    ArrayList layers = cutil.GetLeyers();
                    lstLayer.DataSource = layers;
                    lblLayerCount.Text = layers.Count.ToString();
                    break;
                case "2":
                    ArrayList linetypes = cutil.GetLineTypes();
                    lstLIneType.DataSource = linetypes;
                    lblLineTypeCount.Text = linetypes.Count.ToString();
                    break;
                case "3":
                    ArrayList textstyle = cutil.GetTextStyles();
                    lstTextStyle.DataSource = textstyle;
                    lblTextStyleCount.Text = textstyle.Count.ToString();
                    break;


            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstLayer.DataSource = null;
            lstLIneType.DataSource = null;
            lstTextStyle.DataSource = null;
            lblLineTypeCount.Text = null;
            lblLayerCount.Text = null;
            lblTextStyleCount.Text = null;

        }
    }
}
