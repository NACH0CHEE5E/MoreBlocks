using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticWoodResearch : BaseResearchable
    {
        public Nach0ExoticWoodResearch()
        {
            key = "Nach0ExoticWoodResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ExoticWoodResearch.png";
            iterationCount = 15;
            AddIterationRequirement("planks", 5);
            AddIterationRequirement("logtaiga", 5);
            AddIterationRequirement("logtemperate", 5);
            AddDependency("Nach0CurrencyResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Planks1Craft-pipliz.woodcutter"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Planks2Craft-pipliz.woodcutter"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Planks3Craft-pipliz.woodcutter"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Planks4Craft-pipliz.woodcutter"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Planks5Craft-pipliz.woodcutter"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0Planks6Craft-pipliz.woodcutter"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0TreeLog1Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0TreeLog2Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0TreeLog3Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0TreeLog4Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0TreeLog5Craft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0TreeLog6Craft-pipliz.merchant"));

        }
    }
}