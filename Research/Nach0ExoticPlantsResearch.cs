using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticPlantsResearch : BaseResearchable
    {
        public Nach0ExoticPlantsResearch()
        {
            key = "Nach0ExoticPlantsResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Cactus.png";
            iterationCount = 15;
            AddIterationRequirement("cherrysapling", 5);
            AddDependency("Nach0ExoticSandResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0CactusCraft-pipliz.merchant"));
        }
    }
}