using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0MelterJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0MelterJob";
        public override float CraftingCooldown { get => Nach0MelterJob.StaticCraftingCooldown; set => Nach0MelterJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Melter",
                maskColor1 = new UnityEngine.Color32(255, 154, 0, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}