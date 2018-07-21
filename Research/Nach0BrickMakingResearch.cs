using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0BrickMakingResearch : BaseResearchable
    {
        public Nach0BrickMakingResearch()
        {
            key = "Nach0BrickMakingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Brick.png";
            iterationCount = 10;
            AddIterationRequirement("bricks", 5);
            AddDependency("pipliz.baseresearch.bloomery");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrickCraft-pipliz.smelter", true, "pipliz.smelter");
        }
    }
}