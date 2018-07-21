using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticSandResearch : BaseResearchable
    {
        public Nach0ExoticSandResearch()
        {
            key = "Nach0ExoticSandResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ExoticSandResearch.png";
            iterationCount = 15;
            AddIterationRequirement("sand", 5);
            AddDependency("Nach0CurrencyResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand1Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand2Craft-pipliz.merchant", true, "pipliz.merchant");
        }
    }
}