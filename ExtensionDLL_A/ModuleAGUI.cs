using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using ExtensibilityInterfaces;


namespace ExtensionDLL_A
{
    [Export("ModuleAGUI", typeof(IGUIModule))]
    public partial class ModuleAGUI : Form, IGUIModule
    {
        public ModuleAGUI()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public string GetMenuCaption()
        {
            return "Modulo Ext. A";
        }

        public object GetMenuImage()
        {
            throw new NotImplementedException();
        }

        public string GetTooltip()
        {
            return "Module Ext. A ejecutado";
        }

    }
}
