using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0PaperMakingResearch : BaseResearchable
    {
        public Nach0PaperMakingResearch()
        {
            key = "Nach0PaperMakingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Paper.png";
            iterationCount = 15;
            AddIterationRequirement("flax", 5);
            AddDependency("pipliz.baseresearch.herbfarming");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PaperCraft-pipliz.crafter"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SandPaperCraft-pipliz.crafter"));
        }
    }
}