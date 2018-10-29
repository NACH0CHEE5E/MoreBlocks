using Recipes;
using Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0BrokenIce1Research : BaseResearchable
    {
        public Nach0BrokenIce1Research()
        {
            key = "Nach0BrokenIce1Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0IceBroken1.png";
            iterationCount = 15;
            AddIterationRequirement("Nach0IceBlock", 5);
            AddDependency("Nach0FreezingResearch");
            AddDependency("Nach0CrushingResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0IceBroken1Craft-Nach0CrusherJob"));
        }
    }
}