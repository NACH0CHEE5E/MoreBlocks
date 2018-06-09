using Pipliz.Mods.APIProvider.Jobs;
using PhentrixGames.NewColonyAPI;

namespace MoreBlocks.Nach0Jobs
{
    [JobAttribute]
    public class Nach0AdvancedPainterJob : PhentrixGames.NewColonyAPI.Classes.Job, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0AdvancedPainterJob";
        public override float CraftingCooldown { get => Nach0AdvancedPainterJob.StaticCraftingCooldown; set => Nach0AdvancedPainterJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public override void Init()
        {
            Block = "Nach0AdvancedPaintersTable";
            JobKey = NPCTypeKey;
            PrintName = NPCTypeKey;
        }
    }
}