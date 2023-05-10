using System;
using System.Collections.Generic;
using System.Text;

namespace MonkePhone.UI
{
    internal class MenuController
    {
        internal static MenuController Instance;
        public MenuController() 
        {
            Instance = this;
        }
    }
}
