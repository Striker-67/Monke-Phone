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
