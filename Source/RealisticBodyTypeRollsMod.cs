using Verse;
using HarmonyLib;

namespace RealisticBodyTypeRolls
{
    public class RealisticBodyTypeRollsMod : Mod
    {
        public const string PACKAGE_ID = "realisticbodytyperolls.1trickPonyta";
        public const string PACKAGE_NAME = "Realistic Body Type Rolls";

        public RealisticBodyTypeRollsMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
