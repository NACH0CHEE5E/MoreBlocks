using Recipes;
using Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0BrickLayingResearch : BaseResearchable
    {
        public Nach0BrickLayingResearch()
        {
            key = "Nach0BrickLayingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Brick1.png";
            iterationCount = 10;
            AddIterationRequirement("Nach0Brick", 5);
            AddDependency("Nach0BrickMakingResearch");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0BrickLayerCraft-pipliz.crafter"));
        }
    }
}