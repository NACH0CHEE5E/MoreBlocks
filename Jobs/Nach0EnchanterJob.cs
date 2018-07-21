using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0EnchanterJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0EnchanterJob";
        public override float CraftingCooldown { get => Nach0EnchanterJob.StaticCraftingCooldown; set => Nach0EnchanterJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Enchanter",
                maskColor1 = new UnityEngine.Color32(59, 0, 96, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}