using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0SanderJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0SanderJob";
        public override float CraftingCooldown { get => Nach0SanderJob.StaticCraftingCooldown; set => Nach0SanderJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Sander",
                maskColor1 = new UnityEngine.Color32(186, 169, 11, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}