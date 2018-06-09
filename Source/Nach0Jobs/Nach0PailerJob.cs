using Pipliz.Mods.APIProvider.Jobs;
using PhentrixGames.NewColonyAPI;

namespace MoreBlocks.Nach0Jobs
{
    [JobAttribute]
    public class Nach0PailerJob : PhentrixGames.NewColonyAPI.Classes.Job, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0PailerJob";
        public override float CraftingCooldown { get => Nach0PailerJob.StaticCraftingCooldown; set => Nach0PailerJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 15;

        public override void Init() 
        {
            Block = "Nach0Pailer";
            JobKey = NPCTypeKey;
            PrintName = NPCTypeKey;
        }
    }
}