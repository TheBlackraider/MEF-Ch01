﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibilityInterfaces
{
    public interface IModuleInfo
    {
        bool IsGUI();
        string GetName();

    }
}
