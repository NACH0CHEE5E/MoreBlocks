using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0AdvancedPainterJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0AdvancedPainterJob";
        public override float CraftingCooldown { get => Nach0AdvancedPainterJob.StaticCraftingCooldown; set => Nach0AdvancedPainterJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Advanced Painter",
                maskColor1 = new UnityEngine.Color32(0, 0, 0, 0),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}