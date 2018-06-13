using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0BrickLayingResearch : BaseResearchable
    {
        public Nach0BrickLayingResearch()
        {
            key = "Nach0BrickLayingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 10;
            AddIterationRequirement("bricks", 5);
            AddDependency("Nach0BrickMakingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrickLayerCraft", true, "pipliz.crafter");
        }
    }
}