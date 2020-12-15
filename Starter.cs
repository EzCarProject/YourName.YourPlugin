using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ECMU.Interface;

namespace YourName.YourPlugin
{
    public class Starter : PluginImplementerButton 
    {
        public string PluginName()
        {
            // This is for the plugin name.
            return "Your Plugin";
        }

        public string PluginVersion()
        {
            // This is for the plugin version.
            return "1.0.0.0";
        }

        public string PluginAuthor()
        {
            // This is the plugin author, normally your name or alias.
            return "Your Name";
        }

        public string PluginDescription()
        {
            // This is for your plugin description.
            return "Your description";
        }

        public Icon PluginIcon()
        {
            // Don't mess with this.
            return Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }

        public void ButtonAdder(System.Windows.Forms.Button btn)
        {
            // You need this no matter what. It uses the function below.
            btn.Click += button_Click;
        }

        public void button_Click(object sender, EventArgs e)
        {
            // This is for the button in the plugins section on settings.
            System.Windows.Forms.MessageBox.Show("I am example plugin");
            // Add a main form variable to show the form.
            Form1 main = new Form1();
            // Show the form using the variable.
            main.Show();
        }
    }
}
