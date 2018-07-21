using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0FreezerJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0FreezerJob";
        public override float CraftingCooldown { get => Nach0FreezerJob.StaticCraftingCooldown; set => Nach0FreezerJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Freezer",
                maskColor1 = new UnityEngine.Color32(0, 77, 255, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}