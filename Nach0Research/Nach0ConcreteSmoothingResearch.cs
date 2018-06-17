using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
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
            AddDependency("Nach0SanderResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
        }
    }
}