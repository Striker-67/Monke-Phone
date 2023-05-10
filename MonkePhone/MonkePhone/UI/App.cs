using UnityEngine;

namespace MonkePhone.UI
{
    internal class App
    {
        public Sprite Icon;
        public delegate void OnClick();
        public OnClick onClick;

        public App(Sprite icon, OnClick onClick)
        {
            Icon = icon;
            this.onClick = onClick;
        }
    }
}
