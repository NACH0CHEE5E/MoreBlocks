using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ConcreteMakingResearch : BaseResearchable
    {
        public Nach0ConcreteMakingResearch()
        {
            key = "Nach0ConcreteMakingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 10;
            AddIterationRequirement("stoneblock", 5);
            AddDependency("Nach0CrushingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0ConcreteLayerCraft", true, "pipliz.crafter");
        }
    }
}