﻿namespace RealisticBodyTypeRolls
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{RealisticBodyTypeRollsMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
