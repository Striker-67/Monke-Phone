using BepInEx;
using BepInEx.Logging;
using MonkePhone.UI;
using MonkePhone.Util;
using UnityEngine;

namespace MonkePhone
{
    [BepInPlugin(GUID, NAME, VERSION), BepInDependency("org.legoandmars.gorillatag.utilla"), BepInDependency("com.ahauntedarmy.gorillatag.tmploader")]
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
                Menu.SetParent(GorillaLocomotion.Player.Instance.leftHandTransform);
                Menu.localPosition = Vector3.zero; // We will worry about offset when the model is one - crafterbot
                Menu.localRotation = Quaternion.identity; // Same story here - crafterbot
                new MenuController(Menu);
            };
        }
    }
}
