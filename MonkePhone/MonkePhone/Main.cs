using BepInEx;
using BepInEx.Logging;
using MonkePhone.UI;
using MonkePhone.Util;
using UnityEngine;

namespace MonkePhone
{
    [BepInPlugin(GUID, NAME, VERSION), BepInDependency("org.legoandmars.gorillatag.utilla")]
    internal class Main : BaseUnityPlugin
    {
        internal const string
            GUID = "striker.monkephone",
            NAME = "Monke Phone",
            VERSION = "1.0.0";
        internal static ManualLogSource manualLogSource; // This allows the logger object to be accessed outside of this type - crafterbot
        private void Awake()
        {
            manualLogSource = Logger; // to log messages in bold use ``loglevel message`` - crafterbot
            $"Init : {NAME}".Log();

            // Lets try to avoid hooking - crafterbot

            Utilla.Events.GameInitialized += (object sender, System.EventArgs e) =>
            {
                $"Game Initialized".Log();
                Transform Menu = GameObject.Instantiate(AssetLoader.GetAsset("Phone") as GameObject).transform;
                new MenuController(Menu);
            };
        }
    }
}
