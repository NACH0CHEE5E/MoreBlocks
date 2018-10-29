using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0CrushingResearch : BaseResearchable
    {
        public Nach0CrushingResearch()
        {
            key = "Nach0CrushingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Crusher.png";
            iterationCount = 15;
            AddIterationRequirement("stoneblock", 5);
            AddDependency("pipliz.baseresearch.bloomery");
            AddDependency("pipliz.baseresearch.stonemasonworkbench");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0CrusherCraft-pipliz.metalsmithjob"));
        }
    }
}