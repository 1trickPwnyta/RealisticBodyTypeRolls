using HarmonyLib;
using RimWorld;
using Verse;

namespace RealisticBodyTypeRolls
{
    [HarmonyPatch(typeof(PawnGenerator))]
    [HarmonyPatch("GenerateBodyType")]
    public static class Patch_PawnGenerator
    {
        public static void Postfix(ref Pawn pawn, ref PawnGenerationRequest request)
        {
			if (request.ForceBodyType != null)
			{
				pawn.story.bodyType = request.ForceBodyType;
			}
			else
			{
				float r = Rand.Value;

				if (r < 0.089f)
                {
					pawn.story.bodyType = BodyTypeDefOf.Thin;
                }
				else if (r < 0.089f + 0.015f)
                {
					pawn.story.bodyType = BodyTypeDefOf.Fat;
                }
				else if (r < 0.089f + 0.015f + 0.004f)
                {
					pawn.story.bodyType = BodyTypeDefOf.Hulk;
                }
                else
                {
                    pawn.story.bodyType = ((pawn.gender == Gender.Female) ? BodyTypeDefOf.Female : BodyTypeDefOf.Male);
                }
			}
        }
    }
}
