using MonkePhone.Util;
using System.Collections.Generic;
using System.Text;

namespace MonkePhone.UI.Pages
{
    /// <summary>
    /// This page will be opened on startup
    /// </summary>
    internal class PrimaryPage : Page
    {
        public override void OnPageEnter()
        {
            SetText(new StringBuilder("Monke Phone"));
            List<App> Buttons = new List<App>();
            Buttons.Add(new App(AssetLoader.GetSprite("camera.png"), ButtonPressed));
            DrawPage(Buttons);
        }

        private void ButtonPressed(App app)
        {

        }
    }
}
