using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace MonkePhone.UI
{
    internal class MenuController
    {
        internal static MenuController Instance;
        public MenuController(Transform Phone) 
        {
            Instance = this;
        }
    }
}
