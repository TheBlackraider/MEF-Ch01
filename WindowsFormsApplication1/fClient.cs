using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition.Hosting;

namespace MEFClient
{
    public partial class fClient : Form
    {
        private CompositionContainer _container;
        private DirectoryCatalog _extensions;
        private ExtensibilityInterfaces.IGUIModule selectedModule;

        public fClient()
        {
            InitializeComponent();

        }


        private void OnCloseHandler(object sender)
        {
            Form s = (Form)sender;

            MessageBox.Show("Form " + s.Text + " cerrado");
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            // Take some action based on the data in clickedItem
            selectedModule = (ExtensibilityInterfaces.IGUIModule) Activator.CreateInstance(clickedItem.Tag.GetType());

            statusText.Text = selectedModule.GetTooltip();

            selectedModule.ShowForm();
        }

        private void cargarExtensionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string extfolder;

            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                extfolder = folderBrowser.SelectedPath;
                _extensions = new DirectoryCatalog(extfolder);
                _container = new CompositionContainer(_extensions);
                
                statusText.Text = "Extensiones cargadas desde " + extfolder;
            }

            if (_container != null)
            {
                
                var exports = _container.GetExports<ExtensibilityInterfaces.IModuleInfo>();

                foreach (var ex in exports)
                {
                    ExtensibilityInterfaces.IModuleInfo module = ex.Value;

                    if (module.IsGUI())
                    {

                        var gui = _container.GetExport<ExtensibilityInterfaces.IGUIModule>(module.GetName()).Value;

                        ToolStripMenuItem mnu = new ToolStripMenuItem(gui.GetMenuCaption());
                        mnu.Tag = gui;
                        mnu.Click += new EventHandler(MenuItemClickHandler);

                        mnuExtensiones.DropDownItems.Add(mnu);

                        statusText.Text = "Añadido " + mnu.Text;


                    }
                }

            }
        }
    }
}
