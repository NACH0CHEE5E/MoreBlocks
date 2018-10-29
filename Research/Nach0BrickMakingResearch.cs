using Recipes;
using Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0BrickMakingResearch : BaseResearchable
    {
        public Nach0BrickMakingResearch ()
        {
            key = "Nach0BrickMakingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Brick.png";
            iterationCount = 10;
            AddIterationRequirement("bricks", 5);
            AddDependency("pipliz.baseresearch.bloomery");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            var recipeData = manager.Colony.RecipeData;
            recipeData.UnlockRecipe(new RecipeKey("Nach0BrickCraft-pipliz.smelter"));
        }
    }
}