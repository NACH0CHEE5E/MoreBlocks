using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticGrassResearch : BaseResearchable
    {
        public Nach0ExoticGrassResearch()
        {
            key = "Nach0ExoticGrassResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Grass1Sided.png";
            iterationCount = 15;
            AddIterationRequirement("grass", 1);
            AddDependency("Nach0ExoticDirtResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Grass1Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Grass1SidedCraft-pipliz.merchant"));
        }
    }
}