using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0FreezingResearch : BaseResearchable
    {
        public Nach0FreezingResearch()
        {
            key = "Nach0FreezingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Freezer.png";
            iterationCount = 10;
            AddIterationRequirement("sciencebagbasic");
            AddDependency("pipliz.baseresearch.sciencebagbasic");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0FreezerCraft-pipliz.metalsmithjob"));
        }
    }
}