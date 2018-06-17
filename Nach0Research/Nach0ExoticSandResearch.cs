using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
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
            /*//dirt
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt2Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt3Craft", true, "pipliz.merchant");

            //stone
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone2Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone3Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone4Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0RockCraft", true, "pipliz.merchant");

            //sand*/
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand1Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand2Craft-pipliz.merchant", true, "pipliz.merchant");

            /*//grass
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Grass1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Grass1SidedCraft", true, "pipliz.merchant");
            */
        }
    }
}