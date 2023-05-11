using MonkePhone.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace MonkePhone.UI
{
    internal class MenuController
    {
        internal static MenuController Instance;

        public Transform ButtonGrouping;
        public Transform BaseButton;
        public TextMeshPro TextMesh;

        public Page[] Pages;
        public Type ActivePage;

        public MenuController(Transform Phone)
        {
            Instance = this;

            // Get button grouping
            ButtonGrouping = Phone.Find("ButtonGrouping");
            BaseButton = ButtonGrouping.GetChild(0);

            // find all pages in assembly
            List<Page> pages = new List<Page>();
            foreach (Type type in typeof(Page).Assembly.GetTypes())
                if (type.IsSubclassOf(typeof(Page)))
                    pages.Add((Page)Activator.CreateInstance(type));

            // Open page by default
            OpenPage<Pages.PrimaryPage>();
        }

        public void ClearPage()
        {
            "Wiping page...".Log();
            int ToDestroy = ButtonGrouping.childCount;
            for (int i = 1; i < ToDestroy; i++)
                GameObject.Destroy(ButtonGrouping.GetChild(i).gameObject);
        }

        public void OpenPage<T>() where T : Page
        {
            ClearPage();
            Pages.First(x => x.GetType() == typeof(T)).OnPageEnter();
        }
    }
}
