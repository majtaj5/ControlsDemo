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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLineTypeCount_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string choice = "";

            //Using Combobox
            choice = cboOptions.SelectedIndex.ToString();
            ControlsDemoUntil cutil = new ControlsDemoUntil();
            switch (choice)
            {
                case "Layer":
                    ArrayList layers = cutil.GetLeyers();
                    lstLayer.DataSource = layers;
                    lblLayerCount.Text = layers.Count.ToString();
                    break;
                case "LineType":
                    ArrayList linetypes = cutil.GetLineTypes();
                    lstLayer.DataSource = linetypes;
                    lblLineTypeCount.Text = linetypes.Count.ToString();
                    break;
                case "Textstyle":
                    ArrayList textstyle = cutil.GetTextStyles();
                    lstLayer.DataSource = textstyle;
                    lblTextStyleCount.Text = textstyle.Count.ToString();
                    break;


            }

        }
    }
}
