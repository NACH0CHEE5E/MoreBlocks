using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0BrickMakingResearch : BaseResearchable
    {
        public Nach0BrickMakingResearch()
        {
            key = "Nach0BrickMakingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 10;
            AddIterationRequirement("bricks", 5);
            AddDependency("pipliz.baseresearch.bloomery");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrickMakerCraft", true, "pipliz.crafter");
        }
    }
}