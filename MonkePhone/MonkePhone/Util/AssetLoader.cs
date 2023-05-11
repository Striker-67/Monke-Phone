using System.IO;
using System.Reflection;
using UnityEngine;

namespace MonkePhone.Util
{
    internal static class AssetLoader
    {
        internal static UnityEngine.Object GetAsset(string Name)
        {
            return assetBundle.LoadAsset(Name);
        }
        internal static Sprite GetSprite(string Name)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MonkePhone.Resources." + Name))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                Texture2D texture = new Texture2D(2, 2);
                texture.LoadImage(bytes);
                return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            }
        }

        private static AssetBundle _assetbundle;
        private static AssetBundle assetBundle
        {
            get
            {
                if (_assetbundle == null)
                {
                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MonkePhone.Resources.assets"))
                    {
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        _assetbundle = AssetBundle.LoadFromMemory(bytes);
                    }
                }
                return _assetbundle;
            }
        }
    }
}
