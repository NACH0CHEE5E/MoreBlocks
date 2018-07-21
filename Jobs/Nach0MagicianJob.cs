using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0MagicianJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0MagicianJob";
        public override float CraftingCooldown { get => Nach0MagicianJob.StaticCraftingCooldown; set => Nach0MagicianJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Magician",
                maskColor1 = new UnityEngine.Color32(214, 0, 96, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}