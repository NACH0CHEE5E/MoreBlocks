using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticSandResearch : BaseResearchable
    {
        public Nach0ExoticSandResearch()
        {
            key = "Nach0ExoticSandResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ExoticSandResearch.png";
            iterationCount = 15;
            AddIterationRequirement("sand", 5);
            AddDependency("Nach0CurrencyResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Sand1Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Sand2Craft-pipliz.merchant"));
        }
    }
}