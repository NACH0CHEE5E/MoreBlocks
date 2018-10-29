using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ConcreteSmoothingResearch : BaseResearchable
    {
        public Nach0ConcreteSmoothingResearch()
        {
            key = "Nach0ConcreteSmoothingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ConcreteSmoothing1Research.png";
            iterationCount = 15;
            AddIterationRequirement("Nach0Concrete", 5);
            AddDependency("Nach0ConcreteMakingResearch");
            AddDependency("Nach0SandingResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedConcreteCraft-Nach0SanderJob"));
        }
    }
}