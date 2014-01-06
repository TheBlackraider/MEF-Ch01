using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensibilityInterfaces;
using System.ComponentModel.Composition;

namespace ExtensionDLL_A
{
    [Export(typeof(IModuleInfo))]
    public class ModuleA : IModuleInfo
    {
        public bool IsGUI()
        {
            return true;
        }

        public string GetName()
        {
            return "ModuleAGUI";
        }
    }
}
