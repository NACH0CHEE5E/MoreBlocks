using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0ConcreteLayerJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0ConcreteLayerJob";
        public override float CraftingCooldown { get => Nach0ConcreteLayerJob.StaticCraftingCooldown; set => Nach0ConcreteLayerJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "Concrete Layer",
                maskColor1 = new UnityEngine.Color32(89, 52, 69, 1),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}