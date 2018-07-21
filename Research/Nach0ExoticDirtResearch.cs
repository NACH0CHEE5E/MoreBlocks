using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticDirtResearch : BaseResearchable
    {
        public Nach0ExoticDirtResearch()
        {
            key = "Nach0ExoticDirtResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Dirt1.png";
            iterationCount = 15;
            AddIterationRequirement("dirt", 5);
            AddDependency("Nach0CurrencyResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt1Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt2Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt3Craft-pipliz.merchant", true, "pipliz.merchant");
        }
    }
}