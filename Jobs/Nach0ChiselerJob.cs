using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0ChiselerJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0ChiselerJob";
        public override float CraftingCooldown { get => Nach0ChiselerJob.StaticCraftingCooldown; set => Nach0ChiselerJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Chiseler",
                maskColor1 = new UnityEngine.Color32(189, 181, 172, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}