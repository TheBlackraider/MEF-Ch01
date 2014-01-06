using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensibilityInterfaces;
using System.ComponentModel.Composition;

namespace ExtensionDLL_B
{
    [Export(typeof(IModuleInfo))]
    public class ModuleB : IModuleInfo
    {

        public bool IsGUI()
        {
            return true;
        }

        public string GetName()
        {
            return "ModuleBGUI";
        }
    }
}
