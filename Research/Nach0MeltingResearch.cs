using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0MeltingResearch : BaseResearchable
    {
        public Nach0MeltingResearch()
        {
            key = "Nach0MeltingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Melter.png";
            iterationCount = 10;
            AddIterationRequirement("sciencebagbasic");
            AddDependency("pipliz.baseresearch.sciencebagbasic");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0MelterCraft-pipliz.metalsmithjob"));
        }
    }
}