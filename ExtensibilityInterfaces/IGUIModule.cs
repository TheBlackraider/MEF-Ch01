using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibilityInterfaces
{
   
    public delegate void onClose(object sender);

    public interface IGUIModule
    {
        void ShowForm();
        string GetMenuCaption();
        object GetMenuImage();
        string GetTooltip();

        event onClose OnCloseModule;   
    }
}
