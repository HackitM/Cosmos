﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.Core {
    static public class Global {
        static public BaseIOGroups BaseIOGroups = new BaseIOGroups();

        static public void Init() {
            // Temp
            Kernel.Global.Init();
            // End Temp
            IRQs.Dummy();
            Kernel.CPU.CreateIDT(false);
        }
    }
}
