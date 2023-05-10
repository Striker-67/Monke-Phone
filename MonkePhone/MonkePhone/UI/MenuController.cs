using System;
using System.Collections.Generic;
using UnityEngine;

namespace MonkePhone.UI
{
    internal class MenuController
    {
        internal static MenuController Instance;

        public Transform ButtonGrouping;
        public Transform BaseButton;

        public Page[] Pages;
        public Type ActivePage;

        public MenuController(Transform Phone)
        {
            Instance = this;

            // find all pages in assembly
            List<Page> pages = new List<Page>();
            foreach (Type type in typeof(Page).Assembly.GetTypes())
                if (type.IsSubclassOf(typeof(Page)))
                    pages.Add((Page)Activator.CreateInstance(type));
        }

        public void ClearPage()
        {

        }

        public void DrawPage<T>() where T : Page
        {

        }
    }
}
