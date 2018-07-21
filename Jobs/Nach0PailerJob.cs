using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0PailerJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0PailerJob";
        public override float CraftingCooldown { get => Nach0PailerJob.StaticCraftingCooldown; set => Nach0PailerJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Pailer",
                maskColor1 = new UnityEngine.Color32(0, 255, 239, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}