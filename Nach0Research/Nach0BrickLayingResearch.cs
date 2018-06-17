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
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Brick1.png";
            iterationCount = 10;
            AddIterationRequirement("Nach0Brick", 5);
            AddDependency("Nach0BrickMakingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrickLayerCraft-pipliz.crafter", true, "pipliz.crafter");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Brick1Craft-pipliz.crafter", true, "pipliz.crafter");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Brick2Craft-pipliz.crafter", true, "pipliz.crafter");
        }
    }
}