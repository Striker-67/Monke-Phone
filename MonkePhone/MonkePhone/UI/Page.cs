using MonkePhone.Util;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace MonkePhone.UI
{
    internal abstract class Page
    {
        /// <summary>
        /// Executes when the page is opened
        /// </summary>
        public virtual void OnPageEnter()
        {
        }

        public void SetText(StringBuilder stringBuilder)
        {
            MenuController.Instance.TextMesh.text = stringBuilder.ToString();
            "Set text".Log();
        }
        public void DrawPage(List<App> items, bool ClearCurrent = true)
        {
            if (ClearCurrent)
                MenuController.Instance.ClearPage();
            Transform BaseButton = MenuController.Instance.BaseButton.transform;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Icon == null)
                {
                    "Making placeholder".Log();
                    new GameObject().transform.SetParent(MenuController.Instance.ButtonGrouping);
                }
                else
                {
                    Transform Button = GameObject.Instantiate(BaseButton, MenuController.Instance.ButtonGrouping);
                    BoxCollider collider = Button.GetComponentInChildren<BoxCollider>();
                    collider.gameObject.layer = 18;
                    collider.gameObject.AddComponent<UIButton>().app = items[i];
                }
            }
        }
    }
}
