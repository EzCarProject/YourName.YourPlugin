using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourName.YourPlugin
{
    public partial class Form1 : Form
    {
        // Reference the Starter class to receive info (name, author, version).
        Starter plugininfo = new Starter();

        public Form1()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set the label to include the plugin name.
            label1.Text = "This is a form from the " + plugininfo.PluginName() + " plugin!";
        }
    }
}
