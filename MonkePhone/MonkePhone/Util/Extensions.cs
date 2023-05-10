using BepInEx.Logging;

namespace MonkePhone.Util
{
    internal static class Extensions
    {
        internal static void Log(this object obj, LogLevel logLevel = LogLevel.Info)
        {
#if DEBUG
            Main.manualLogSource.Log(logLevel, obj);
#endif
        }
    }
}
