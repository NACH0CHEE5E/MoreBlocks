using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticStoneResearch : BaseResearchable
    {
        public Nach0ExoticStoneResearch()
        {
            key = "Nach0ExoticStoneResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ExoticStoneResearch.png";
            iterationCount = 15;
            AddIterationRequirement("stoneblock", 5);
            AddDependency("Nach0CurrencyResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Stone1Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Stone2Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Stone3Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Stone4Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Stone5Craft-pipliz.merchant"));
        }
    }
}