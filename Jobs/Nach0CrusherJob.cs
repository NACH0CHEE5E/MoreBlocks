using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0CrusherJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0CrusherJob";
        public override float CraftingCooldown { get => Nach0CrusherJob.StaticCraftingCooldown; set => Nach0CrusherJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Crusher",
                maskColor1 = new UnityEngine.Color32(139, 126, 107, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}