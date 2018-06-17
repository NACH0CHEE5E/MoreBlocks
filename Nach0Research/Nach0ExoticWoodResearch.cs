using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticWoodResearch : BaseResearchable
    {
        public Nach0ExoticWoodResearch()
        {
            key = "Nach0ExoticWoodResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ExoticWoodResearch.png";
            iterationCount = 15;
            AddIterationRequirement("planks", 5);
            AddIterationRequirement("logtaiga", 5);
            AddIterationRequirement("logtemperate", 5);
            AddDependency("Nach0CurrencyResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks1Craft-pipliz.woodcutter", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks2Craft-pipliz.woodcutter", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks3Craft-pipliz.woodcutter", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks4Craft-pipliz.woodcutter", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks5Craft-pipliz.woodcutter", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks6Craft-pipliz.woodcutter", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog1Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog2Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog3Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog4Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog5Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog6Craft-pipliz.merchant", true, "pipliz.merchant");
        }
    }
}