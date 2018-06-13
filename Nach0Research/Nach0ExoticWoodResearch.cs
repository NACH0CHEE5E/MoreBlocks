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
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 15;
            AddIterationRequirement("planks", 5);
            AddIterationRequirement("logtaiga", 5);
            AddIterationRequirement("logtemperate", 5);
            AddDependency("pipliz.baseresearch.bronzeminting");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks1Craft", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks2Craft", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks3Craft", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks4Craft", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks5Craft", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Planks6Craft", true, "pipliz.woodcutter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog2Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog3Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog4Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog5Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0TreeLog6Craft", true, "pipliz.merchant");
        }
    }
}