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


namespace ExtensionDLL_B
{
    [Export("ModuleBGUI", typeof(IGUIModule))]
    public partial class ModuleBGUI : Form, IGUIModule
    {
        public ModuleBGUI()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public string GetMenuCaption()
        {
            return "Modulo Ext. B";
        }

        public object GetMenuImage()
        {
            throw new NotImplementedException();
        }

        public string GetTooltip()
        {
            return "Module Ext. B ejecutado";
        }

       
    }
}
